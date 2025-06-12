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
    public partial class GuessChoser : Form
    {
        public Color? m_SelectedColor { get; private set; }
        public GuessChoser()
        {
            InitializeComponent();
        }

        private void GuessButton_Click(object i_Sender, EventArgs i_E)
        {
            Button colorButton = i_Sender as Button;
            m_SelectedColor = colorButton.BackColor;
            this.Close();
        }
    }
}
