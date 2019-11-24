using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRace
{
    class Greyhound
    {
        public readonly int StartingPosition;
        private const int RaceTrackLenth = 430;
        private AnimSprite sprite;
        private PictureBox MyPictureBox;
        private int Location = 0;
        public Random Randomizer;
        public Greyhound(PictureBox pictureBox, int location)
        {
            this.Location = location;
            MyPictureBox = pictureBox;
            sprite = new AnimSprite(Properties.Resources.horse_crop, 50, Location); ;
            StartingPosition = MyPictureBox.Location.X * 30;
            Randomizer = new Random(DateTime.Now.Second);
        }
        public bool Run()
        {
            sprite.Start();
            // Move forward random
            int distance = Randomizer.Next(1, 20);
            // Update Position of Picturebox
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            // REturn true if race ends
            if (p.X > RaceTrackLenth)
                return false;
            return true;
        }
        public void TakeStartingPosition()
        {
            //Reset location to the start line
            Point point = new Point(this.StartingPosition, 10);
            MyPictureBox.PointToClient(point);
        }
    }
}
