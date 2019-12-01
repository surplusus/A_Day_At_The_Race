using System;
using System.Drawing;

namespace The_Quest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6) { }
        public override void Move(Random random)
        {
            if (random.Next(1) == 1)
            {
                Location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else
            {
                Location = Move((Direction)random.Next(3), game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
    }
}
