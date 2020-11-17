namespace Wymowki
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
            this.choose = new System.Windows.Forms.Button();
            this.saveFi = new System.Windows.Forms.Button();
            this.openfi = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(27, 184);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 23);
            this.choose.TabIndex = 0;
            this.choose.Text = "Folder";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // saveFi
            // 
            this.saveFi.Location = new System.Drawing.Point(108, 184);
            this.saveFi.Name = "saveFi";
            this.saveFi.Size = new System.Drawing.Size(75, 23);
            this.saveFi.TabIndex = 1;
            this.saveFi.Text = "Zapisz";
            this.saveFi.UseVisualStyleBackColor = true;
            this.saveFi.Click += new System.EventHandler(this.saveFi_Click);
            // 
            // openfi
            // 
            this.openfi.Location = new System.Drawing.Point(189, 184);
            this.openfi.Name = "openfi";
            this.openfi.Size = new System.Drawing.Size(75, 23);
            this.openfi.TabIndex = 2;
            this.openfi.Text = "Otwórz";
            this.openfi.UseVisualStyleBackColor = true;
            this.openfi.Click += new System.EventHandler(this.openfi_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Losowa wymówka";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wymówka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wyniki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ostatnio użyte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data pliku";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.description_textChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 23);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.Result_textChanged);
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(96, 77);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(275, 23);
            this.lastUsed.TabIndex = 10;
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 113);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(275, 23);
            this.textBox3.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 211);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.openfi);
            this.Controls.Add(this.saveFi);
            this.Controls.Add(this.choose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button saveFi;
        private System.Windows.Forms.Button openfi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

