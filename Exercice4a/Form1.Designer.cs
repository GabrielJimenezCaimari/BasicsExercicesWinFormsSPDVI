namespace Exercice4a
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
            this.Operand1 = new System.Windows.Forms.TextBox();
            this.Operand2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Operacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(65, 98);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(143, 26);
            this.Operand1.TabIndex = 0;
            // 
            // Operand2
            // 
            this.Operand2.Location = new System.Drawing.Point(65, 245);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(143, 26);
            this.Operand2.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(576, 171);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(143, 26);
            this.Result.TabIndex = 2;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Operacion
            // 
            this.Operacion.Location = new System.Drawing.Point(355, 318);
            this.Operacion.Name = "Operacion";
            this.Operacion.Size = new System.Drawing.Size(26, 26);
            this.Operacion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operación seleccionada";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(576, 312);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 32);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(108, 312);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 32);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(317, 121);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(100, 32);
            this.buttonSum.TabIndex = 7;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(317, 207);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(100, 32);
            this.buttonSubstract.TabIndex = 8;
            this.buttonSubstract.Text = "Substract";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione la operación a realizar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operacion);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Operand1;
        private System.Windows.Forms.TextBox Operand2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Operacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Label label2;
    }
}

