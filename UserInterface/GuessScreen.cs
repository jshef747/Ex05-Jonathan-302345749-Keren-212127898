using static System.Windows.Forms.AxHost;

namespace BoolPgia;

public class GuessScreen : Form
{
    public static int buttonSize = 40;
    public static int spcacing = 10;
    public const int startX = 20;
    private const int startY = 20;
    private int m_NumberOfGuesses;
    private int m_currentGuessIndex = 0;
    private List<Button> indicatorButtons = new ();
    private List<GuessLine> m_guessLines = new();
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

        for(int line = 0; line < m_NumberOfGuesses; line++)
        {
            GuessLine guessLine = new GuessLine(y);
            m_guessLines.Add(guessLine);
            y += buttonSize + spcacing;
        }

        m_guessLines[0].enableButtons();

        addActionToButtons();

        int totalHeight = (buttonSize + spcacing) * m_NumberOfGuesses + startY + buttonSize + spcacing;
        this.ClientSize = new Size(this.ClientSize.Width, totalHeight);
    }

    private void addActionToButtons()
    {
        foreach(GuessLine line in m_guessLines)
        {
            foreach(Button button in line.guessButtons)
            {
                button.Click += GuessButton_Click;
                this.Controls.Add(button);
            }
        }
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

            m_guessLines[m_currentGuessIndex].disableButtons();
            m_currentGuessIndex++;
            m_guessLines[m_currentGuessIndex].enableButtons();
        }
    }
}

