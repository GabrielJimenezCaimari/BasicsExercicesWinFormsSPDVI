namespace Exercice5
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
            this.Option1 = new System.Windows.Forms.CheckBox();
            this.Option2 = new System.Windows.Forms.CheckBox();
            this.Option3 = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(50, 63);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(83, 24);
            this.Option1.TabIndex = 0;
            this.Option1.Text = "Mouse";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(50, 135);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(60, 24);
            this.Option2.TabIndex = 1;
            this.Option2.Text = "Cat";
            this.Option2.UseVisualStyleBackColor = true;
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(50, 213);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(65, 24);
            this.Option3.TabIndex = 2;
            this.Option3.Text = "Dog";
            this.Option3.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(50, 273);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(39, 33);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(50, 346);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(652, 26);
            this.Mostrar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Option1;
        private System.Windows.Forms.CheckBox Option2;
        private System.Windows.Forms.CheckBox Option3;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox Mostrar;
    }
}

