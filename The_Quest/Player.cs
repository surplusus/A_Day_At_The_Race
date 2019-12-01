using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_Quest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        private List<Weapon> inventory = new List<Weapon>();
        public int HitPoints { get; private set; }
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                
                return names;
            }
        }

        public Player(Game game, Point location)
            : base(game, location)
        {
            HitPoints = 10;
        }
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
        }
        public void Move(Direction direction)
        {
            base.Location = Move(direction, game.Boundaries);
            foreach (Weapon weapon in game.WeaponsInRoom)
            {
                if (!weapon.PickedUp)
                {
                    if (NearBy(weapon.Location, 1))
                    {
                        weapon.PickUpWeapon();
                        inventory.Add(weapon);
                    }
                }
            }
        }
        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                {
                    IPotion potion = equippedWeapon as IPotion;
                    potion.Used = true;
                }
            }
        }

    }
}
