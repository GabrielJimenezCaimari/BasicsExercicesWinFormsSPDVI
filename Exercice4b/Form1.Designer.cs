namespace Exercice4b
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
            this.label2 = new System.Windows.Forms.Label();
            this.Operand1 = new System.Windows.Forms.TextBox();
            this.Operand2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Operacion = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxOperacion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccione la operación a realizar";
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(68, 144);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(143, 26);
            this.Operand1.TabIndex = 11;
            // 
            // Operand2
            // 
            this.Operand2.Location = new System.Drawing.Point(68, 258);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(143, 26);
            this.Operand2.TabIndex = 12;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(528, 202);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(143, 26);
            this.Result.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Operación seleccionada";
            // 
            // Operacion
            // 
            this.Operacion.Location = new System.Drawing.Point(357, 315);
            this.Operacion.Name = "Operacion";
            this.Operacion.Size = new System.Drawing.Size(26, 26);
            this.Operacion.TabIndex = 15;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(548, 315);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 32);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(111, 315);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 32);
            this.buttonCalculate.TabIndex = 17;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // listBoxOperacion
            // 
            this.listBoxOperacion.FormattingEnabled = true;
            this.listBoxOperacion.ItemHeight = 20;
            this.listBoxOperacion.Items.AddRange(new object[] {
            "+",
            "-"});
            this.listBoxOperacion.Location = new System.Drawing.Point(357, 96);
            this.listBoxOperacion.Name = "listBoxOperacion";
            this.listBoxOperacion.Size = new System.Drawing.Size(26, 44);
            this.listBoxOperacion.TabIndex = 18;
            this.listBoxOperacion.SelectedIndexChanged += new System.EventHandler(this.listBoxOperacion_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOperacion);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.Operacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Operand1;
        private System.Windows.Forms.TextBox Operand2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Operacion;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox listBoxOperacion;
    }
}

