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
        public Color? m_selectedColor { get; private set; }
        public GuessChoser()
        {
            InitializeComponent();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            Button colorButton = sender as Button;
            m_selectedColor = colorButton.BackColor;
            this.Close();
        }
    }
}
