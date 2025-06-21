namespace BoolPgia;

public partial class StartScreen : Form
{
    private int m_NumberOfGuesses = GameUtils.k_MinimumNumberOfGuesses;
    private readonly string r_GuessNumberText = "Number of guesses : ";

    public StartScreen()
    {
        InitializeComponent();
    }

    private void GuessButton_Click(object i_Sender, EventArgs i_E)
    {
        m_NumberOfGuesses = (m_NumberOfGuesses > GameUtils.k_MaximumNumberOfGuesses - 1) ? GameUtils.k_MinimumNumberOfGuesses : ++m_NumberOfGuesses;
        (i_Sender as Button).Text = $"{r_GuessNumberText}{m_NumberOfGuesses}";
    }

    private void StartButton_Click(object i_Sender, EventArgs i_E)
    {
        GuessScreen guessScreen = new GuessScreen(m_NumberOfGuesses);

        Hide();
        guessScreen.ShowDialog();
        Close();
    }
}