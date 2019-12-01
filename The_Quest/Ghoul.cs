using System;
using System.Drawing;

namespace The_Quest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        {
        }
        public override void Move(Random random)
        {
            if (random.Next(2) != 1)
            {
                Location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            if (NearPlayer())
                game.HitPlayer(4, random);
        }
    }
}
