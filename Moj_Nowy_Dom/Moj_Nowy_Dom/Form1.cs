using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moj_Nowy_Dom
{
    public partial class Form1 : Form
    {
        int Moves;
        
        Location currentLocation;
        
        OutsideWithDoor frontyard;
        OutsideWithDoor backyard;
        OutSideWithHidingPlace driveway;
        OutSideWithHidingPlace garden;

        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        RoomWithDoor livingRoom;
        Room Kitchen;
        RoomWithDoor dinnerRoom;

        Opponent opponent;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontyard);
            MoveToNewLocation(livingRoom);
            ResetGame(false);
        }


        private void CreateObjects()
        {
             livingRoom = new RoomWithDoor("Salon", "dywan z frędzlami", "dębowe drzwi z mosiężną klamką" ,"Pod sofą");
             Kitchen = new Room("kuchnia", "Granitowe blaty z ledowym podświetleniem");
             dinnerRoom = new RoomWithDoor("Jadalnia", "4 dębowe krzesła i duży prostokątny stół", "drzwi przesówne","Pod stołem");

            frontyard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
            backyard = new OutsideWithDoor("Podwórko za domem", true, "drzwi przesówne");
            garden = new OutSideWithHidingPlace("Ogród",false, "szopa");
            masterBedroom = new RoomWithHidingPlace("głowna sypialnia", "Łóżko z podstawą dębową", "Szafa na ubrania");
            secondBedroom =new RoomWithHidingPlace("sypialnia gościnna", "Szafa z hebanowego australijskiego klonowca", "wersalka");
            hallway = new RoomWithHidingPlace("Hol", "Bordowe ściany z kinkietami", "kanciapa");
            bathroom = new RoomWithHidingPlace("Łazienka", "Prysznic ze ścianami z polerowanego granitu", "Wanna");

            stairs = new Room("schody", "smukła poręcz");

            driveway = new OutSideWithHidingPlace("Podjazd", true, "garaż");
            garden = new OutSideWithHidingPlace("Ogród", true, "Domek ogrodniczy");

            dinnerRoom.Exits= new Location[] { Kitchen };
            livingRoom.Exits = new Location[] { Kitchen,stairs };
            Kitchen.Exits = new Location[] { livingRoom, dinnerRoom };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            bathroom.Exits = new Location[] { hallway };
            stairs.Exits = new Location[] { livingRoom,hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            frontyard.Exits = new Location[] { backyard, garden,driveway };
            backyard.Exits = new Location[] { frontyard, garden,driveway };
            garden.Exits = new Location[] { frontyard, backyard };

            livingRoom.DoorLocation = frontyard;
            frontyard.DoorLocation = livingRoom;
            dinnerRoom.DoorLocation = backyard;
            backyard.DoorLocation = dinnerRoom;





        }
        private void MoveToNewLocation(Location newLocation)
        {
            Moves++;

           currentLocation = newLocation;
            RedrawForm();
           
            
        }
        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)

                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer " + Moves + ")";

            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                Check.Text = "Sprawdź " + hidingPlace.HidingPlaceName;
                Check.Visible = true;
            }
            else
                Check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                Go_thorugh.Visible = true;
            else
                Go_thorugh.Visible = false;
        }

        private void GoHere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void Go_thorugh_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToNewLocation(hasDoor.DoorLocation);
        }


        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Odnalazłeś mnie w " + Moves + " ruchach!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "Znalazłeś przeciwnika w " + Moves + " ruchach! \n Ukrywał się " + foundLocation.HidingPlaceName + ".\n"; 
            }
            Moves = 0;
            Take_Cover.Visible = true;
            GoHere.Visible = false;
            Check.Visible = false;
            Go_thorugh.Visible = false;
            exits.Visible = false;

        }

        private void Take_Cover_Click(object sender, EventArgs e)
        {
            Take_Cover.Visible = false;
            for (int i = 1; i <= 10; i++)   
            { opponent.Move();
                description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Gotowy czy nie - nadchodzę!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            GoHere.Visible = true;
            exits.Visible = true;
            MoveToNewLocation(livingRoom);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }
    }
}
