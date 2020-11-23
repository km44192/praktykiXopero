using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gra_Przygodowa_poprwiony
{

    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        Point x = new Point(0, 0);
        bool pick = false;
        int k = 0;
        int b = 1;
        int g = 1;
     
        public Form1()
        {
            InitializeComponent();
            game = new Game(new Rectangle(78, 57,580, 240));
            game.NewLevel(random);
            
            icep.Visible = false;
            isword.Visible = false;
            ibow.Visible = false;
            spot.Visible = false;
            bpot.Visible = false;
            Batt.Visible = false;
            Ghost.Visible = false;
            Banshee.Visible = false;
            npot.Visible = false;
            rpot.Visible = false;
            sword.Visible = false;
            bow.Visible = false;
            cep.Visible = false;

            foreach (Enemy enemy in game.Enemies)
            {

                if (enemy is Bat)
                        BatHp.Text = enemy.HitPoints.ToString();
                else if (enemy is Ghost)
                        GhoHP.Text = enemy.HitPoints.ToString();
                else if (enemy is Ghul)
                    BanHP.Text = enemy.HitPoints.ToString();
                   
                
            }

            if (game.WeaponInRoom.Name == "Miecz")
                sword.Visible = true;
            else if (game.WeaponInRoom.Name == "Łuk")
                bow.Visible = true;
            UpdateCharacters();
            PositionUpdate();


        }
      

        private void UpdateCharacters()

        {


            PlayHP.Text = game.PlayerHitPoints.ToString();

            Player.Location = game.PlayerLocation;
            CheckPlayerinventory();

        }
        private void CheckPlayerinventory()
        {

            

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponControl = sword; break;
            }
         
            if (!game.WeaponInRoom.PickedUp)
           {
                pick = game.WeaponInRoom.Nearby(game.PlayerLocation, 20);
                if (pick)
                {
                    game.WeaponInRoom.PickUpWeapon();
                    game.Equip(game.WeaponInRoom.Name);
                }
                   
           }
            
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                
                weaponControl.Visible = false;
                isword.Visible = true;
                isword.BorderStyle = BorderStyle.FixedSingle;
               
            }
            else
                weaponControl.Visible = true;
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Nie żyjesz");
                    Application.Exit();
            }
            
        }

        private void PositionUpdate()
        {
            int suma = b + g;
            if(suma!=0)
            {
                foreach (Enemy enemy in game.Enemies)
                {

                    if (enemy is Bat)
                    {


                        if (enemy.HitPoints > 0 && !enemy.Dead)
                        {
                            b = 1;
                            Batt.Visible = true;

                            Batt.Location = enemy.Location;
                            BatHp.Text = enemy.HitPoints.ToString();
                        }
                        else
                        {
                            b = 0;
                            Batt.Visible = false;
                            BatHp.Text = "0";
                        }

                    }
                    else if (enemy is Ghost)
                    {


                        if (enemy.HitPoints > 0 && !enemy.Dead)
                        {
                            g = 1;
                            Ghost.Location = enemy.Location;
                            GhoHP.Text = enemy.HitPoints.ToString();
                            Ghost.Visible = true;
                        }
                        else
                        {
                            g = 0;
                            Ghost.Visible = false;
                            GhoHP.Text = "0";
                        }
                    }
                    else if (enemy is Ghul)
                    {



                        if (enemy.HitPoints > 0)
                            Banshee.Location = enemy.Location;
                        BanHP.Text = enemy.HitPoints.ToString();
                        Banshee.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Udało Ci się oczyścić pomieszczenie gratulacje");
                Application.Exit();
            }
        }




        //Atak
        private void Right_Click(object sender,    EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
            PositionUpdate();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
            PositionUpdate();
        }

        private void Top_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
            PositionUpdate();
        }

        private void Down_Click(object sender,EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
            PositionUpdate();
        }
        //Sterowanie
        private void Top1_Click(object sender, EventArgs e)
        {
           game.Move(Direction.Up,random);
            UpdateCharacters(); PositionUpdate();



        }

        private void Down1_Click(object sender, EventArgs e)
        {

            game.Move(Direction.Down,random);
            UpdateCharacters(); PositionUpdate();
        }

        private void Right1_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right,random);
            UpdateCharacters(); PositionUpdate();
        }

        private void Left1_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left,random);
            UpdateCharacters(); PositionUpdate();
        }

        private void isword_Click(object sender, EventArgs e)
        {
            if (isword.Visible)
            {
                game.Equip(game.WeaponInRoom.Name);
                isword.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}
