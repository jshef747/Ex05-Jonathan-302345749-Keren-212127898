namespace BoolPgia;

public class GuessLine
{
    public static readonly Color k_InitialColor = Color.Gray;
    public static readonly Color k_ResultExactColor = Color.Black;
    public static readonly Color k_ResultPartialColor = Color.Yellow;
    public static readonly Color k_ResultEmptyColor = Color.White;
    public static readonly Color k_ArrowColor = Color.White;
    private const int k_ArrowButtonTextOffset = 10;
    private const int k_ArrowButtonHeightDivider = 2;
    private const int k_ArrowButtonVerticalOffsetDivider = 4;
    private const string k_ArrowText = ">>";
    private const int k_ResultSpacing = 5;
    private const int k_ResultButtonsPerRow = 2;
    private const int k_ResultLineEndOffset = 20;
    public List<Button> GuessButtons { get; set; } = new();
    public Button ArrowButton { get; set; }
    public List<Button> ResultButtons { get; set; } = new();

    public GuessLine(int i_Ylocation)
    {
        createGuessButtons(i_Ylocation);
        createArrowButton(i_Ylocation);
        createResultButtons(i_Ylocation);
    }

    private Button createButton(int i_X, int i_Y, int i_Width, int i_Height, Color i_BackColor, string i_Text = "")
    {
        Button button = new Button();
        button.Size = new Size(i_Width, i_Height);
        button.Location = new Point(i_X, i_Y);
        button.BackColor = i_BackColor;
        button.Text = i_Text;
        button.Enabled = false;
        return button;
    }

    private void createGuessButtons(int i_Ylocation)
    {
        int buttonSize = GuessScreen.m_ButtonSize;

        for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
        {
            int guessButtonXLocation = GuessScreen.k_StartX + (i * (buttonSize + GuessScreen.m_Spcacing));

            GuessButtons.Add(createButton(guessButtonXLocation, i_Ylocation, buttonSize, buttonSize, k_InitialColor));
        }
    }

    private void createArrowButton(int i_Ylocation)
    {
        int buttonSize = GuessScreen.m_ButtonSize;
        int arrowButtonXLoaction = GuessScreen.k_StartX + (GameUtils.k_NumberOfLettersPerGuess * (buttonSize + GuessScreen.m_Spcacing));
        int arrowButtonYLocation = i_Ylocation + buttonSize / k_ArrowButtonVerticalOffsetDivider;
        int arrowButtonWidth = buttonSize + k_ArrowButtonTextOffset;
        int arrowButtonHeight = buttonSize / k_ArrowButtonHeightDivider;

        ArrowButton = createButton(arrowButtonXLoaction, arrowButtonYLocation, arrowButtonWidth, arrowButtonHeight, k_ArrowColor, k_ArrowText);
    }

    private void createResultButtons(int i_Ylocation)
    {
        for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
        {
            int resultButtonSize = GuessScreen.m_ButtonSize / 3;
            int col = i % k_ResultButtonsPerRow;
            int row = i / k_ResultButtonsPerRow;
            int resultButtonXLoaction = ArrowButton.Location.X + ArrowButton.Width
                                                               + (col * (resultButtonSize + k_ResultSpacing))
                                                               + k_ResultSpacing;
            int resultButtonYLoaction = i_Ylocation + (row * (resultButtonSize + k_ResultSpacing));

            ResultButtons.Add(createButton(resultButtonXLoaction, resultButtonYLoaction, resultButtonSize, resultButtonSize, k_ResultEmptyColor));
        }
    }

    public void EnableArrowButton()
    {
        ArrowButton.Enabled = true;
    }

    public void EnableGuessButtons()
    {
        foreach (Button button in GuessButtons)
        {
            button.Enabled = true;
        }
    }

    public void DisableGuessButtons()
    {
        foreach (Button button in GuessButtons)
        {
            button.Enabled = false;
        }
    }

    public int GetLineLength()
    {
        int resultVaule = 0;

        if (ResultButtons.Count != 0)
        {
            resultVaule = ResultButtons.Last().Right + k_ResultLineEndOffset;
        }

        return resultVaule;
    }

    public void ColorResult(List<int> i_NumberOfVAndX)
    {
        int buttonIndex = 0;

        for(int i = 0; i < i_NumberOfVAndX[0]; i++, buttonIndex++)
        {
            ResultButtons[buttonIndex].BackColor = k_ResultExactColor;
        }
        
        for(int i = 0; i < i_NumberOfVAndX[1]; i++, buttonIndex++)
        {
            ResultButtons[buttonIndex].BackColor = k_ResultPartialColor;
        }
    }
}

