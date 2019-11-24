using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRace
{
    public partial class Form1 : Form
    {
        private Guy[] guys = new Guy[3];
        private Greyhound[] greyhounds = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();

            Timer.Start();

            var image = Properties.Resources.race;
            pictureBox1.BackgroundImage = image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            guys[0] = new Guy("Joe", GuyName) { MyRadioButton = Joe_RadioButton };
            guys[1] = new Guy("Bob", GuyName);
            guys[2] = new Guy("AI", GuyName);

            greyhounds[0] = new Greyhound(Dog0_Pic, 0);
            greyhounds[1] = new Greyhound(Dog1_Pic, 1);
            greyhounds[2] = new Greyhound(Dog2_Pic, 2);
            greyhounds[3] = new Greyhound(Dog3_Pic, 3);
        }

        private void Joe_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guys[0].UpdateLabels();
        }


        private void Bob_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guys[1].UpdateLabels();
        }

        private void AI_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guys[2].UpdateLabels();
        }
        private void Bets_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            bool isRunning = true;
            foreach (Greyhound greyhound in greyhounds)
            {
                isRunning = greyhound.Run();
                if (isRunning == false)
                {
                    Timer.Stop();
                    MessageBox.Show("끝!", "끝!", MessageBoxButtons.OK);
                }
            }
        }
    }
}
