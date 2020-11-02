namespace Rachunki_za_paliwo
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
            this.pole1 = new System.Windows.Forms.NumericUpDown();
            this.pole2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kwota = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.distance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole2)).BeginInit();
            this.SuspendLayout();
            // 
            // pole1
            // 
            this.pole1.Location = new System.Drawing.Point(176, 25);
            this.pole1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.pole1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pole1.Name = "pole1";
            this.pole1.Size = new System.Drawing.Size(120, 23);
            this.pole1.TabIndex = 0;
            this.pole1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pole2
            // 
            this.pole2.Location = new System.Drawing.Point(176, 91);
            this.pole2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.pole2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(120, 23);
            this.pole2.TabIndex = 1;
            this.pole2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Przebieg początkowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Przebieg końcowy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kwota do zwrotu:";
            // 
            // kwota
            // 
            this.kwota.AutoSize = true;
            this.kwota.Location = new System.Drawing.Point(179, 155);
            this.kwota.Name = "kwota";
            this.kwota.Size = new System.Drawing.Size(38, 15);
            this.kwota.TabIndex = 5;
            this.kwota.Text = "label4";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(152, 185);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Oblicz";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.licz);
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(233, 185);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(106, 23);
            this.distance.TabIndex = 7;
            this.distance.Text = "Pokaż dystans";
            this.distance.UseVisualStyleBackColor = true;
            this.distance.Click += new System.EventHandler(this.dist);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 230);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.kwota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.pole1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pole1;
        private System.Windows.Forms.NumericUpDown pole2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kwota;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button distance;
    }
}

