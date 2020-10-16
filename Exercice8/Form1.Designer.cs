namespace Exercice8
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
            this.MostrarClase = new System.Windows.Forms.ListBox();
            this.Mostrarclassroom1 = new System.Windows.Forms.Button();
            this.Mostrarclassroom2 = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Mostrarnombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MostrarClase
            // 
            this.MostrarClase.FormattingEnabled = true;
            this.MostrarClase.ItemHeight = 20;
            this.MostrarClase.Location = new System.Drawing.Point(30, 25);
            this.MostrarClase.Name = "MostrarClase";
            this.MostrarClase.Size = new System.Drawing.Size(142, 264);
            this.MostrarClase.TabIndex = 0;
            this.MostrarClase.SelectedIndexChanged += new System.EventHandler(this.MostrarClase_SelectedIndexChanged);
            // 
            // Mostrarclassroom1
            // 
            this.Mostrarclassroom1.Location = new System.Drawing.Point(30, 315);
            this.Mostrarclassroom1.Name = "Mostrarclassroom1";
            this.Mostrarclassroom1.Size = new System.Drawing.Size(105, 46);
            this.Mostrarclassroom1.TabIndex = 1;
            this.Mostrarclassroom1.Text = "Classroom1";
            this.Mostrarclassroom1.UseVisualStyleBackColor = true;
            this.Mostrarclassroom1.Click += new System.EventHandler(this.Mostrarclassroom1_Click);
            // 
            // Mostrarclassroom2
            // 
            this.Mostrarclassroom2.Location = new System.Drawing.Point(30, 392);
            this.Mostrarclassroom2.Name = "Mostrarclassroom2";
            this.Mostrarclassroom2.Size = new System.Drawing.Size(105, 46);
            this.Mostrarclassroom2.TabIndex = 2;
            this.Mostrarclassroom2.Text = "Classroom2";
            this.Mostrarclassroom2.UseVisualStyleBackColor = true;
            this.Mostrarclassroom2.Click += new System.EventHandler(this.Mostrarclassroom2_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(182, 349);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(128, 56);
            this.Clearbutton.TabIndex = 3;
            this.Clearbutton.Text = "Clear list";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Mostrarnombre
            // 
            this.Mostrarnombre.Location = new System.Drawing.Point(246, 124);
            this.Mostrarnombre.Name = "Mostrarnombre";
            this.Mostrarnombre.Size = new System.Drawing.Size(431, 26);
            this.Mostrarnombre.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mostrarnombre);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Mostrarclassroom2);
            this.Controls.Add(this.Mostrarclassroom1);
            this.Controls.Add(this.MostrarClase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MostrarClase;
        private System.Windows.Forms.Button Mostrarclassroom1;
        private System.Windows.Forms.Button Mostrarclassroom2;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.TextBox Mostrarnombre;
    }
}

