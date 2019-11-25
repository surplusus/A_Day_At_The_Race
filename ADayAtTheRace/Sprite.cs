using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ADayAtTheRace
{
    class Sprite
    {
        private static readonly int SPRITE_WIDTH = 33;
        private static readonly int SPRITE_HEIGHT = 28;
        private static readonly int NUM_SPRITES = 4;

        private static readonly int TIMER_INTERVAL = 100; // ms

        private int currentSprite = 0;
        public int numHorse { get; set; }
        private Image[] sprites = new Image[NUM_SPRITES];
        public PictureBox pictureBox;
        private Timer timer;
        public Sprite()
        {
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new System.EventHandler(this.timer_Tick);
        }
        public bool LoadSprites()
        {
            int requiredWidth = SPRITE_WIDTH;
            int requiredHeight = SPRITE_HEIGHT;

            currentSprite = 0;
            Image image = Properties.Resources.horse;

            for (int i = 0; i < 4; ++i)
            {
                sprites[i] = new Bitmap(pictureBox.Width, pictureBox.Height);
                using (Graphics g = Graphics.FromImage(sprites[i]))
                {
                    int num = i + numHorse*4;
                    g.DrawImage(image, new Rectangle(0, 0, SPRITE_WIDTH, SPRITE_HEIGHT)
                        , new Rectangle(num * SPRITE_WIDTH, 0, SPRITE_WIDTH, SPRITE_HEIGHT)
                        , GraphicsUnit.Pixel);
                }
            }
            pictureBox.Image = sprites[currentSprite];
            return true;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            NextImage();
        }
        public void Toggle_SpriteTimer()
        {
            if (timer.Enabled == true)
                timer.Stop();
            else
                timer.Start();
        }
        private void NextImage()
        {
            pictureBox.Image = sprites[currentSprite];
            ++currentSprite;
            currentSprite %= NUM_SPRITES;
        }
    }
}
