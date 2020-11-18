using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Gra_przygodowa
{
   abstract class Enemy:Mover
    {
        private const int NearPlayerDistance = 25;

        public int HitPoints { get; private set; }
        public bool Dead { get { if (HitPoints <= 0) return true; else return false; } }
    
    
    public Enemy(Game game,Point location,int hitPoints) : base(game, location) { this.HitPoints = hitPoints; }
        public abstract void move(Random random);
        public void Hit(int maxDamege,Random random)
        {
            HitPoints -= random.Next(1, maxDamege);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y + 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
    }
}
