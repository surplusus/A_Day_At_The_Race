using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_Quest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Mace"; } protected set { Name = value; } }
        public override void Attack(Direction direction, Random random)
        {
            int nDirection = (int)direction;
            Direction clockwise = (Direction)((nDirection + 1) % 4);
            Direction counterClockwise = (Direction)((nDirection - 1) % 4);
            Direction[] attackDirections = new Direction[4] { (Direction)0, (Direction)1, (Direction)2, (Direction)3 };
            
            foreach (Direction dir in attackDirections)
            {
                DamageEnemy(dir, 20, 6, random);
            }
        }
    }
}
