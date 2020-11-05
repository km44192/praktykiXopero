namespace zakład_buchmakerski
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ryba1 = new System.Windows.Forms.PictureBox();
            this.ryba2 = new System.Windows.Forms.PictureBox();
            this.ryba3 = new System.Windows.Forms.PictureBox();
            this.ryba4 = new System.Windows.Forms.PictureBox();
            this.setGuyBet1 = new System.Windows.Forms.RadioButton();
            this.setGuyBet2 = new System.Windows.Forms.RadioButton();
            this.setGuyBet3 = new System.Windows.Forms.RadioButton();
            this.minbet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.who1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ammountof = new System.Windows.Forms.NumericUpDown();
            this.bet = new System.Windows.Forms.Button();
            this.infoGuy3 = new System.Windows.Forms.Label();
            this.infoGuy2 = new System.Windows.Forms.Label();
            this.infoGuy1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bettingGuyName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryba3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryba4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ammountof)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(488, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 80);
            this.button4.TabIndex = 6;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\dak10\\Documents\\Visual Studio 2019\\stworzone_programy\\zakład_buchmakersk" +
    "i\\zakład_buchmakerski\\tor.png";
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ryba1
            // 
            this.ryba1.BackColor = System.Drawing.Color.White;
            this.ryba1.ImageLocation = "C:\\Users\\dak10\\Documents\\Visual Studio 2019\\stworzone_programy\\zakład_buchmakersk" +
    "i\\zakład_buchmakerski\\rybka.png";
            this.ryba1.Location = new System.Drawing.Point(0, 12);
            this.ryba1.Name = "ryba1";
            this.ryba1.Size = new System.Drawing.Size(148, 58);
            this.ryba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ryba1.TabIndex = 8;
            this.ryba1.TabStop = false;
            // 
            // ryba2
            // 
            this.ryba2.BackColor = System.Drawing.Color.White;
            this.ryba2.ImageLocation = "C:\\Users\\dak10\\Documents\\Visual Studio 2019\\stworzone_programy\\zakład_buchmakersk" +
    "i\\zakład_buchmakerski\\rybka.png";
            this.ryba2.Location = new System.Drawing.Point(0, 90);
            this.ryba2.Name = "ryba2";
            this.ryba2.Size = new System.Drawing.Size(148, 58);
            this.ryba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ryba2.TabIndex = 8;
            this.ryba2.TabStop = false;
            // 
            // ryba3
            // 
            this.ryba3.BackColor = System.Drawing.Color.White;
            this.ryba3.ImageLocation = "C:\\Users\\dak10\\Documents\\Visual Studio 2019\\stworzone_programy\\zakład_buchmakersk" +
    "i\\zakład_buchmakerski\\rybka.png";
            this.ryba3.Location = new System.Drawing.Point(0, 168);
            this.ryba3.Name = "ryba3";
            this.ryba3.Size = new System.Drawing.Size(148, 58);
            this.ryba3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ryba3.TabIndex = 8;
            this.ryba3.TabStop = false;
            // 
            // ryba4
            // 
            this.ryba4.BackColor = System.Drawing.Color.White;
            this.ryba4.ImageLocation = "C:\\Users\\dak10\\Documents\\Visual Studio 2019\\stworzone_programy\\zakład_buchmakersk" +
    "i\\zakład_buchmakerski\\rybka.png";
            this.ryba4.Location = new System.Drawing.Point(0, 243);
            this.ryba4.Name = "ryba4";
            this.ryba4.Size = new System.Drawing.Size(148, 58);
            this.ryba4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ryba4.TabIndex = 8;
            this.ryba4.TabStop = false;
            // 
            // setGuyBet1
            // 
            this.setGuyBet1.AutoSize = true;
            this.setGuyBet1.BackColor = System.Drawing.Color.Transparent;
            this.setGuyBet1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.setGuyBet1.Location = new System.Drawing.Point(18, 34);
            this.setGuyBet1.Name = "setGuyBet1";
            this.setGuyBet1.Size = new System.Drawing.Size(89, 19);
            this.setGuyBet1.TabIndex = 9;
            this.setGuyBet1.TabStop = true;
            this.setGuyBet1.Text = "bettingguy1";
            this.setGuyBet1.UseVisualStyleBackColor = false;
            this.setGuyBet1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // setGuyBet2
            // 
            this.setGuyBet2.AutoSize = true;
            this.setGuyBet2.BackColor = System.Drawing.Color.Transparent;
            this.setGuyBet2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.setGuyBet2.Location = new System.Drawing.Point(18, 59);
            this.setGuyBet2.Name = "setGuyBet2";
            this.setGuyBet2.Size = new System.Drawing.Size(89, 19);
            this.setGuyBet2.TabIndex = 10;
            this.setGuyBet2.TabStop = true;
            this.setGuyBet2.Text = "bettingguy2";
            this.setGuyBet2.UseVisualStyleBackColor = false;
            this.setGuyBet2.CheckedChanged += new System.EventHandler(this.setGuyBet2_CheckedChanged);
            // 
            // setGuyBet3
            // 
            this.setGuyBet3.AutoSize = true;
            this.setGuyBet3.BackColor = System.Drawing.Color.Transparent;
            this.setGuyBet3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.setGuyBet3.Location = new System.Drawing.Point(18, 84);
            this.setGuyBet3.Name = "setGuyBet3";
            this.setGuyBet3.Size = new System.Drawing.Size(89, 19);
            this.setGuyBet3.TabIndex = 11;
            this.setGuyBet3.TabStop = true;
            this.setGuyBet3.Text = "bettingguy3";
            this.setGuyBet3.UseVisualStyleBackColor = false;
            this.setGuyBet3.CheckedChanged += new System.EventHandler(this.setGuyBet3_CheckedChanged);
            // 
            // minbet
            // 
            this.minbet.AutoSize = true;
            this.minbet.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.minbet.ForeColor = System.Drawing.SystemColors.Desktop;
            this.minbet.Location = new System.Drawing.Point(18, 13);
            this.minbet.Name = "minbet";
            this.minbet.Size = new System.Drawing.Size(128, 19);
            this.minbet.TabIndex = 13;
            this.minbet.Text = "Minimalny bet 5zł";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.who1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ammountof);
            this.panel1.Controls.Add(this.bet);
            this.panel1.Controls.Add(this.infoGuy3);
            this.panel1.Controls.Add(this.infoGuy2);
            this.panel1.Controls.Add(this.infoGuy1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bettingGuyName);
            this.panel1.Controls.Add(this.minbet);
            this.panel1.Controls.Add(this.setGuyBet1);
            this.panel1.Controls.Add(this.setGuyBet2);
            this.panel1.Controls.Add(this.setGuyBet3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(14, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 187);
            this.panel1.TabIndex = 14;
            // 
            // who1
            // 
            this.who1.Location = new System.Drawing.Point(338, 149);
            this.who1.Name = "who1";
            this.who1.Size = new System.Drawing.Size(100, 23);
            this.who1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(283, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "zł na";
            // 
            // ammountof
            // 
            this.ammountof.Location = new System.Drawing.Point(215, 149);
            this.ammountof.Name = "ammountof";
            this.ammountof.Size = new System.Drawing.Size(62, 23);
            this.ammountof.TabIndex = 20;
            // 
            // bet
            // 
            this.bet.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bet.Location = new System.Drawing.Point(132, 150);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(64, 23);
            this.bet.TabIndex = 19;
            this.bet.Text = "stawia";
            this.bet.UseVisualStyleBackColor = true;
            this.bet.Click += new System.EventHandler(this.bet_Click);
            // 
            // infoGuy3
            // 
            this.infoGuy3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoGuy3.ForeColor = System.Drawing.Color.Black;
            this.infoGuy3.Location = new System.Drawing.Point(238, 105);
            this.infoGuy3.Name = "infoGuy3";
            this.infoGuy3.Size = new System.Drawing.Size(200, 23);
            this.infoGuy3.TabIndex = 18;
            this.infoGuy3.Text = "infoguy3";
            // 
            // infoGuy2
            // 
            this.infoGuy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoGuy2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.infoGuy2.Location = new System.Drawing.Point(238, 70);
            this.infoGuy2.Name = "infoGuy2";
            this.infoGuy2.Size = new System.Drawing.Size(200, 23);
            this.infoGuy2.TabIndex = 17;
            this.infoGuy2.Text = "infoguy2";
            // 
            // infoGuy1
            // 
            this.infoGuy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoGuy1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.infoGuy1.Location = new System.Drawing.Point(238, 35);
            this.infoGuy1.Name = "infoGuy1";
            this.infoGuy1.Size = new System.Drawing.Size(200, 23);
            this.infoGuy1.TabIndex = 16;
            this.infoGuy1.Text = "infoguy1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(238, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Zakłady";
            // 
            // bettingGuyName
            // 
            this.bettingGuyName.AutoSize = true;
            this.bettingGuyName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bettingGuyName.Location = new System.Drawing.Point(18, 154);
            this.bettingGuyName.Name = "bettingGuyName";
            this.bettingGuyName.Size = new System.Drawing.Size(37, 15);
            this.bettingGuyName.TabIndex = 14;
            this.bettingGuyName.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(33, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dom Buchmakerski";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ryba4);
            this.Controls.Add(this.ryba3);
            this.Controls.Add(this.ryba2);
            this.Controls.Add(this.ryba1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryba3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryba4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ammountof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ryba1;
        private System.Windows.Forms.PictureBox ryba2;
        private System.Windows.Forms.PictureBox ryba3;
        private System.Windows.Forms.PictureBox ryba4;
        private System.Windows.Forms.RadioButton setGuyBet1;
        private System.Windows.Forms.RadioButton setGuyBet2;
        private System.Windows.Forms.RadioButton setGuyBet3;
        private System.Windows.Forms.Label minbet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infoGuy3;
        private System.Windows.Forms.Label infoGuy2;
        private System.Windows.Forms.Label infoGuy1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bettingGuyName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ammountof;
        private System.Windows.Forms.Button bet;
        private System.Windows.Forms.TextBox who1;
    }
}

