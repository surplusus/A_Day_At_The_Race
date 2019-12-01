using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    public abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        public int HitPoints { get; private set; }
        public bool Dead { get
            {
                if (HitPoints <= 0) return true;
                else return false;
            } 
        }

        public abstract void Move(Random random);
        public Enemy(Game game, Point location, int hitpoint) 
            : base(game, location) 
        {
            this.HitPoints = hitpoint;
        }
        public void Hit(int MaxDamage, Random random)
        {
            HitPoints -= random.Next(1, MaxDamage);
        }
        protected bool NearPlayer()
        {
            return (NearBy(game.PlayerLocation, NearPlayerDistance));
        }
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > Location.X + 10) directionToMove = Direction.RIGHT;
            else if (playerLocation.X < Location.X - 10) directionToMove = Direction.LEFT;
            else if (playerLocation.Y < Location.Y - 10) directionToMove = Direction.UP;
            else directionToMove = Direction.DOWN;

            return directionToMove;
        }
    }
}
