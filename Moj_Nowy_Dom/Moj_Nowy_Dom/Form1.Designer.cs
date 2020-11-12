namespace Moj_Nowy_Dom
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
            this.description = new System.Windows.Forms.RichTextBox();
            this.GoHere = new System.Windows.Forms.Button();
            this.Go_thorugh = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.Take_Cover = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(13, 22);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(479, 247);
            this.description.TabIndex = 0;
            this.description.Text = "";
            // 
            // GoHere
            // 
            this.GoHere.Location = new System.Drawing.Point(13, 288);
            this.GoHere.Name = "GoHere";
            this.GoHere.Size = new System.Drawing.Size(144, 57);
            this.GoHere.TabIndex = 1;
            this.GoHere.Text = "Idź Tutaj....";
            this.GoHere.UseVisualStyleBackColor = true;
            this.GoHere.Click += new System.EventHandler(this.GoHere_Click);
            // 
            // Go_thorugh
            // 
            this.Go_thorugh.Location = new System.Drawing.Point(13, 385);
            this.Go_thorugh.Name = "Go_thorugh";
            this.Go_thorugh.Size = new System.Drawing.Size(479, 33);
            this.Go_thorugh.TabIndex = 2;
            this.Go_thorugh.Text = "Przejdź przez drzwi";
            this.Go_thorugh.UseVisualStyleBackColor = true;
            this.Go_thorugh.Click += new System.EventHandler(this.Go_thorugh_Click);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(13, 424);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(479, 32);
            this.Check.TabIndex = 3;
            this.Check.Text = "sprawdź";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Take_Cover
            // 
            this.Take_Cover.Location = new System.Drawing.Point(13, 476);
            this.Take_Cover.Name = "Take_Cover";
            this.Take_Cover.Size = new System.Drawing.Size(479, 32);
            this.Take_Cover.TabIndex = 4;
            this.Take_Cover.Text = "Kryj się!";
            this.Take_Cover.UseVisualStyleBackColor = true;
            this.Take_Cover.Click += new System.EventHandler(this.Take_Cover_Click);
            // 
            // exits
            // 
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(193, 300);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(299, 23);
            this.exits.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 535);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.Take_Cover);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Go_thorugh);
            this.Controls.Add(this.GoHere);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button GoHere;
        private System.Windows.Forms.Button Go_thorugh;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Take_Cover;
        private System.Windows.Forms.ComboBox exits;
    }
}

