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
        OutsideWithDoor frontyard;
        OutsideWithDoor backyard;
        OutSide garden;
       
        public Form1()
        {
            InitializeComponent();
        }


        private void CreateObjects()
        {
            RoomWithDoor livingRoom = new RoomWithDoor("Salon", "dywan z frędzlami", "dębowe drzwi z mosiężną klamką");
            Room kitchen = new Room("kuchnia", "Granitowe blaty z ledowym podświetleniem");
            RoomWithDoor dinnerRoom = new RoomWithDoor("Jadalnia", "4 dębowe krzesła i duży prostokątny stół", "drzwi przesówne");

            frontyard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
            backyard = new OutsideWithDoor("Podwórko za domem", true, "drzwi przesówne");
            garden = new OutSide(false, "Ogród");


            dinnerRoom.Exits= new Location[] { kitchen };
            livingRoom.Exits = new Location[] { kitchen };
            kitchen.Exits = new Location[] { livingRoom, dinnerRoom };
            frontyard.Exits = new Location[] { backyard, garden };
            backyard.Exits = new Location[] { frontyard, garden };
            garden.Exits = new Location[] { frontyard, backyard };

            livingRoom.DoorLocation = frontyard;
            frontyard.DoorLocation = livingRoom;
            dinnerRoom.DoorLocation = backyard;
            backyard.DoorLocation = dinnerRoom;





        }
        private void MoveToNewLocation(Location newLocation)
        {

         Location   currentLocation = newLocation;
            exits.Items.Clear();
            for(int i=0;i<currentLocation.Exits)
        }

    }
}
