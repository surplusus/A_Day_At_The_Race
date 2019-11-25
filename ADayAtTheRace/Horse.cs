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
        private Sprite sprite;
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
            sprite = new Sprite();
            sprite.numHorse = startPosition;
            sprite.pictureBox = MyPictureBox;
            sprite.LoadSprites();
            Randomizer = new Random((int)DateTime.Now.Ticks);
        }
        public void Toggle_PlaySprite()
        {
            sprite.Toggle_SpriteTimer();
        }
        public bool Run()
        {
            // Move forward random
            int distance = Randomizer.Next(1, 20);
            // Update Position of Picturebox
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            MyPictureBox.Invalidate();
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
