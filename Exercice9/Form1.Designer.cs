namespace Exercice9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxNumeros = new System.Windows.Forms.ComboBox();
            this.buttonPar = new System.Windows.Forms.Button();
            this.buttonImpar = new System.Windows.Forms.Button();
            this.MostrarNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxNumeros
            // 
            this.comboBoxNumeros.FormattingEnabled = true;
            this.comboBoxNumeros.Location = new System.Drawing.Point(100, 100);
            this.comboBoxNumeros.Name = "comboBoxNumeros";
            this.comboBoxNumeros.Size = new System.Drawing.Size(80, 28);
            this.comboBoxNumeros.TabIndex = 0;
            this.comboBoxNumeros.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumeros_SelectedIndexChanged);
            // 
            // buttonPar
            // 
            this.buttonPar.Location = new System.Drawing.Point(286, 95);
            this.buttonPar.Name = "buttonPar";
            this.buttonPar.Size = new System.Drawing.Size(67, 37);
            this.buttonPar.TabIndex = 1;
            this.buttonPar.Text = "Even";
            this.buttonPar.UseVisualStyleBackColor = true;
            this.buttonPar.Click += new System.EventHandler(this.buttonPar_Click);
            // 
            // buttonImpar
            // 
            this.buttonImpar.Location = new System.Drawing.Point(503, 95);
            this.buttonImpar.Name = "buttonImpar";
            this.buttonImpar.Size = new System.Drawing.Size(67, 37);
            this.buttonImpar.TabIndex = 2;
            this.buttonImpar.Text = "Odd";
            this.buttonImpar.UseVisualStyleBackColor = true;
            this.buttonImpar.Click += new System.EventHandler(this.buttonImpar_Click);
            // 
            // MostrarNumero
            // 
            this.MostrarNumero.Location = new System.Drawing.Point(100, 328);
            this.MostrarNumero.Name = "MostrarNumero";
            this.MostrarNumero.Size = new System.Drawing.Size(470, 26);
            this.MostrarNumero.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MostrarNumero);
            this.Controls.Add(this.buttonImpar);
            this.Controls.Add(this.buttonPar);
            this.Controls.Add(this.comboBoxNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNumeros;
        private System.Windows.Forms.Button buttonPar;
        private System.Windows.Forms.Button buttonImpar;
        private System.Windows.Forms.TextBox MostrarNumero;
    }
}

