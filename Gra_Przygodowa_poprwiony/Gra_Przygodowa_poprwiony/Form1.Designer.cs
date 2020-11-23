namespace Gra_Przygodowa_poprwiony
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Left1 = new System.Windows.Forms.Button();
            this.Rgiht1 = new System.Windows.Forms.Button();
            this.Top1 = new System.Windows.Forms.Button();
            this.Down1 = new System.Windows.Forms.Button();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.Down = new System.Windows.Forms.Button();
            this.Top = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isword = new System.Windows.Forms.PictureBox();
            this.ibow = new System.Windows.Forms.PictureBox();
            this.icep = new System.Windows.Forms.PictureBox();
            this.spot = new System.Windows.Forms.PictureBox();
            this.bpot = new System.Windows.Forms.PictureBox();
            this.Batt = new System.Windows.Forms.PictureBox();
            this.Ghost = new System.Windows.Forms.PictureBox();
            this.Banshee = new System.Windows.Forms.PictureBox();
            this.npot = new System.Windows.Forms.PictureBox();
            this.cep = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.rpot = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayHP = new System.Windows.Forms.Label();
            this.BatHp = new System.Windows.Forms.Label();
            this.GhoHP = new System.Windows.Forms.Label();
            this.BanHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.grp1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Batt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banshee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpot)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(98, 80);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(40, 40);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // Left1
            // 
            this.Left1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Left1.Location = new System.Drawing.Point(15, 39);
            this.Left1.Name = "Left1";
            this.Left1.Size = new System.Drawing.Size(30, 29);
            this.Left1.TabIndex = 3;
            this.Left1.Text = "←";
            this.Left1.UseVisualStyleBackColor = true;
            this.Left1.Click += new System.EventHandler(this.Left1_Click);
            // 
            // Rgiht1
            // 
            this.Rgiht1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rgiht1.Location = new System.Drawing.Point(80, 39);
            this.Rgiht1.Name = "Rgiht1";
            this.Rgiht1.Size = new System.Drawing.Size(33, 29);
            this.Rgiht1.TabIndex = 4;
            this.Rgiht1.Text = "→";
            this.Rgiht1.UseVisualStyleBackColor = true;
            this.Rgiht1.Click += new System.EventHandler(this.Right1_Click);
            // 
            // Top1
            // 
            this.Top1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Top1.Location = new System.Drawing.Point(49, 11);
            this.Top1.Name = "Top1";
            this.Top1.Size = new System.Drawing.Size(33, 26);
            this.Top1.TabIndex = 5;
            this.Top1.Text = "↑";
            this.Top1.UseVisualStyleBackColor = true;
            this.Top1.Click += new System.EventHandler(this.Top1_Click);
            // 
            // Down1
            // 
            this.Down1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Down1.Location = new System.Drawing.Point(49, 62);
            this.Down1.Name = "Down1";
            this.Down1.Size = new System.Drawing.Size(29, 28);
            this.Down1.TabIndex = 6;
            this.Down1.Text = "↓";
            this.Down1.UseVisualStyleBackColor = true;
            this.Down1.Click += new System.EventHandler(this.Down1_Click);
            // 
            // grp1
            // 
            this.grp1.BackColor = System.Drawing.Color.Transparent;
            this.grp1.Controls.Add(this.Down1);
            this.grp1.Controls.Add(this.Top1);
            this.grp1.Controls.Add(this.Rgiht1);
            this.grp1.Controls.Add(this.Left1);
            this.grp1.Location = new System.Drawing.Point(426, 434);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(123, 90);
            this.grp1.TabIndex = 7;
            this.grp1.TabStop = false;
            this.grp1.Text = "Ruch";
            // 
            // Down
            // 
            this.Down.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Down.Location = new System.Drawing.Point(49, 62);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(29, 28);
            this.Down.TabIndex = 6;
            this.Down.Text = "↓";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Top
            // 
            this.Top.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Top.Location = new System.Drawing.Point(49, 11);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(33, 26);
            this.Top.TabIndex = 5;
            this.Top.Text = "↑";
            this.Top.UseVisualStyleBackColor = true;
            this.Top.Click += new System.EventHandler(this.Top_Click);
            // 
            // Right
            // 
            this.Right.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Right.Location = new System.Drawing.Point(80, 39);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(33, 29);
            this.Right.TabIndex = 4;
            this.Right.Text = "→";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Left.Location = new System.Drawing.Point(15, 39);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(30, 29);
            this.Left.TabIndex = 3;
            this.Left.Text = "←";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Down);
            this.groupBox1.Controls.Add(this.Top);
            this.groupBox1.Controls.Add(this.Right);
            this.groupBox1.Controls.Add(this.Left);
            this.groupBox1.Location = new System.Drawing.Point(577, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atak";
            // 
            // isword
            // 
            this.isword.BackColor = System.Drawing.Color.Transparent;
            this.isword.Image = ((System.Drawing.Image)(resources.GetObject("isword.Image")));
            this.isword.Location = new System.Drawing.Point(98, 450);
            this.isword.Name = "isword";
            this.isword.Size = new System.Drawing.Size(60, 60);
            this.isword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.isword.TabIndex = 8;
            this.isword.TabStop = false;
            this.isword.Click += new System.EventHandler(this.isword_Click);
            // 
            // ibow
            // 
            this.ibow.BackColor = System.Drawing.Color.Transparent;
            this.ibow.Image = ((System.Drawing.Image)(resources.GetObject("ibow.Image")));
            this.ibow.Location = new System.Drawing.Point(164, 450);
            this.ibow.Name = "ibow";
            this.ibow.Size = new System.Drawing.Size(60, 60);
            this.ibow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibow.TabIndex = 8;
            this.ibow.TabStop = false;
            // 
            // icep
            // 
            this.icep.BackColor = System.Drawing.Color.Transparent;
            this.icep.Image = ((System.Drawing.Image)(resources.GetObject("icep.Image")));
            this.icep.Location = new System.Drawing.Point(230, 450);
            this.icep.Name = "icep";
            this.icep.Size = new System.Drawing.Size(60, 60);
            this.icep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icep.TabIndex = 8;
            this.icep.TabStop = false;
            // 
            // spot
            // 
            this.spot.BackColor = System.Drawing.Color.Transparent;
            this.spot.Image = ((System.Drawing.Image)(resources.GetObject("spot.Image")));
            this.spot.Location = new System.Drawing.Point(296, 450);
            this.spot.Name = "spot";
            this.spot.Size = new System.Drawing.Size(60, 60);
            this.spot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spot.TabIndex = 8;
            this.spot.TabStop = false;
            // 
            // bpot
            // 
            this.bpot.BackColor = System.Drawing.Color.Transparent;
            this.bpot.Image = ((System.Drawing.Image)(resources.GetObject("bpot.Image")));
            this.bpot.Location = new System.Drawing.Point(360, 450);
            this.bpot.Name = "bpot";
            this.bpot.Size = new System.Drawing.Size(60, 60);
            this.bpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bpot.TabIndex = 8;
            this.bpot.TabStop = false;
            // 
            // Batt
            // 
            this.Batt.BackColor = System.Drawing.Color.Transparent;
            this.Batt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Batt.Image = ((System.Drawing.Image)(resources.GetObject("Batt.Image")));
            this.Batt.Location = new System.Drawing.Point(144, 79);
            this.Batt.Name = "Batt";
            this.Batt.Size = new System.Drawing.Size(40, 40);
            this.Batt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Batt.TabIndex = 2;
            this.Batt.TabStop = false;
            // 
            // Ghost
            // 
            this.Ghost.BackColor = System.Drawing.Color.Transparent;
            this.Ghost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ghost.Image = ((System.Drawing.Image)(resources.GetObject("Ghost.Image")));
            this.Ghost.Location = new System.Drawing.Point(190, 79);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(40, 40);
            this.Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ghost.TabIndex = 2;
            this.Ghost.TabStop = false;
            // 
            // Banshee
            // 
            this.Banshee.BackColor = System.Drawing.Color.Transparent;
            this.Banshee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Banshee.Image = ((System.Drawing.Image)(resources.GetObject("Banshee.Image")));
            this.Banshee.Location = new System.Drawing.Point(236, 79);
            this.Banshee.Name = "Banshee";
            this.Banshee.Size = new System.Drawing.Size(40, 40);
            this.Banshee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banshee.TabIndex = 2;
            this.Banshee.TabStop = false;
            // 
            // npot
            // 
            this.npot.BackColor = System.Drawing.Color.Transparent;
            this.npot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.npot.Image = ((System.Drawing.Image)(resources.GetObject("npot.Image")));
            this.npot.Location = new System.Drawing.Point(282, 79);
            this.npot.Name = "npot";
            this.npot.Size = new System.Drawing.Size(40, 40);
            this.npot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.npot.TabIndex = 2;
            this.npot.TabStop = false;
            // 
            // cep
            // 
            this.cep.BackColor = System.Drawing.Color.Transparent;
            this.cep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cep.Image = ((System.Drawing.Image)(resources.GetObject("cep.Image")));
            this.cep.Location = new System.Drawing.Point(466, 79);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(40, 40);
            this.cep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cep.TabIndex = 2;
            this.cep.TabStop = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(420, 79);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(40, 40);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 2;
            this.bow.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(374, 79);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(40, 40);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 2;
            this.sword.TabStop = false;
            // 
            // rpot
            // 
            this.rpot.BackColor = System.Drawing.Color.Transparent;
            this.rpot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rpot.Image = ((System.Drawing.Image)(resources.GetObject("rpot.Image")));
            this.rpot.Location = new System.Drawing.Point(328, 79);
            this.rpot.Name = "rpot";
            this.rpot.Size = new System.Drawing.Size(40, 40);
            this.rpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rpot.TabIndex = 2;
            this.rpot.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(438, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gracz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(438, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nietoperz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(438, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Duch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(438, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Upiór";
            // 
            // PlayHP
            // 
            this.PlayHP.AutoSize = true;
            this.PlayHP.BackColor = System.Drawing.Color.Transparent;
            this.PlayHP.Location = new System.Drawing.Point(506, 346);
            this.PlayHP.Name = "PlayHP";
            this.PlayHP.Size = new System.Drawing.Size(13, 15);
            this.PlayHP.TabIndex = 13;
            this.PlayHP.Text = "0";
            // 
            // BatHp
            // 
            this.BatHp.AutoSize = true;
            this.BatHp.BackColor = System.Drawing.Color.Transparent;
            this.BatHp.Location = new System.Drawing.Point(506, 365);
            this.BatHp.Name = "BatHp";
            this.BatHp.Size = new System.Drawing.Size(13, 15);
            this.BatHp.TabIndex = 14;
            this.BatHp.Text = "0";
            // 
            // GhoHP
            // 
            this.GhoHP.AutoSize = true;
            this.GhoHP.BackColor = System.Drawing.Color.Transparent;
            this.GhoHP.Location = new System.Drawing.Point(506, 384);
            this.GhoHP.Name = "GhoHP";
            this.GhoHP.Size = new System.Drawing.Size(13, 15);
            this.GhoHP.TabIndex = 15;
            this.GhoHP.Text = "0";
            // 
            // BanHP
            // 
            this.BanHP.AutoSize = true;
            this.BanHP.BackColor = System.Drawing.Color.Transparent;
            this.BanHP.Location = new System.Drawing.Point(506, 403);
            this.BanHP.Name = "BanHP";
            this.BanHP.Size = new System.Drawing.Size(13, 15);
            this.BanHP.TabIndex = 16;
            this.BanHP.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BanHP);
            this.Controls.Add(this.GhoHP);
            this.Controls.Add(this.BatHp);
            this.Controls.Add(this.PlayHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpot);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.npot);
            this.Controls.Add(this.Banshee);
            this.Controls.Add(this.Ghost);
            this.Controls.Add(this.Batt);
            this.Controls.Add(this.bpot);
            this.Controls.Add(this.spot);
            this.Controls.Add(this.icep);
            this.Controls.Add(this.ibow);
            this.Controls.Add(this.isword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.grp1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Batt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banshee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Left1;
        private System.Windows.Forms.Button Rgiht1;
        private System.Windows.Forms.Button Top1;
        private System.Windows.Forms.Button Down1;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Top;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox isword;
        private System.Windows.Forms.PictureBox ibow;
        private System.Windows.Forms.PictureBox icep;
        private System.Windows.Forms.PictureBox spot;
        private System.Windows.Forms.PictureBox bpot;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.PictureBox Ghost;
        private System.Windows.Forms.PictureBox Banshee;
        private System.Windows.Forms.PictureBox npot;
        private System.Windows.Forms.PictureBox cep;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox rpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlayHP;
        private System.Windows.Forms.Label BatHp;
        private System.Windows.Forms.Label GhoHP;
        private System.Windows.Forms.Label BanHP;
   
        private System.Windows.Forms.PictureBox Batt;
    }
}

