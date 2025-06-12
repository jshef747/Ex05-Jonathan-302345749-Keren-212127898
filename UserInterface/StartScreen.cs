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

        private void GuessButtom_Click(object sender, EventArgs e)
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

        private void StartButtom_Click(object sender, EventArgs e)
        {
            GuessScreen guessScreen = new GuessScreen(m_NumberOfGuess);
            guessScreen.ShowDialog();
            this.Close();
        }
    }
}
