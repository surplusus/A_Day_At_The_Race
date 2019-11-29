using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_MakeHouse
{
    public partial class Form1 : Form
    {
        Location currentLocation;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1()
        {
            InitializeComponent();

            CreateObjects();
            MoveToANewLocation(livingRoom);
        }
        void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room"
                , "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);

            livingRoom.Exits = new Location[] { diningRoom};
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom};
            frontYard.Exits = new Location[] { backYard, garden};
            backYard.Exits = new Location[] { frontYard, garden };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }
        void MoveToANewLocation(Location location)
        {
            currentLocation = location;

            comboBox_Exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; ++i)
            {
                comboBox_Exits.Items.Add(currentLocation.Exits[i].Name);
            }
            comboBox_Exits.SelectedIndex = 0;

            textBox_Desctiption.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                button_GoThDoor.Visible = true;
            else
                button_GoThDoor.Visible = false;
        }

        private void button_GoToHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[comboBox_Exits.SelectedIndex]);
        }

        private void button_GoThDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
