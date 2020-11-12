namespace Gra_Karciana
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
            this.dec1 = new System.Windows.Forms.ListBox();
            this.dec2 = new System.Windows.Forms.ListBox();
            this.SwapRight = new System.Windows.Forms.Button();
            this.SwapLeft = new System.Windows.Forms.Button();
            this.Reset1 = new System.Windows.Forms.Button();
            this.Reset2 = new System.Windows.Forms.Button();
            this.Mix2 = new System.Windows.Forms.Button();
            this.Mix1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dec1
            // 
            this.dec1.FormattingEnabled = true;
            this.dec1.ItemHeight = 15;
            this.dec1.Location = new System.Drawing.Point(24, 30);
            this.dec1.Name = "dec1";
            this.dec1.Size = new System.Drawing.Size(143, 244);
            this.dec1.TabIndex = 0;
            // 
            // dec2
            // 
            this.dec2.FormattingEnabled = true;
            this.dec2.ItemHeight = 15;
            this.dec2.Location = new System.Drawing.Point(226, 30);
            this.dec2.Name = "dec2";
            this.dec2.Size = new System.Drawing.Size(143, 244);
            this.dec2.TabIndex = 0;
            // 
            // SwapRight
            // 
            this.SwapRight.Location = new System.Drawing.Point(173, 81);
            this.SwapRight.Name = "SwapRight";
            this.SwapRight.Size = new System.Drawing.Size(47, 35);
            this.SwapRight.TabIndex = 1;
            this.SwapRight.Text = ">>";
            this.SwapRight.UseVisualStyleBackColor = true;
            this.SwapRight.Click += new System.EventHandler(this.SwapRight_Click);
            // 
            // SwapLeft
            // 
            this.SwapLeft.Location = new System.Drawing.Point(173, 135);
            this.SwapLeft.Name = "SwapLeft";
            this.SwapLeft.Size = new System.Drawing.Size(47, 37);
            this.SwapLeft.TabIndex = 2;
            this.SwapLeft.Text = "<<";
            this.SwapLeft.UseVisualStyleBackColor = true;
            this.SwapLeft.Click += new System.EventHandler(this.SwapLeft_Click);
            // 
            // Reset1
            // 
            this.Reset1.Location = new System.Drawing.Point(24, 296);
            this.Reset1.Name = "Reset1";
            this.Reset1.Size = new System.Drawing.Size(143, 39);
            this.Reset1.TabIndex = 3;
            this.Reset1.Text = "Przywróć zestaw 1";
            this.Reset1.UseVisualStyleBackColor = true;
            this.Reset1.Click += new System.EventHandler(this.Reset1_Click);
            // 
            // Reset2
            // 
            this.Reset2.Location = new System.Drawing.Point(226, 296);
            this.Reset2.Name = "Reset2";
            this.Reset2.Size = new System.Drawing.Size(143, 39);
            this.Reset2.TabIndex = 4;
            this.Reset2.Text = "Przywróć zestaw 2";
            this.Reset2.UseVisualStyleBackColor = true;
            this.Reset2.Click += new System.EventHandler(this.Reset2_Click);
            // 
            // Mix2
            // 
            this.Mix2.Location = new System.Drawing.Point(226, 342);
            this.Mix2.Name = "Mix2";
            this.Mix2.Size = new System.Drawing.Size(143, 38);
            this.Mix2.TabIndex = 5;
            this.Mix2.Text = "Wymieszaj zestaw 2";
            this.Mix2.UseVisualStyleBackColor = true;
            this.Mix2.Click += new System.EventHandler(this.Mix2_Click);
            // 
            // Mix1
            // 
            this.Mix1.Location = new System.Drawing.Point(24, 342);
            this.Mix1.Name = "Mix1";
            this.Mix1.Size = new System.Drawing.Size(143, 38);
            this.Mix1.TabIndex = 6;
            this.Mix1.Text = "Wymieszaj zestaw 1";
            this.Mix1.UseVisualStyleBackColor = true;
            this.Mix1.Click += new System.EventHandler(this.Mix1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mix1);
            this.Controls.Add(this.Mix2);
            this.Controls.Add(this.Reset2);
            this.Controls.Add(this.Reset1);
            this.Controls.Add(this.SwapLeft);
            this.Controls.Add(this.SwapRight);
            this.Controls.Add(this.dec2);
            this.Controls.Add(this.dec1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dec1;
        private System.Windows.Forms.ListBox dec2;
        private System.Windows.Forms.Button SwapRight;
        private System.Windows.Forms.Button SwapLeft;
        private System.Windows.Forms.Button Reset1;
        private System.Windows.Forms.Button Reset2;
        private System.Windows.Forms.Button Mix2;
        private System.Windows.Forms.Button Mix1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

