using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
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
            if(m_NumberOfGuess > 9)
            {
                m_NumberOfGuess = 4;
                GuessButtom.Text  = $"Number of guesses : {m_NumberOfGuess}";
            }
            else
            {
                m_NumberOfGuess++;
                GuessButtom.Text = $"Number of guesses : {m_NumberOfGuess}";
            }
        }
    }
}
