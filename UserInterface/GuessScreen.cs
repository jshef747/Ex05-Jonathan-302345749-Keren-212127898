namespace BoolPgia;

public class GuessScreen : Form
{
    public static int m_ButtonSize = 40;
    public static int m_Spcacing = 10;
    public const int k_StartX = 20;
    private const int k_StartY = 20;
    private readonly int r_NumberOfGuesses;
    private int m_CurrentGuessIndex = 0;
    private readonly List<Button> r_IndicatorButtons = new ();
    private readonly List<GuessLine> r_GuessLines = new();
    private readonly GameLogic r_GameLogic;

    public GuessScreen(int i_NumberOfGuesses)
    {
        this.MaximizeBox = false;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.ShowIcon = false;
        this.Text = "Guess Screen";
        r_NumberOfGuesses = i_NumberOfGuesses;
        r_GameLogic = new GameLogic(r_NumberOfGuesses);

        initialize();
    }

    private void initialize()
    {
        for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
        {
            Button inidicatorButton = new Button();
            inidicatorButton.Size = new Size(m_ButtonSize, m_ButtonSize);
            inidicatorButton.Location = new Point(k_StartX + (i * (m_ButtonSize + m_Spcacing)), k_StartY);
            inidicatorButton.BackColor = Color.Black;
            inidicatorButton.Enabled = false;

            r_IndicatorButtons.Add(inidicatorButton);
            this.Controls.Add(inidicatorButton);
        }

        int y = k_StartY + m_ButtonSize + m_Spcacing;

        for(int line = 0; line < r_NumberOfGuesses; line++)
        {
            GuessLine guessLine = new GuessLine(y);

            r_GuessLines.Add(guessLine);
            y += m_ButtonSize + m_Spcacing;
        }

        r_GuessLines[0].EnableGuessButtons();

        addActionToButtons();

        int totalHeight = (m_ButtonSize + m_Spcacing) * r_NumberOfGuesses + k_StartY + m_ButtonSize + m_Spcacing;
        this.ClientSize = new Size(r_GuessLines[0].GetLineLength(), totalHeight);
    }

    private void addActionToButtons()
    {
        foreach(GuessLine line in r_GuessLines)
        {
            foreach(Button button in line.GuessButtons)
            {
                button.Click += GuessButton_Click;
                this.Controls.Add(button);
            }

            line.ArrowButton.Click += ArrowButton_Click;
            this.Controls.Add(line.ArrowButton);

            foreach (Button button in line.ResultButtons)
            {
                this.Controls.Add(button);
            }
        }
    }

    private void ArrowButton_Click(object i_Sender, EventArgs i_E)
    {
        string guessInString = string.Empty;

        foreach (Button button in r_GuessLines[m_CurrentGuessIndex].GuessButtons)
        {
            guessInString += ColorMapping.sr_KColorMapping[button.BackColor];
        }

        List<int> numberOfVAndX = r_GameLogic.GenerateGuessFeedback(guessInString);
        r_GuessLines[m_CurrentGuessIndex].ColorResult(numberOfVAndX);

        (i_Sender as Button).Enabled = false;

        r_GuessLines[m_CurrentGuessIndex].DisableGuessButtons();
        m_CurrentGuessIndex++;

        if (numberOfVAndX[0] == GameUtils.k_NumberOfLettersPerGuess)
        {
            //WON
            showResult();

            if (m_CurrentGuessIndex < r_NumberOfGuesses)
            {
                r_GuessLines[m_CurrentGuessIndex].DisableGuessButtons();
            }
        }
        else if (m_CurrentGuessIndex < r_NumberOfGuesses)
        {
            r_GuessLines[m_CurrentGuessIndex].EnableGuessButtons();
        }
        else
        {
            //LOST
            showResult();
        }
    }

    private void showResult()
    {
        string? result = r_GameLogic.GetResult();

        if (result != null)
        {
            int index = 0;

            foreach (Button button in r_IndicatorButtons)
            {
                char letter = result[index++];

                if (ColorMapping.sr_KCharToColorMapping.TryGetValue(letter, out Color color))
                {
                    button.BackColor = color;
                }
                else
                {
                    //TODO: Handle invalid letter if needed
                }
            }
        }
    }

    private void GuessButton_Click(object? i_Sender, EventArgs i_E)
    {
        ColorChoser guessChoser = new ColorChoser();
        guessChoser.ShowDialog();

        if (guessChoser.m_SelectedColor.HasValue)
        {
            Button? clickedButton = i_Sender as Button;
            clickedButton!.BackColor = guessChoser.m_SelectedColor.Value;
        }

        enableArrowButtonIfCan();
    }

    private void enableArrowButtonIfCan()
    {
        int chosenCount = 0;

        foreach(Button guessButton in r_GuessLines[m_CurrentGuessIndex].GuessButtons)
        {
            if(guessButton.BackColor != GuessLine.k_InitialColor)
            {
                chosenCount++;
            }
        }

        if(chosenCount == GameUtils.k_NumberOfLettersPerGuess)
        {
            if(InputHandler.CheckValidLine(r_GuessLines[m_CurrentGuessIndex]))
            {
                r_GuessLines[m_CurrentGuessIndex].EnableArrowButton();
            }
        }
    }
}

