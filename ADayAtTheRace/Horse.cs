using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADayAtTheRace
{
    class Horse
    {
        public readonly int StartingPosition;
        private const int RaceTrackLenth = 430;
        private AnimSprite sprite;
        private PictureBox MyPictureBox;
        private Point StartingPoint;
        private int Location;
        public Random Randomizer;
        public Horse(PictureBox pictureBox, int startPosition)
        {
            this.StartingPosition = startPosition;
            MyPictureBox = pictureBox;
            this.Location = MyPictureBox.Location.X * 30;
            this.StartingPoint = new Point(MyPictureBox.Location.X, MyPictureBox.Location.Y);
            sprite = new AnimSprite(Properties.Resources.horse, 50, Location);
            MyPictureBox.Image = Properties.Resources.horse;
            Randomizer = new Random((int)DateTime.Now.Ticks);
            sprite.Start();
        }
        public bool Run()
        {
            MyPictureBox.Image = sprite.Draw();
            // Move forward random
            int distance = Randomizer.Next(1, 20);
            // Update Position of Picturebox
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            // Return true if race ends
            if (p.X > RaceTrackLenth)
            {

                return false;
            }
            return true;
        }
        public void TakeStartingPosition()
        {
            //Reset location to the start line
            MyPictureBox.Location = this.StartingPoint;
        }

    }
}
