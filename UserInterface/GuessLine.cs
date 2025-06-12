using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace BoolPgia;

public class GuessLine
{
    public List<Button> GuessButtons { get; set; } = new();



    public GuessLine(int i_Y)
    {
        for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
        {
            int buttonSize = GuessScreen.m_ButtonSize;
            int spcacing = GuessScreen.m_Spcacing;
            Button guessButton = new Button();
            guessButton.Size = new Size(buttonSize, buttonSize);
            guessButton.Location = new Point(GuessScreen.k_StartX + (i * (buttonSize + spcacing)), i_Y);
            guessButton.BackColor = Color.Gray;
            guessButton.Enabled = false;
            GuessButtons.Add(guessButton);
        }
    }

    public void EnableButtons()
    {
        foreach (Button button in GuessButtons)
        {
            button.Enabled = true;
        }
    }

    public void DisableButtons()
    {
        foreach (Button button in GuessButtons)
        {
            button.Enabled = false;
        }
    }
}

