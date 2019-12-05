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
    enum TypeButton
    {
        MoveUp, MoveRight, MoveDown, MoveLeft, AttackUp, AttackRight, AttackDown, AttackLeft
    }
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private Control[] buttonCtrl;
        private PictureBox[] playerAttackRange;
        private Control[] inventoryCtrl;
        private Control[] weaponInRoomCtrl;
        private Color defaultButtonColor = Color.Beige;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            buttonCtrl = new Control[8] { MoveUp, MoveRight, MoveDown, MoveLeft, AttackUp, AttackRight, AttackDown, AttackLeft };
            inventoryCtrl = new Control[5] { SwordInvSprite, BowInvSprite, MaceInvSprite, RedPotionInvSprite, BluePotionInvSprite };
            weaponInRoomCtrl = new Control[5]{ RedPotionSprite, BluePotionSprite, SwordSprite, BowSprite, MaceSprite};
            playerAttackRange = new PictureBox[4] { AttackRange_Up, AttackRange_Right, AttackRange_Down, AttackRange_Left };
            for (int i = 0; i < 8; i++)
                buttonCtrl[i].BackColor = defaultButtonColor;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(12, 12, 655, 383));
            game.NewLevel(random);
            UpdateCharacters();
            defaultButtonColor = buttonCtrl[0].BackColor;
        }

        private void UpdateCharacters()
        {
            PlayerSprite.Location = game.PlayerLocation;
            PlayerHitPoints.Text = game.PlayerHitPoints.ToString();

            List<bool> enemyList = new List<bool>(Enumerable.Repeat<bool>(false,3));
            int enemyFlag = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                UpdateEnemy(ref enemyFlag, ref enemyList, enemy);
            }
            //Math.Pow(2, 3);

            List<bool> weaponList = new List<bool>(Enumerable.Repeat<bool>(false,5));
            int weaponFlag = 0;

            foreach (Weapon weapon in game.WeaponsInRoom)
            {
                UpdateWeaponCtrl(ref weaponFlag, ref weaponList, weapon);
            }

            foreach (String weaponName in game.nameOfInvenItem)
            {
                UpdateInventory(weaponName);
            }

            if (game.PlayerHitPoints <= 0)
                if (MessageBox.Show("죽었습니다.") == DialogResult.OK)
                    Application.Exit();

            if (enemyList.Count < 1)
            {
                MessageBox.Show("적을 죽였습니다. 다음 레벨로 갑시다!");
                game.NewLevel(random);
                UpdateCharacters();
            }

        }

        private void UpdateInventory(string weaponName)
        {
            Control control = null;

            switch (weaponName)
            {
                case "Red Potion":
                    control = RedPotionInvSprite;
                    break;
                case "Blue Potion":
                    control = BluePotionInvSprite;
                    break;
                case "Sword":
                    control = SwordInvSprite;
                    break;
                case "Bow":
                    control = BowInvSprite;
                    break;
                case "Mace":
                    control = MaceInvSprite;
                    break;
            }

            if (game.CheckPlayerInventory(weaponName))
                control.Visible = true;
            if (game.PlayerEquippedWeapon != null)
                if (game.PlayerEquippedWeapon.Name == weaponName)
                    control.BackColor = Color.Blue;
        }

        private void UpdateWeaponCtrl(ref int weaponFlag, ref List<bool> list, Weapon weapon)
        {
            Control weaponCtrl = null;

            switch (weapon.Name)
            {
                case "Red Potion":
                    weaponFlag += (int)TypeWeapon.REDPOTION;
                    weaponCtrl = RedPotionSprite;
                    break;
                case "Blue Potion":
                    weaponFlag += (int)TypeWeapon.BLUEPOTION;
                    weaponCtrl = BluePotionSprite;
                    break;
                case "Sword":
                    weaponFlag += (int)TypeWeapon.SWORD;
                    weaponCtrl = SwordSprite;
                    break;
                case "Bow":
                    weaponFlag += (int)TypeWeapon.BOW;
                    weaponCtrl = BowSprite;
                    break;
                case "Mace":
                    weaponFlag += (int)TypeWeapon.MACE;
                    weaponCtrl = MaceSprite;
                    break;
            }
            for (int i = 0; i < 5; ++i)
            {
                int flag = (1 << i);
                if ((weaponFlag & flag) == 1)
                    weaponInRoomCtrl[i].Visible = true;
            }
        }

        private void UpdateEnemy(ref int enemyFlag, ref List<bool> list, Enemy enemy)
        {
            if (enemy is Bat)
            {
                enemyFlag += (int)TypeEnemy.BAT;

                Bat bat = enemy as Bat;
                list[0] = !enemy.Dead;
                BatHitPoints.Text = enemy.HitPoints.ToString();
                if (enemy.HitPoints > 0)
                {
                    BatSprite.Visible = !enemy.Dead;
                }
            }
            else if (enemy is Ghost)
            {
                enemyFlag += (int)TypeEnemy.GHOST;
                Ghost ghost = enemy as Ghost;
                list[1] = !enemy.Dead;
                BatHitPoints.Text = enemy.HitPoints.ToString();
                if (enemy.HitPoints > 0)
                {
                    GhostSprite.Visible = !enemy.Dead;
                }
            }
            else if (enemy is Ghoul)
            {
                enemyFlag += (int)TypeEnemy.GHOUL;
                Ghoul ghoul = enemy as Ghoul;
                list[2] = !enemy.Dead;
                BatHitPoints.Text = enemy.HitPoints.ToString();
                if (enemy.HitPoints > 0)
                {
                    BatSprite.Visible = !enemy.Dead;
                }
            }
        }
        private void UpdateAttackRange(Direction dir, bool attack)
        {
            int[] dx = { 0, 30, 0, -30 };
            int[] dy = { -30, 0, 30, 0 };
            if (!attack)
            {
                for (int i = 0; i < 4; ++i)
                {
                    playerAttackRange[i].BackColor = Color.Transparent;
                    playerAttackRange[i].Location = 
                        new Point(game.PlayerLocation.X + dx[i], game.PlayerLocation.Y + dy[i]);
                }
            }
            else
            {
                if (game.PlayerEquippedWeapon == null)
                {
                    MessageBox.Show("아직 무기가 없습니다!");
                    return;
                }
                switch (game.PlayerEquippedWeapon.Name)
                {
                    case "Sword":
                        playerAttackRange[((int)dir - 1) % 4].BackColor = Color.Red;
                        playerAttackRange[((int)dir) % 4].BackColor = Color.Red;
                        playerAttackRange[((int)dir + 1) % 4].BackColor = Color.Red;
                        break;
                    case "Bow":
                        playerAttackRange[(int)dir].Location =
                            new Point(game.PlayerLocation.X + 50, game.PlayerLocation.Y + 50);
                        playerAttackRange[((int)dir) % 4].BackColor = Color.Red;
                        break;
                    case "Mace":
                        foreach (PictureBox range in playerAttackRange)
                            range.BackColor = Color.Red;
                        break;
                    default:
                        MessageBox.Show("아직 무기가 없습니다!");
                        break;
                }
            }
        }
        private int FindIndexOfPushButton(KeyEventArgs e)
        {
            int idxButton = 0;

            if (e.KeyCode == Keys.W)
                idxButton = (int)TypeButton.MoveUp;
            else if (e.KeyCode == Keys.D)
                idxButton = (int)TypeButton.MoveRight;
            else if (e.KeyCode == Keys.S)
                idxButton = (int)TypeButton.MoveDown;
            else if (e.KeyCode == Keys.A)
                idxButton = (int)TypeButton.MoveLeft;
            else if (e.KeyCode == Keys.Up)
                idxButton = (int)TypeButton.AttackUp;
            else if (e.KeyCode == Keys.Right)
                idxButton = (int)TypeButton.AttackRight;
            else if (e.KeyCode == Keys.Down)
                idxButton = (int)TypeButton.AttackDown;
            else if (e.KeyCode == Keys.Left)
                idxButton = (int)TypeButton.AttackLeft;

            return idxButton;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int idxButton = FindIndexOfPushButton(e);

            if (idxButton < 4)
            {
                game.Move((Direction)idxButton, random);
                UpdateAttackRange((Direction)idxButton, false);
            }
            else
            {
                game.Attack((Direction)(idxButton - 4), random);
                UpdateAttackRange((Direction)idxButton, true);
            }

            buttonCtrl[idxButton].ForeColor = Color.White;
            buttonCtrl[idxButton].BackColor = Color.Crimson;

            UpdateCharacters();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int idxButton = FindIndexOfPushButton(e);

            buttonCtrl[idxButton].ForeColor = Color.Gray;
            buttonCtrl[idxButton].BackColor = defaultButtonColor;

            foreach (PictureBox range in playerAttackRange)
            {
                range.BackColor = Color.Transparent;
            }
        }
        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.UP, random);
            UpdateCharacters();
            UpdateAttackRange(Direction.UP, false);
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.LEFT, random);
            UpdateCharacters();
            UpdateAttackRange(Direction.LEFT, false);
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.RIGHT, random);
            UpdateCharacters();
            UpdateAttackRange(Direction.RIGHT, false);
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.DOWN, random);
            UpdateCharacters();
            UpdateAttackRange(Direction.DOWN, false);
        }

        private void AttackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.UP, random);
            UpdateCharacters();
            UpdateAttackRange(Direction.UP, true);
        }

        private void AttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.LEFT, random);
            UpdateCharacters();
            UpdateAttackRange(Direction.LEFT, true);
        }

        private void AttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.RIGHT, random);
            UpdateCharacters();
            UpdateAttackRange(Direction.RIGHT, true);
        }

        private void AttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.DOWN, random);
            UpdateCharacters();
            UpdateAttackRange(Direction.DOWN, true);
        }

        private void SwordInvSprite_Click(object sender, EventArgs e)
        {
            game.Equip("Sword");
        }

        private void RedPotionInvSprite_Click(object sender, EventArgs e)
        {
            game.Equip("Red Potion");
        }

        private void BowInvSprite_Click(object sender, EventArgs e)
        {
            game.Equip("Bow");
        }

        private void BluePotionInvSprite_Click(object sender, EventArgs e)
        {
            game.Equip("Blue Potion");
        }

        private void MaceInvSprite_Click(object sender, EventArgs e)
        {
            game.Equip("Mace");
        }


    }
}
