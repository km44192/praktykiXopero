namespace LumberJack
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
            this.textImie = new System.Windows.Forms.TextBox();
            this.AddLumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LamberInfo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Op4 = new System.Windows.Forms.RadioButton();
            this.Op3 = new System.Windows.Forms.RadioButton();
            this.Op2 = new System.Windows.Forms.RadioButton();
            this.Op1 = new System.Windows.Forms.RadioButton();
            this.Ile = new System.Windows.Forms.NumericUpDown();
            this.text = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię drwala";
            // 
            // textImie
            // 
            this.textImie.Location = new System.Drawing.Point(140, 25);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(180, 23);
            this.textImie.TabIndex = 1;
            // 
            // AddLumber
            // 
            this.AddLumber.Location = new System.Drawing.Point(24, 64);
            this.AddLumber.Name = "AddLumber";
            this.AddLumber.Size = new System.Drawing.Size(272, 25);
            this.AddLumber.TabIndex = 2;
            this.AddLumber.Text = "Dodaj drwala";
            this.AddLumber.UseVisualStyleBackColor = true;
            this.AddLumber.Click += new System.EventHandler(this.AddLumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolejka na śniadanie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LamberInfo);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Op4);
            this.groupBox1.Controls.Add(this.Op3);
            this.groupBox1.Controls.Add(this.Op2);
            this.groupBox1.Controls.Add(this.Op1);
            this.groupBox1.Controls.Add(this.Ile);
            this.groupBox1.Location = new System.Drawing.Point(181, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 340);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nakarm drwala";
            // 
            // LamberInfo
            // 
            this.LamberInfo.Location = new System.Drawing.Point(7, 187);
            this.LamberInfo.Multiline = true;
            this.LamberInfo.Name = "LamberInfo";
            this.LamberInfo.ReadOnly = true;
            this.LamberInfo.Size = new System.Drawing.Size(167, 63);
            this.LamberInfo.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Następny drwall";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(7, 153);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(168, 27);
            this.Add.TabIndex = 5;
            this.Add.Text = "Dodaj nalesniki";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Op4
            // 
            this.Op4.AutoSize = true;
            this.Op4.Location = new System.Drawing.Point(7, 128);
            this.Op4.Name = "Op4";
            this.Op4.Size = new System.Drawing.Size(94, 19);
            this.Op4.TabIndex = 4;
            this.Op4.TabStop = true;
            this.Op4.Text = "Bananowego";
            this.Op4.UseVisualStyleBackColor = true;
            // 
            // Op3
            // 
            this.Op3.AutoSize = true;
            this.Op3.Location = new System.Drawing.Point(7, 102);
            this.Op3.Name = "Op3";
            this.Op3.Size = new System.Drawing.Size(86, 19);
            this.Op3.TabIndex = 3;
            this.Op3.TabStop = true;
            this.Op3.Text = "Rumianego";
            this.Op3.UseVisualStyleBackColor = true;
            // 
            // Op2
            // 
            this.Op2.AutoSize = true;
            this.Op2.Location = new System.Drawing.Point(6, 76);
            this.Op2.Name = "Op2";
            this.Op2.Size = new System.Drawing.Size(87, 19);
            this.Op2.TabIndex = 2;
            this.Op2.TabStop = true;
            this.Op2.Text = "Wilgotnego";
            this.Op2.UseVisualStyleBackColor = true;
            // 
            // Op1
            // 
            this.Op1.AutoSize = true;
            this.Op1.Location = new System.Drawing.Point(6, 51);
            this.Op1.Name = "Op1";
            this.Op1.Size = new System.Drawing.Size(87, 19);
            this.Op1.TabIndex = 1;
            this.Op1.TabStop = true;
            this.Op1.Text = "Chrupkiego";
            this.Op1.UseVisualStyleBackColor = true;
            // 
            // Ile
            // 
            this.Ile.Location = new System.Drawing.Point(6, 22);
            this.Ile.Name = "Ile";
            this.Ile.Size = new System.Drawing.Size(66, 23);
            this.Ile.TabIndex = 0;
            // 
            // text
            // 
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Location = new System.Drawing.Point(13, 129);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(162, 330);
            this.text.TabIndex = 5;
            this.text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 485);
            this.Controls.Add(this.text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddLumber);
            this.Controls.Add(this.textImie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.Button AddLumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LamberInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RadioButton Op4;
        private System.Windows.Forms.RadioButton Op3;
        private System.Windows.Forms.RadioButton Op2;
        private System.Windows.Forms.RadioButton Op1;
        private System.Windows.Forms.NumericUpDown Ile;
        private System.Windows.Forms.RichTextBox text;
    }
}

