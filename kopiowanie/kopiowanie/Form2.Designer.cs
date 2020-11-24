using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace kopiowanie
{
    partial class Form2
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
        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundWorker1_ProgressChanged);
        }
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {   
            this.resultLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Postep = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cpfiles = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 143);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(19, 15);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "xx";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(223, 138);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 24);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Zatrzymaj";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.cancelAsyncButton_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(320, 139);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(80, 23);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Wznów";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.startAsyncButton_Click);
            // 
            // Postep
            // 
            this.Postep.Location = new System.Drawing.Point(58, 12);
            this.Postep.Name = "Postep";
            this.Postep.Size = new System.Drawing.Size(274, 23);
            this.Postep.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = false;
            this.backgroundWorker1.WorkerSupportsCancellation = false;
            // 
            // cpfiles
            // 
            this.cpfiles.Location = new System.Drawing.Point(58, 51);
            this.cpfiles.Name = "cpfiles";
            this.cpfiles.Size = new System.Drawing.Size(274, 47);
            this.cpfiles.TabIndex = 4;
            this.cpfiles.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 174);
            this.Controls.Add(this.cpfiles);
            this.Controls.Add(this.Postep);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
       
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.ProgressBar Postep;
        private RichTextBox richTextBox1;
        private RichTextBox cpfiles;
    }
}

