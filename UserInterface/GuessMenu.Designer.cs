namespace BoolPgia;

partial class GuessMenu
{
    private const int k_ButtonWidth = 60;
    private const int k_FirstRowHeight = 10;
    private const int k_FormWidth = (k_ButtonWidth) * 11;
    private const int k_FormHeight = (k_ButtonWidth + k_FirstRowHeight) * 5;
    private const float k_AutoScaleWidth = 13F;
    private const float k_AutoScaleHeight = 32F;

    private void initializeComponent()
    {
        SuspendLayout();
        AutoScaleDimensions = new SizeF(k_AutoScaleWidth, k_AutoScaleHeight);
        ClientSize = new Size(k_FormWidth, k_FormHeight);
        AutoScaleMode = AutoScaleMode.Font;
        ResumeLayout(false);
    }
}