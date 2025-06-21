namespace BoolPgia;
public partial class ColorChoser : Form
{
    public Color? m_SelectedColor { get; private set; }
    public ColorChoser()
    {
        InitializeComponent();
    }

    private void GuessButton_Click(object i_Sender, EventArgs i_E)
    {
        m_SelectedColor = (i_Sender as Button).BackColor;
        Close();
    }
}