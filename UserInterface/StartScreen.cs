namespace BoolPgia;

public partial class StartScreen : Form
{
    private int m_NumberOfGuesses = GameUtils.k_MinimumNumberOfGuesses;
    private readonly Size r_GuessNumberButtonSize = new Size(400, 50);
    private readonly Point r_GuessNumberLocation = new Point(20, 40);
    private readonly string r_GuessNumberText = "Number of guesses : ";
    private readonly Size r_StartButtonSize = new Size(200, 50);
    private readonly Point r_StartLocation = new Point(100, 110);
    private readonly string r_StartText = "Start";

    public StartScreen()
    {
        InitializeComponent();
        createButtons();
    }

    private void createButton(Size i_Size, Point i_Location, int i_TabIndex, string i_Text, bool i_UseVisual, EventHandler i_Event, Color i_Color)
    {
        Button tempButton = new Button();

        tempButton.Size = i_Size;
        tempButton.Location = i_Location;
        tempButton.TabIndex = i_TabIndex;
        tempButton.Text = i_Text;
        tempButton.UseVisualStyleBackColor = i_UseVisual;
        tempButton.Click += i_Event;
        tempButton.BackColor = i_Color;
        Controls.Add(tempButton);
    }

    private void createButtons()
    {
        int index = 0;
        string guessButtonText = $"{r_GuessNumberText}{m_NumberOfGuesses}";
        bool GuessNumberUseVisualStyle = true;
        bool StartUseVisualStyle = false;

        createButton(r_GuessNumberButtonSize, r_GuessNumberLocation, index++, guessButtonText, GuessNumberUseVisualStyle, GuessButton_Click, Color.White);
        createButton(r_StartButtonSize, r_StartLocation, index, r_StartText, StartUseVisualStyle, StartButton_Click, Color.LightGreen);
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
