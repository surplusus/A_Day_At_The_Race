using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeGame
{
    public partial class Form1 : Form
    {
        private Random random;
        private Stats stats = new Stats();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.MultiColumn = true;
            KeyPreview = true;
            random = new Random();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;

                float oneToCent = ((800.0f - (float)timer1.Interval) / 800.0f) * 100.0f;
                Difficulty_ProgressBar.Value = (int)oneToCent;

                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            Correct_Label.Text = string.Format($"Correct: {stats.Correct}");
            Missed_Label.Text = string.Format($"Missed: {stats.Missed}");
            Total_Label.Text = string.Format($"Total: {stats.Total}");
            Accuracy_Label.Text = string.Format($"Accuracy: {stats.Accuracy}");

            if (timer1.Enabled == false)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    listBox1.Items.Clear();
                    stats = new Stats();
                    timer1.Start();
                }
            }
        }
    }
}
