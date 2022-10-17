namespace Oefening5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Celsius1 = new System.Windows.Forms.TextBox();
            this.Fahrenheit1 = new System.Windows.Forms.TextBox();
            this.CtoF = new System.Windows.Forms.Button();
            this.FtoC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // Celsius1
            // 
            this.Celsius1.Location = new System.Drawing.Point(27, 67);
            this.Celsius1.Name = "Celsius1";
            this.Celsius1.Size = new System.Drawing.Size(78, 23);
            this.Celsius1.TabIndex = 2;
            this.Celsius1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Fahrenheit1
            // 
            this.Fahrenheit1.Location = new System.Drawing.Point(168, 67);
            this.Fahrenheit1.Name = "Fahrenheit1";
            this.Fahrenheit1.Size = new System.Drawing.Size(78, 23);
            this.Fahrenheit1.TabIndex = 3;
            // 
            // CtoF
            // 
            this.CtoF.Location = new System.Drawing.Point(27, 118);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(75, 23);
            this.CtoF.TabIndex = 4;
            this.CtoF.Text = "C to F";
            this.CtoF.UseVisualStyleBackColor = true;
            this.CtoF.Click += new System.EventHandler(this.CtoF_Click);
            // 
            // FtoC
            // 
            this.FtoC.Location = new System.Drawing.Point(171, 118);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(75, 23);
            this.FtoC.TabIndex = 5;
            this.FtoC.Text = "F to C";
            this.FtoC.UseVisualStyleBackColor = true;
            this.FtoC.Click += new System.EventHandler(this.FtoC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 165);
            this.Controls.Add(this.FtoC);
            this.Controls.Add(this.CtoF);
            this.Controls.Add(this.Fahrenheit1);
            this.Controls.Add(this.Celsius1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CelsiusToFahrenheit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Celsius1;
        private TextBox Fahrenheit1;
        private Button CtoF;
        private Button FtoC;
    }
}