using static System.Windows.Forms.AxHost;

namespace BoolPgia;

public class GuessScreen : Form
{
    public static int m_ButtonSize = 40;
    public static int m_Spcacing = 10;
    public const int k_StartX = 20;
    private const int k_StartY = 20;
    private int m_NumberOfGuesses;
    private int m_CurrentGuessIndex = 0;
    private List<Button> m_IndicatorButtons = new ();
    private List<GuessLine> m_GuessLines = new();
    private readonly GameLogic r_GameLogic;

    public GuessScreen(int i_NumberOfGuesses)
    {
        m_NumberOfGuesses = i_NumberOfGuesses;
        r_GameLogic = new GameLogic(m_NumberOfGuesses);
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
            m_IndicatorButtons.Add(inidicatorButton);
            this.Controls.Add(inidicatorButton);
        }

        int y = k_StartY + m_ButtonSize + m_Spcacing;

        for(int line = 0; line < m_NumberOfGuesses; line++)
        {
            GuessLine guessLine = new GuessLine(y);
            m_GuessLines.Add(guessLine);
            y += m_ButtonSize + m_Spcacing;
        }

        m_GuessLines[0].EnableButtons();

        addActionToButtons();

        int totalHeight = (m_ButtonSize + m_Spcacing) * m_NumberOfGuesses + k_StartY + m_ButtonSize + m_Spcacing;
        this.ClientSize = new Size(this.ClientSize.Width, totalHeight);
    }

    private void addActionToButtons()
    {
        foreach(GuessLine line in m_GuessLines)
        {
            foreach(Button button in line.GuessButtons)
            {
                button.Click += GuessButton_Click;
                this.Controls.Add(button);
            }
        }
    }

    private void GuessButton_Click(object? i_Sender, EventArgs i_E)
    {
        GuessChoser guessChoser = new GuessChoser();
        guessChoser.ShowDialog();
        if (guessChoser.m_SelectedColor.HasValue)
        {
            Button? clickedButton = i_Sender as Button;
            clickedButton!.BackColor = guessChoser.m_SelectedColor.Value;
        }

        moveToNextLineIfCan();
    }

    private void moveToNextLineIfCan()
    {
        int chosenCount = 0;

        foreach(Button guessButton in m_GuessLines[m_CurrentGuessIndex].GuessButtons)
        {
            if(guessButton.BackColor != GuessLine.m_IntialColor)
            {
                chosenCount++;
            }
        }

        if(chosenCount == GameUtils.k_NumberOfLettersPerGuess)
        {
            if(InputHandler.CheckValidLine(m_GuessLines[m_CurrentGuessIndex]))
            {
                m_GuessLines[m_CurrentGuessIndex].DisableButtons();
                m_CurrentGuessIndex++;
                m_GuessLines[m_CurrentGuessIndex].EnableButtons();
            }
        }
    }
}

