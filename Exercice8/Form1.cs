using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrarclassroom1_Click(object sender, EventArgs e)
        {
            MostrarClase.Items.Clear();
            Mostrarnombre.Text = "";
            MostrarClase.Items.Add("Gabriel");
            MostrarClase.Items.Add("Javi");
            MostrarClase.Items.Add("Pedro");
        }

        private void Mostrarclassroom2_Click(object sender, EventArgs e)
        {
            MostrarClase.Items.Clear();
            Mostrarnombre.Text = "";
            MostrarClase.Items.Add("Emilio");
            MostrarClase.Items.Add("Miguel");
            MostrarClase.Items.Add("Carlos");
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            MostrarClase.Items.Clear();
            Mostrarnombre.Text = "";
        }

        private void MostrarClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrarnombre.Text = MostrarClase.SelectedItem.ToString();
        }
    }
}
