using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            String color = "";
            if(Option1.Checked)
            {
                color = Option1.Text;
            }

            if (Option2.Checked)
            {
                color = Option2.Text;
            }

            if (Option3.Checked)
            {
                color = Option3.Text;
            }

            Mostrar.Text = "Choosen colour: " + color;
        }
    }
}
