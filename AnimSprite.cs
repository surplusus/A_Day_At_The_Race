using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADayAtTheRace
{
    class AnimSprite
    {
        private int frame, interval, width, height;
        public Image image;
        private Timer frameTimer;
        public int idxStart;
        public AnimSprite(Bitmap image, int width, int startIdx)
        {
            idxStart = startIdx;
            frame = 0;
            this.width = width;
            this.image = image;
            this.height = image?.Height ?? 0;   // image가 널이면 0
        }
        public void Start(int interval)
        {
            this.interval = interval;

            frameTimer = new Timer();
            frameTimer.Interval = interval;
            frameTimer.Tick += new EventHandler(advanceFrame);
            frameTimer.Start();
        }
        public void Start()
        {
            Start(50);
        }
        public void Stop()
        {
            frameTimer.Stop();
            frameTimer.Dispose();
        }
        public Bitmap Draw(Graphics g)
        {
            Bitmap bitmap;
            Graphics graphics;

            bitmap = new Bitmap(width, height, g);
            graphics = Graphics.FromImage(bitmap);

            graphics.DrawImageUnscaled(image, width * (idxStart + frame), height);

            graphics.Dispose();
            return bitmap;
        }
        private void advanceFrame(object sender, EventArgs e)
        {
            ++frame;
            if (frame >= 4)
                frame = 0;
        }
    }
}
