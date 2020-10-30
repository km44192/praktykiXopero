namespace Banking
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
            this.opisPawel = new System.Windows.Forms.Label();
            this.opisRoman = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.opRoman = new System.Windows.Forms.CheckBox();
            this.OpPawel = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opisPawel
            // 
            this.opisPawel.AutoSize = true;
            this.opisPawel.Location = new System.Drawing.Point(300, 20);
            this.opisPawel.Name = "opisPawel";
            this.opisPawel.Size = new System.Drawing.Size(0, 15);
            this.opisPawel.TabIndex = 0;
            // 
            // opisRoman
            // 
            this.opisRoman.AutoSize = true;
            this.opisRoman.Location = new System.Drawing.Point(300, 40);
            this.opisRoman.Name = "opisRoman";
            this.opisRoman.Size = new System.Drawing.Size(0, 15);
            this.opisRoman.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Daj od banku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Przekaż między";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // opRoman
            // 
            this.opRoman.AutoSize = true;
            this.opRoman.Location = new System.Drawing.Point(521, 183);
            this.opRoman.Name = "opRoman";
            this.opRoman.Size = new System.Drawing.Size(64, 19);
            this.opRoman.TabIndex = 4;
            this.opRoman.Text = "Roman";
            this.opRoman.UseVisualStyleBackColor = true;
            // 
            // OpPawel
            // 
            this.OpPawel.AutoSize = true;
            this.OpPawel.Location = new System.Drawing.Point(243, 183);
            this.OpPawel.Name = "OpPawel";
            this.OpPawel.Size = new System.Drawing.Size(57, 19);
            this.OpPawel.TabIndex = 5;
            this.OpPawel.Text = "Paweł";
            this.OpPawel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "kwota";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(367, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Zabierz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OpPawel);
            this.Controls.Add(this.opRoman);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opisRoman);
            this.Controls.Add(this.opisPawel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label opisPawel;
        private System.Windows.Forms.Label opisRoman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox opRoman;
        private System.Windows.Forms.CheckBox OpPawel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

