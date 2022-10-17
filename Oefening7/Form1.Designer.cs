namespace Oefening7
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
            this.number1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Calculate1 = new System.Windows.Forms.Button();
            this.Result1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Location = new System.Drawing.Point(47, 30);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(57, 15);
            this.number1.TabIndex = 0;
            this.number1.Text = "Number :";
            // 
            // Name1
            // 
            this.Name1.HideSelection = false;
            this.Name1.Location = new System.Drawing.Point(110, 27);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(100, 23);
            this.Name1.TabIndex = 1;
            this.Name1.TextChanged += new System.EventHandler(this.Name1_TextChanged);
            // 
            // Calculate1
            // 
            this.Calculate1.Location = new System.Drawing.Point(94, 76);
            this.Calculate1.Name = "Calculate1";
            this.Calculate1.Size = new System.Drawing.Size(75, 23);
            this.Calculate1.TabIndex = 2;
            this.Calculate1.Text = "Calculate";
            this.Calculate1.UseVisualStyleBackColor = true;
            this.Calculate1.Click += new System.EventHandler(this.Calculate1_Click);
            // 
            // Result1
            // 
            this.Result1.Enabled = false;
            this.Result1.Location = new System.Drawing.Point(47, 132);
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(179, 23);
            this.Result1.TabIndex = 3;
            this.Result1.TextChanged += new System.EventHandler(this.Result1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 167);
            this.Controls.Add(this.Result1);
            this.Controls.Add(this.Calculate1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label number1;
        private TextBox Name1;
        private Button Calculate1;
        private TextBox Result1;
    }
}