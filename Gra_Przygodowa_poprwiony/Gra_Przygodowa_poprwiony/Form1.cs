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
            GhoHP.Text = "0";
            BatHp.Text = "0";
            BanHP.Text = "0";
            sword.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.Name == "Miecz")
                sword.Visible = true;
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
            if (game.WeaponInRoom.Nearby(game.PlayerLocation, 10)&& weaponControl.Visible)
       //     {
                
                game.WeaponInRoom.PickUpWeapon();
             //   game.Equip(weaponControl.Name);
           //     pick = game.WeaponInRoom.PickedUp;
             

        //    }
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                
                weaponControl.Visible = false;
                isword.Visible = true;
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

            foreach(Enemy enemy in game.Enemies)
            {

                if (enemy is Bat)
                {
                   
                  
                    Batt.Location = enemy.Location;
                    BatHp.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints>0)
                        Batt.Visible = true;
                }
                else if (enemy is Ghost)
                {
                    
                    Ghost.Location = enemy.Location;
                    GhoHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                        Ghost.Visible = true;
                }
                else if (enemy is Ghul)
                {
                   
                
                    Banshee.Location = enemy.Location;
                    BanHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                        Banshee.Visible = true;
                }
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

       
    }
}
