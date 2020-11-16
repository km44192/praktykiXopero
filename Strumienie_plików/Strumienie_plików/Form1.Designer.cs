namespace Strumienie_plików
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
            this.openF = new System.Windows.Forms.Button();
            this.saveF = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.RichTextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFl = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openF
            // 
            this.openF.Location = new System.Drawing.Point(319, 307);
            this.openF.Name = "openF";
            this.openF.Size = new System.Drawing.Size(79, 24);
            this.openF.TabIndex = 0;
            this.openF.Text = "OpenFile";
            this.openF.UseVisualStyleBackColor = true;
            this.openF.Click += new System.EventHandler(this.openF_Click);
            // 
            // saveF
            // 
            this.saveF.Location = new System.Drawing.Point(414, 307);
            this.saveF.Name = "saveF";
            this.saveF.Size = new System.Drawing.Size(75, 23);
            this.saveF.TabIndex = 1;
            this.saveF.Text = "Zapisz";
            this.saveF.UseVisualStyleBackColor = true;
            this.saveF.Click += new System.EventHandler(this.saveF_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(13, 13);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(485, 288);
            this.text.TabIndex = 2;
            this.text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 343);
            this.Controls.Add(this.text);
            this.Controls.Add(this.saveF);
            this.Controls.Add(this.openF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Prosty edytor tekstowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openF;
        private System.Windows.Forms.Button saveF;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFl;
    }
}

