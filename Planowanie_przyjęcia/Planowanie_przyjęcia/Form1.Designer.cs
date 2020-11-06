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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.alert = new System.Windows.Forms.Label();
            this.wynik2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NapisTort = new System.Windows.Forms.TextBox();
            this.deco1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumOfPeople = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IleGosci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // deco
            // 
            this.deco.AutoSize = true;
            this.deco.Location = new System.Drawing.Point(9, 56);
            this.deco.Name = "deco";
            this.deco.Size = new System.Drawing.Size(135, 19);
            this.deco.TabIndex = 0;
            this.deco.Text = "Dekoracje fantazyjne";
            this.deco.UseVisualStyleBackColor = true;
            this.deco.CheckedChanged += new System.EventHandler(this.deco_CheckedChanged);
            // 
            // IleGosci
            // 
            this.IleGosci.Location = new System.Drawing.Point(9, 27);
            this.IleGosci.Name = "IleGosci";
            this.IleGosci.Size = new System.Drawing.Size(120, 23);
            this.IleGosci.TabIndex = 2;
            // 
            // fit
            // 
            this.fit.AutoSize = true;
            this.fit.Location = new System.Drawing.Point(9, 81);
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
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ilość osób";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Koszt";
            // 
            // kwota
            // 
            this.kwota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kwota.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kwota.Location = new System.Drawing.Point(75, 140);
            this.kwota.Name = "kwota";
            this.kwota.Size = new System.Drawing.Size(100, 23);
            this.kwota.TabIndex = 6;
            this.kwota.Click += new System.EventHandler(this.kwota_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kwota);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fit);
            this.groupBox1.Controls.Add(this.IleGosci);
            this.groupBox1.Controls.Add(this.deco);
            this.groupBox1.Location = new System.Drawing.Point(-4, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 217);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 245);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DinnerParty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.alert);
            this.tabPage2.Controls.Add(this.wynik2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.NapisTort);
            this.tabPage2.Controls.Add(this.deco1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.NumOfPeople);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BirthdayParty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Location = new System.Drawing.Point(92, 95);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(32, 15);
            this.alert.TabIndex = 9;
            this.alert.Text = "-----";
            // 
            // wynik2
            // 
            this.wynik2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wynik2.Location = new System.Drawing.Point(62, 163);
            this.wynik2.Name = "wynik2";
            this.wynik2.Size = new System.Drawing.Size(113, 27);
            this.wynik2.TabIndex = 8;
            this.wynik2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Koszt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Napis na tort";
            // 
            // NapisTort
            // 
            this.NapisTort.Location = new System.Drawing.Point(3, 113);
            this.NapisTort.Name = "NapisTort";
            this.NapisTort.Size = new System.Drawing.Size(135, 23);
            this.NapisTort.TabIndex = 4;
            this.NapisTort.TextChanged += new System.EventHandler(this.NapisTort_TextChanged);
            // 
            // deco1
            // 
            this.deco1.AutoSize = true;
            this.deco1.Location = new System.Drawing.Point(7, 51);
            this.deco1.Name = "deco1";
            this.deco1.Size = new System.Drawing.Size(135, 19);
            this.deco1.TabIndex = 2;
            this.deco1.Text = "Dekoracje fantazyjne";
            this.deco1.UseVisualStyleBackColor = true;
            this.deco1.CheckedChanged += new System.EventHandler(this.deco1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ilość osób";
            // 
            // NumOfPeople
            // 
            this.NumOfPeople.Location = new System.Drawing.Point(4, 26);
            this.NumOfPeople.Name = "NumOfPeople";
            this.NumOfPeople.Size = new System.Drawing.Size(120, 23);
            this.NumOfPeople.TabIndex = 0;
            this.NumOfPeople.ValueChanged += new System.EventHandler(this.NumOfPeople_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 252);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IleGosci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox deco;
        private System.Windows.Forms.NumericUpDown IleGosci;
        private System.Windows.Forms.CheckBox fit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kwota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumOfPeople;
        private System.Windows.Forms.CheckBox deco1;
        private System.Windows.Forms.TextBox NapisTort;
        private System.Windows.Forms.Label wynik2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label alert;
    }
}

