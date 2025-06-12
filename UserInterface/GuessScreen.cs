using static System.Windows.Forms.AxHost;

namespace BoolPgia;

public class GuessScreen : Form
{
    private const int buttonSize = 40;
    private const int spcacing = 10;
    private const int startX = 20;
    private const int startY = 20;
    private int m_NumberOfGuesses;
    private int m_currentGuessIndex = 0;
    private List<Button> indicatorButtons = new ();
    private List<List<Button>> m_guessLines = new ();
    private readonly GameLogic r_GameLogic;

    public GuessScreen(int i_NumberOfGuesses)
    {
        m_NumberOfGuesses = i_NumberOfGuesses;
        r_GameLogic = new GameLogic(m_NumberOfGuesses);
        Initialize();
    }

    private void Initialize()
    {
        for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
        {
            Button inidicatorButton = new Button();
            inidicatorButton.Size = new Size(buttonSize, buttonSize);
            inidicatorButton.Location = new Point(startX + (i * (buttonSize + spcacing)), startY);
            inidicatorButton.BackColor = Color.Black;
            inidicatorButton.Enabled = false;
            indicatorButtons.Add(inidicatorButton);
            this.Controls.Add(inidicatorButton);
        }

        int y = startY + buttonSize + spcacing;

        for (int line = 0; line < m_NumberOfGuesses; line++)
        {
            List<Button> guessLine = new List<Button>();
            for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
            {
                Button guessButton = new Button();
                guessButton.Size = new Size(buttonSize, buttonSize);
                guessButton.Location = new Point(startX + (i * (buttonSize + spcacing)), y);
                guessButton.BackColor = Color.Gray;
                guessButton.Click += GuessButton_Click;
                guessButton.Enabled = (line == 0);
                guessLine.Add(guessButton);
                this.Controls.Add(guessButton);
            }
            m_guessLines.Add(guessLine);
            y += buttonSize + spcacing;
        }
        int totalHeight = (buttonSize + spcacing) * m_NumberOfGuesses + startY + buttonSize + spcacing;
        this.ClientSize = new Size(this.ClientSize.Width, totalHeight);

    }

    private void GuessButton_Click(object? sender, EventArgs e)
    {
        GuessChoser guessChoser = new GuessChoser();
        guessChoser.ShowDialog();
        if (guessChoser.m_selectedColor.HasValue)
        {
            Button clickedButton = sender as Button;
            clickedButton.BackColor = guessChoser.m_selectedColor.Value;
        }

        if(InputHandler.checkValidLine(m_guessLines[m_currentGuessIndex]))
        {
            //TODO: the submit button should be enabled only after a valid guess

            foreach(Button button in m_guessLines[m_currentGuessIndex])
            {
                button.Enabled = false;
            }

            m_currentGuessIndex++;

            if(m_currentGuessIndex < m_NumberOfGuesses)
            {
                foreach(Button button in m_guessLines[m_currentGuessIndex])
                {
                    button.Enabled = true;
                }
            }
        }
    }
}

