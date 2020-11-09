namespace Dziedziczenie_Ul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrzypiszPrace = new System.Windows.Forms.Button();
            this.numerPszczoły = new System.Windows.Forms.NumericUpDown();
            this.prace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkNextShift = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerPszczoły)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrzypiszPrace);
            this.groupBox1.Controls.Add(this.numerPszczoły);
            this.groupBox1.Controls.Add(this.prace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            // 
            // PrzypiszPrace
            // 
            this.PrzypiszPrace.Location = new System.Drawing.Point(27, 66);
            this.PrzypiszPrace.Name = "PrzypiszPrace";
            this.PrzypiszPrace.Size = new System.Drawing.Size(241, 23);
            this.PrzypiszPrace.TabIndex = 4;
            this.PrzypiszPrace.Text = "Przydziel tę pracę pszczole";
            this.PrzypiszPrace.UseVisualStyleBackColor = true;
            this.PrzypiszPrace.Click += new System.EventHandler(this.PrzypiszPrace_Click);
            // 
            // numerPszczoły
            // 
            this.numerPszczoły.Location = new System.Drawing.Point(187, 37);
            this.numerPszczoły.Name = "numerPszczoły";
            this.numerPszczoły.Size = new System.Drawing.Size(81, 23);
            this.numerPszczoły.TabIndex = 3;
            // 
            // prace
            // 
            this.prace.FormattingEnabled = true;
            this.prace.Location = new System.Drawing.Point(27, 37);
            this.prace.Name = "prace";
            this.prace.Size = new System.Drawing.Size(154, 23);
            this.prace.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zmiany";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadanie Robotnicy";
            // 
            // WorkNextShift
            // 
            this.WorkNextShift.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WorkNextShift.Location = new System.Drawing.Point(370, 48);
            this.WorkNextShift.Name = "WorkNextShift";
            this.WorkNextShift.Size = new System.Drawing.Size(93, 93);
            this.WorkNextShift.TabIndex = 1;
            this.WorkNextShift.Text = "Przepracuj następną zmianę";
            this.WorkNextShift.UseVisualStyleBackColor = true;
            this.WorkNextShift.Click += new System.EventHandler(this.WorkNextShift_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(52, 174);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(411, 227);
            this.report.TabIndex = 2;
            this.report.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 436);
            this.Controls.Add(this.report);
            this.Controls.Add(this.WorkNextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerPszczoły)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PrzypiszPrace;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox prace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WorkNextShift;
        private System.Windows.Forms.NumericUpDown numerPszczoły;
        private System.Windows.Forms.RichTextBox report;
    }
}

