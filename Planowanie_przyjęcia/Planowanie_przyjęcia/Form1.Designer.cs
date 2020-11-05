namespace Planowanie_przyjęcia
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
            this.deco = new System.Windows.Forms.CheckBox();
            this.IleGosci = new System.Windows.Forms.NumericUpDown();
            this.fit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kwota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IleGosci)).BeginInit();
            this.SuspendLayout();
            // 
            // deco
            // 
            this.deco.AutoSize = true;
            this.deco.Location = new System.Drawing.Point(12, 60);
            this.deco.Name = "deco";
            this.deco.Size = new System.Drawing.Size(135, 19);
            this.deco.TabIndex = 0;
            this.deco.Text = "Dekoracje fantazyjne";
            this.deco.UseVisualStyleBackColor = true;
            this.deco.CheckedChanged += new System.EventHandler(this.deco_CheckedChanged);
            // 
            // IleGosci
            // 
            this.IleGosci.Location = new System.Drawing.Point(12, 31);
            this.IleGosci.Name = "IleGosci";
            this.IleGosci.Size = new System.Drawing.Size(120, 23);
            this.IleGosci.TabIndex = 2;
            // 
            // fit
            // 
            this.fit.AutoSize = true;
            this.fit.Location = new System.Drawing.Point(12, 85);
            this.fit.Name = "fit";
            this.fit.Size = new System.Drawing.Size(100, 19);
            this.fit.TabIndex = 3;
            this.fit.Text = "Opcja Zdrowa";
            this.fit.UseVisualStyleBackColor = true;
            this.fit.CheckedChanged += new System.EventHandler(this.fit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ilość osób";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Koszt";
            // 
            // kwota
            // 
            this.kwota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kwota.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kwota.Location = new System.Drawing.Point(78, 144);
            this.kwota.Name = "kwota";
            this.kwota.Size = new System.Drawing.Size(100, 23);
            this.kwota.TabIndex = 6;
            this.kwota.Click += new System.EventHandler(this.kwota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 183);
            this.Controls.Add(this.kwota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fit);
            this.Controls.Add(this.IleGosci);
            this.Controls.Add(this.deco);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IleGosci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox deco;
        private System.Windows.Forms.NumericUpDown IleGosci;
        private System.Windows.Forms.CheckBox fit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kwota;
    }
}

