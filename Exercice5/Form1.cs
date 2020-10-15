using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            String[] animals = new String[3];
            int i = 0;
            if(Option1.Checked)
            {
                animals[i] = Option1.Text;
                i++;
            }

            if (Option2.Checked)
            {
                animals[i] = Option2.Text;
                i++;
            }

            if (Option3.Checked)
            {
                animals[i] = Option3.Text;
                i++;
            }

            Mostrar.Text = "Chosen animals: " + animals[0] + " " + animals[1] + " " + animals[2];
        }
    }
}
