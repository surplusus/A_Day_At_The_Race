using System;
using System.Drawing;

namespace The_Quest
{
    public class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base (game, location) { }
        public override string Name { get { return "Sword"; } protected set { Name = value; } }
        public override void Attack(Direction direction, Random random)
        {
            int nDirection = (int)direction;
            Direction clockwise = (Direction)((nDirection + 1) % 4);
            Direction counterClockwise = (Direction)((nDirection - 1) % 4);
            Direction[] attackDirections = new Direction[3] { direction, clockwise, counterClockwise };

            foreach (Direction dir in attackDirections)
            {
                if (DamageEnemy(dir,20,3,random))
                {
                    return;
                }
            }
        }
    }
}
