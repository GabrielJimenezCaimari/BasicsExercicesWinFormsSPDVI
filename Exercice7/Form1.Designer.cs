namespace Exercice7
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
            this.comboBoxColour = new System.Windows.Forms.ComboBox();
            this.Mostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxColour
            // 
            this.comboBoxColour.FormattingEnabled = true;
            this.comboBoxColour.Location = new System.Drawing.Point(297, 93);
            this.comboBoxColour.Name = "comboBoxColour";
            this.comboBoxColour.Size = new System.Drawing.Size(187, 28);
            this.comboBoxColour.TabIndex = 0;
            this.comboBoxColour.SelectedIndexChanged += new System.EventHandler(this.comboBoxColour_SelectedIndexChanged);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(110, 359);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(584, 26);
            this.Mostrar.TabIndex = 1;
            this.Mostrar.TextChanged += new System.EventHandler(this.Mostrar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.comboBoxColour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColour;
        private System.Windows.Forms.TextBox Mostrar;
    }
}

