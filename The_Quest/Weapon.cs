using System;
using System.Drawing;

namespace The_Quest
{
    public abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }
        public Weapon(Game game, Point  location)
            : base(game, location)
        {
            PickedUp = false;
        }
        public void PickUpWeapon()
        {
            PickedUp = true;
        }
        public abstract string Name { get; protected set; }
        public abstract void Attack(Direction direction, Random random);
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int dist = 25; dist < 25 + radius; dist++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (NearBy(enemy.Location, target, dist))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
        public bool NearBy(Point enemyLocation, Point playerLocation, int distance)
        {
            if (Math.Abs(enemyLocation.X - playerLocation.X) < distance &&
                Math.Abs(enemyLocation.Y - playerLocation.Y) < distance)
                return true;

            return false;
        }
        public virtual Point Move(Direction direction, Point location, Rectangle boundaries)
        {
            Point newLocation = location;
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
