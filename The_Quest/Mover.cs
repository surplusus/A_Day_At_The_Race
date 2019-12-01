using System;
using System.Drawing;

namespace The_Quest
{
    public abstract class Mover
    {
        protected readonly int MoveInterval = 10;
        public Point Location { get; set; }
        protected Game game;
        public Mover(Game game, Point location)
        {
            this.game = game;
            this.Location = location;
        }
        public bool NearBy(Point locationToCheck, int distance)
        {
            if (Math.Abs(Location.X - locationToCheck.X) < distance &&
                Math.Abs(Location.Y - locationToCheck.Y) < distance)
                return true;

            return false;
        }
        public virtual Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = Location;
            switch (direction)
            {
                case Direction.UP:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.DOWN:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.LEFT:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.RIGHT:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default: break;
            }
            return newLocation;
        }
    }
}
