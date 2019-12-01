using System;
using System.Drawing;

namespace The_Quest
{
    class BluePotion : Weapon, IPotion
    {
        private bool used = false;
        public bool Used { get => used; set => used = value; }
        public override string Name { get => "Blue Potion"; protected set => Name = value; }

        public BluePotion(Game game, Point location)
            : base(game, location)
        {
        }
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            used = true;
        }
    }
}
