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
    public Button ArrowButton { get; set; }
    public List<Button> ResultButtons { get; set; } = new();
    public static Color m_IntialColor = Color.Gray;
    public GuessLine(int i_Y)
    {
        int buttonSize = GuessScreen.m_ButtonSize;
        int spacing = GuessScreen.m_Spcacing;

        for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
        {    
            Button guessButton = new Button();
            guessButton.Size = new Size(buttonSize, buttonSize);
            guessButton.Location = new Point(GuessScreen.k_StartX + (i * (buttonSize + spacing)), i_Y);
            guessButton.BackColor = m_IntialColor;
            guessButton.Enabled = false;
            GuessButtons.Add(guessButton);
        }
        
        ArrowButton = new Button();
        ArrowButton.Size = new Size(buttonSize + 10, buttonSize / 2);
        ArrowButton.Location = new Point(GuessScreen.k_StartX + (GameUtils.k_NumberOfLettersPerGuess * (buttonSize + spacing)), i_Y + buttonSize / 4); // Center vertically
        ArrowButton.Text = ">>";
        ArrowButton.Enabled = false;
        int resultButtonSize = buttonSize / 3;
        int resultSpacing = 5;

        for (int i = 0; i < GameUtils.k_NumberOfLettersPerGuess; i++)
        {
            Button resultButton = new Button();
            resultButton.Size = new Size(resultButtonSize, resultButtonSize);

            int col = i % 2;
            int row = i / 2;

            int x = ArrowButton.Location.X + ArrowButton.Width + (col * (resultButtonSize + resultSpacing));
            int y = i_Y + (row * (resultButtonSize + resultSpacing));

            resultButton.Location = new Point(x, y);
            resultButton.BackColor = Color.White;
            resultButton.Enabled = false;

            ResultButtons.Add(resultButton);
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
        if (ResultButtons.Count == 0)
        {
            return 0;
        }

        int lastResultButtonRight = ResultButtons.Last().Right;
        return lastResultButtonRight + 20;
    }

    public void ColorResult(List<int> i_NumberOfVAndX)
    {
        int buttonIndex = 0;

        for(int i = 0; i < i_NumberOfVAndX[0]; i++, buttonIndex++)
        {
            ResultButtons[buttonIndex].BackColor = Color.Black;
        }
        
        for(int i = 0; i < i_NumberOfVAndX[1]; i++, buttonIndex++)
        {
            ResultButtons[buttonIndex].BackColor = Color.Yellow;
        }
    }
}

