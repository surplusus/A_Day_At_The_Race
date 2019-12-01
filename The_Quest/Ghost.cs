using System;
using System.Drawing;

namespace The_Quest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8) { }

        public override void Move(Random random)
        {
            if (random.Next(2) == 1)
            {
                Location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }

            if (NearPlayer())
            {
                game.HitPlayer(3, random);
            }
        }
    }
}
