using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace The_Quest
{
    [Flags]
    enum TypeEnemy
    {
        NONE = 0, BAT = 1, GHOST = 2, GHOUL = 4
    }
    [Flags]
    enum TypeWeapon
    {
        NONE = 0, REDPOTION = 1, BLUEPOTION = 2, SWORD = 4, BOW = 8, MACE = 16
    }
    public enum Direction
    {
        UP, RIGHT, DOWN, LEFT, END
    }
    public class Game
    {
        public readonly string[] nameOfInvenItem;
        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public List<Enemy> Enemies { get; private set; } = new List<Enemy>();
        public List<Weapon> WeaponsInRoom { get; private set; } = new List<Weapon>();
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        public Weapon PlayerEquippedWeapon { get { return player.EquippedWeapon; } }
        public int Level { get; private set; } = 0;
        public Rectangle Boundaries { get; private set; }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public Rectangle[] PlayerAttackRange { get { return player.RectOfAttackRange; } }
        public Game(Rectangle boundaries)
        {
            this.Boundaries = boundaries;
            nameOfInvenItem = new string[5] { "Red Potion", "Blue Potion", "Sword", "Bow", "Mace" };
            player = new Player(this
                , new Point(boundaries.Left + 10, boundaries.Top + 70));
        }
        public void AcquireWeapon(Weapon weapon)
        {
            player.AcquireWeapon(weapon);
            //WeaponsInRoom.Find((e) => (weapon.Name == e.Name)).PickUpWeapon();
            WeaponsInRoom.Remove(weapon);
        }
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
            // Attack Rectangle
        }
        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }
        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }
        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }
        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }
        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                if (!enemy.Dead)
                {
                    if (player.EquippedWeapon != null)
                        player.EquippedWeapon.Attack(direction, random);
                    enemy.Move(random);
                }
            }
        }
        private Point GetRandomLocation(Random random)
        {
            return new Point(Boundaries.Left + random.Next(Boundaries.Right / 10 - Boundaries.Left / 10) * 10
                , Boundaries.Top + random.Next(Boundaries.Bottom / 10 - Boundaries.Top / 10) * 10);
        }
        public void NewLevel(Random random)
        {
            Level++;
            if (Level != 1)
                MessageBox.Show($"레벨업!! : {Level} 랩");
            Enemies.Clear();
            WeaponsInRoom.Clear();

            AddEnemyInRoom(random);
            AddWeaponInRoom(random);
            
            if (Level == 8)
            {
                if (MessageBox.Show("축하합니다. 만랩이 되었어요! 게임을 종료합니다") == DialogResult.OK)
                    Application.Exit();
            }
        }
        private void AddEnemyInRoom(Random random)
        {
            switch (Level)
            {
                case 1:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    break;
                case 2:
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    break;
                case 3:
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    break;
                case 4:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    break;
                case 5:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    break;
                case 6:
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    break;
                case 7:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    break;
                default:
                    break;
            }
        }
        private void AddWeaponInRoom(Random random)
        {
            switch (Level)
            {
                case 1:
                    WeaponsInRoom.Add(new Sword(this, GetRandomLocation(random)));
                    break;
                case 2:
                    WeaponsInRoom.Add(new BluePotion(this, GetRandomLocation(random)));
                    break;
                case 3:
                    WeaponsInRoom.Add(new Bow(this, GetRandomLocation(random)));
                    break;
                case 4:
                    if (CheckPlayerInventory("Bow"))
                    {
                        if (!CheckPlayerInventory("Blue Potion"))
                        {
                            WeaponsInRoom.Add(new BluePotion(this, GetRandomLocation(random)));
                        }
                    }
                    else
                    {
                        WeaponsInRoom.Add(new Bow(this, GetRandomLocation(random)));
                    }
                    break;
                case 5:
                    WeaponsInRoom.Add(new RedPotion(this, GetRandomLocation(random)));
                    break;
                case 6:
                    WeaponsInRoom.Add(new Mace(this, GetRandomLocation(random)));
                    break;
                case 7:
                    if (!CheckPlayerInventory("Mace"))
                        WeaponsInRoom.Add(new Mace(this, GetRandomLocation(random)));
                    break;
                default:
                    break;
            }
        }
    }
}
