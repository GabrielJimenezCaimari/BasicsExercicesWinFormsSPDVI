using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxColour.Items.Insert(0, "White");
            comboBoxColour.Items.Insert(1, "Black");
            comboBoxColour.Items.Insert(2, "Pink");
            comboBoxColour.Items.Insert(3, "Red");
            comboBoxColour.Items.Insert(4, "Blue");
        }

        private void comboBoxColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrar.Text = "the choosen colour is: " + comboBoxColour.Text;
        }

        private void Mostrar_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
