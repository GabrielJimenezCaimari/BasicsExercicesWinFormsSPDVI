using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPar_Click(object sender, EventArgs e)
        {
            comboBoxNumeros.Items.Clear();
            System.Object[] arraypar = new System.Object[6];
            for(int i = 0; i <= 10; i = i + 2)
            {
                arraypar[i / 2] = i;
            }
            comboBoxNumeros.Items.AddRange(arraypar);
        }

        private void buttonImpar_Click(object sender, EventArgs e)
        {
            comboBoxNumeros.Items.Clear();
            System.Object[] arrayimpar = new System.Object[5];
            for (int i = 1; i <= 10; i = i + 2)
            {
                arrayimpar[i / 2] = i;
            }
            comboBoxNumeros.Items.AddRange(arrayimpar);
        }

        private void comboBoxNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarNumero.Text = comboBoxNumeros.SelectedItem.ToString();
        }
    }
}
