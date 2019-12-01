using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private int moveRange = 10;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(12, 12, 691, 425));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            PlayerSprite.Location = game.PlayerLocation;
            PlayerHitPoints.Text = game.PlayerHitPoints.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                MessageBox.Show("1245");
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move((int)Direction.UP, random.Next(-moveRange, moveRange));
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move((int)Direction.LEFT, random.Next(-moveRange, moveRange));
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move((int)Direction.RIGHT, random.Next(-moveRange, moveRange));
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move((int)Direction.DOWN, random.Next(-moveRange, moveRange));
        }

        private void AttackUp_Click(object sender, EventArgs e)
        {

        }

        private void AttackLeft_Click(object sender, EventArgs e)
        {

        }

        private void AttackRight_Click(object sender, EventArgs e)
        {

        }

        private void AttackDown_Click(object sender, EventArgs e)
        {

        }

        private void SwordInvSprite_Click(object sender, EventArgs e)
        {

        }

        private void RedPotionInvSprite_Click(object sender, EventArgs e)
        {

        }

        private void BowInvSprite_Click(object sender, EventArgs e)
        {

        }

        private void BluePotionInvSprite_Click(object sender, EventArgs e)
        {

        }

        private void MaceInvSprite_Click(object sender, EventArgs e)
        {

        }


    }
}
