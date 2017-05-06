namespace GUI_for_ToBin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.decimalNumber = new System.Windows.Forms.Label();
            this.converted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // decimalNumber
            // 
            this.decimalNumber.AutoSize = true;
            this.decimalNumber.Location = new System.Drawing.Point(12, 46);
            this.decimalNumber.Name = "decimalNumber";
            this.decimalNumber.Size = new System.Drawing.Size(85, 13);
            this.decimalNumber.TabIndex = 1;
            this.decimalNumber.Text = "Decimal Number";
            // 
            // converted
            // 
            this.converted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.converted.Location = new System.Drawing.Point(15, 88);
            this.converted.Name = "converted";
            this.converted.Size = new System.Drawing.Size(188, 21);
            this.converted.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 327);
            this.Controls.Add(this.converted);
            this.Controls.Add(this.decimalNumber);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label decimalNumber;
        private System.Windows.Forms.Label converted;
    }
}

