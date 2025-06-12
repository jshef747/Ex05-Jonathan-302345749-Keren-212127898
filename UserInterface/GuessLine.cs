using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace BoolPgia;

public class GuessLine
{
    public List<Button> guessButtons { get; set; } = new();



    public GuessLine(int y)
    {
        for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
        {
            int buttonSize = GuessScreen.buttonSize;
            int spcacing = GuessScreen.spcacing;
            Button guessButton = new Button();
            guessButton.Size = new Size(buttonSize, buttonSize);
            guessButton.Location = new Point(GuessScreen.startX + (i * (buttonSize + spcacing)), y);
            guessButton.BackColor = Color.Gray;
            guessButton.Enabled = false;
            guessButtons.Add(guessButton);
        }
    }

    public void enableButtons()
    {
        foreach (Button button in guessButtons)
        {
            button.Enabled = true;
        }
    }

    public void disableButtons()
    {
        foreach (Button button in guessButtons)
        {
            button.Enabled = false;
        }
    }
}

