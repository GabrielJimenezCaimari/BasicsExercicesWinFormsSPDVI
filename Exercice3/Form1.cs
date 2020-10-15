using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRestart(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "0";
                    this.Operand2.Focus();
                }
            }
        }
        private void buttonsum(object sender, EventArgs e)
        {
            Result.Text = (int.Parse(Operand1.Text) + int.Parse(Operand2.Text)).ToString();
        }
    }
}
