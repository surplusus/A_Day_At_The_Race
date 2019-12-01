using System;
using System.Drawing;

namespace The_Quest
{
    class RedPotion : Weapon, IPotion
    {
        private bool used = false;
        public bool Used { get => used; set => used = value; }
        public override string Name { get => "Red Potion"; protected set => Name = value; }
        
        public RedPotion(Game game, Point location) 
            : base(game, location)
        {
        }
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            used = true;
        }
    }
}
