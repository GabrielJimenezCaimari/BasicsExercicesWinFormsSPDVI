﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice4a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (Operacion.Text == "+")
            {
                Result.Text = (int.Parse(Operand1.Text) + int.Parse(Operand2.Text)).ToString();
            }
            else if(Operacion.Text == "-")
            {
                Result.Text = (int.Parse(Operand1.Text) - int.Parse(Operand2.Text)).ToString();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Operand1.Text = "0";
            Operand2.Text = "0";
            Result.Text = "0";
            Operacion.Text = "";

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            Operacion.Text = "+";
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            Operacion.Text = "-";
        }
    }
}
