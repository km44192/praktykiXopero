using System.Resources;
using System.Runtime.Versioning;
using System.Media;
using System.Drawing;

namespace Popup_i_zakotwiczenie_WFApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kotwica = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.napis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kotwica
            // 
            this.kotwica.Location = new System.Drawing.Point(63, 29);
            this.kotwica.Name = "kotwica";
            this.kotwica.Size = new System.Drawing.Size(150, 23);
            this.kotwica.TabIndex = 0;
            this.kotwica.Text = "Kliknij aby zmienic etykiete";
            this.kotwica.UseVisualStyleBackColor = true;
            this.kotwica.Click += new System.EventHandler(this.kotwica_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wiadomosc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.wiadomosc_Click);
            this.button2.BackColor = Color.FromArgb(255, 199, 1, 1);
           // Application.DoEvents();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(600, 32);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(142, 19);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "Włącz zmianę etykiety";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 96);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // napis
            // 
            this.napis.Location = new System.Drawing.Point(2, 104);
            this.napis.Name = "napis";
            this.napis.Size = new System.Drawing.Size(788, 21);
            this.napis.TabIndex = 4;
            this.napis.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 380);
            this.Controls.Add(this.napis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kotwica);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kotwica;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label napis;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}

