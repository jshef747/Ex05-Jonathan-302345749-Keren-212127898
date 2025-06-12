using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolPgia
{
    public partial class StartScreen : Form
    {
        private int m_NumberOfGuess = 4;
        public StartScreen()
        {
            InitializeComponent();
        }

        private void GuessButton_Click(object i_Sender, EventArgs i_E)
        {
            if (m_NumberOfGuess > 9)
            {
                m_NumberOfGuess = 4;
                GuessButton.Text = $"Number of guesses : {m_NumberOfGuess}";
            }
            else
            {
                m_NumberOfGuess++;
                GuessButton.Text = $"Number of guesses : {m_NumberOfGuess}";
            }
        }

        private void StartButton_Click(object i_Sender, EventArgs i_E)
        {
            GuessScreen guessScreen = new GuessScreen(m_NumberOfGuess);
            this.Hide();
            guessScreen.ShowDialog();
            this.Close();
        }
    }
}
