using System;
using System.Drawing;

namespace The_Quest
{
    public class Bow : Weapon
    {
        public Bow(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Bow"; } protected set { Name = value; } }
        public override void Attack(Direction direction, Random random)
        {
            int nDirection = (int)direction;
            Direction clockwise = (Direction)((nDirection + 1) % 4);
            Direction counterClockwise = (Direction)((nDirection - 1) % 4);
            Direction[] attackDirections = new Direction[1] { direction};

            foreach (Direction dir in attackDirections)
            {
                if (DamageEnemy(dir, 30, 1, random))
                {
                    return;
                }
            }
        }
    }
}
