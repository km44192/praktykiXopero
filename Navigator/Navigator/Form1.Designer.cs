namespace Navigator
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
            this.celPodróży = new System.Windows.Forms.TextBox();
            this.Avoid = new System.Windows.Forms.TextBox();
            this.kalkuluj = new System.Windows.Forms.Button();
            this.dystans = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // celPodróży
            // 
            this.celPodróży.Location = new System.Drawing.Point(128, 29);
            this.celPodróży.Name = "celPodróży";
            this.celPodróży.Size = new System.Drawing.Size(100, 23);
            this.celPodróży.TabIndex = 0;
            // 
            // Avoid
            // 
            this.Avoid.Location = new System.Drawing.Point(128, 85);
            this.Avoid.Name = "Avoid";
            this.Avoid.Size = new System.Drawing.Size(100, 23);
            this.Avoid.TabIndex = 1;
            // 
            // kalkuluj
            // 
            this.kalkuluj.Location = new System.Drawing.Point(143, 173);
            this.kalkuluj.Name = "kalkuluj";
            this.kalkuluj.Size = new System.Drawing.Size(75, 23);
            this.kalkuluj.TabIndex = 2;
            this.kalkuluj.Text = "Kieruj";
            this.kalkuluj.UseVisualStyleBackColor = true;
            this.kalkuluj.Click += new System.EventHandler(this.kalkuluj_Click);
            // 
            // dystans
            // 
            this.dystans.Location = new System.Drawing.Point(55, 136);
            this.dystans.Name = "dystans";
            this.dystans.Size = new System.Drawing.Size(253, 21);
            this.dystans.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj cel podróży";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jaka trase ominąc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 234);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dystans);
            this.Controls.Add(this.kalkuluj);
            this.Controls.Add(this.Avoid);
            this.Controls.Add(this.celPodróży);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox celPodróży;
        private System.Windows.Forms.TextBox Avoid;
        private System.Windows.Forms.Button kalkuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dystans;
    }
}

