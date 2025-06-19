namespace BoolPgia;

public partial class GuessMenu : Form
{
    private const int k_RowStart = 20;
    private static readonly Size k_ButtonSize = new Size(k_ButtonWidth, k_ButtonWidth);
    public Color? m_SelectedColor { get; private set; }

    public GuessMenu()
    {
        initializeComponent();
        createButtons();
    }

    private void GuessButton_Click(object i_Sender, EventArgs i_E)
    {
        m_SelectedColor = (i_Sender as Button).BackColor;
        Close();
    }

    private void createGuessButton(Color i_Color, Point i_Location, int i_TabIndex)
    {
        Button tempButton = new Button();

        tempButton.BackColor = i_Color;
        tempButton.Location = i_Location;
        tempButton.Size = k_ButtonSize;
        tempButton.TabIndex = i_TabIndex;
        tempButton.UseVisualStyleBackColor = false;
        tempButton.Click += GuessButton_Click;
        Controls.Add(tempButton);
    }

    private void createButtons()
    {
        int index = 0;
        int startLocation = k_RowStart;
        int secondRowHeight = k_FirstRowHeight + k_ButtonWidth + k_FirstRowHeight;

        createGuessButton(Color.Chartreuse, new Point(startLocation, k_FirstRowHeight), index++);
        startLocation += k_ButtonWidth + k_RowStart;
        createGuessButton(Color.RoyalBlue, new Point(startLocation, k_FirstRowHeight), index++);
        startLocation += k_ButtonWidth + k_RowStart;
        createGuessButton(Color.Crimson, new Point(startLocation, k_FirstRowHeight), index++);
        startLocation += k_ButtonWidth + k_RowStart;
        createGuessButton(Color.DeepPink, new Point(startLocation, k_FirstRowHeight), index++);
        startLocation = k_RowStart;
        createGuessButton(Color.Plum, new Point(startLocation, secondRowHeight), index++);
        startLocation += k_ButtonWidth + k_RowStart;
        createGuessButton(Color.LightSkyBlue, new Point(startLocation, secondRowHeight), index++);
        startLocation += k_ButtonWidth + k_RowStart;
        createGuessButton(Color.LightSeaGreen, new Point(startLocation, secondRowHeight), index++);
        startLocation += k_ButtonWidth + k_RowStart;
        createGuessButton(Color.Purple, new Point(startLocation, secondRowHeight), index++);
    }
}