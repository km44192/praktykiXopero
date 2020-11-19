using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Gra_przygodowa
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;

        public int HitPoints { get; private set; }
        public bool Dead { get { if (HitPoints <= 0) return true; else return false; } }


        public Enemy(Game game, Point location, int hitPoints) : base(game, location) { this.HitPoints = hitPoints; }
        public abstract void Move(Random random);
        public void Hit(int maxDamege, Random random)
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

    class Bat:Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        {

        }
        public override void Move(Random random)
        {
           int mv = random.Next(0, 1);
         if(mv==1 && this.HitPoints>1)
            {if (NearPlayer())
                    game.HitPlayer(2, random);
                else
                {
                    Move(FindPlayerDirection(game.PlayerLocation), game.Bounderies);
                }
            }
            else
            {
                Move((Direction)random.Next(4), game.Bounderies);

            }
        }


    }
    class Ghost:Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {

        }
        public override void Move(Random random)
        {
                int mv = random.Next(0, 3);
                if (mv == 1 && this.HitPoints > 0)
                {
                    if (NearPlayer())
                        game.HitPlayer(3, random);
                    else
                    {
                        Move(FindPlayerDirection(game.PlayerLocation), game.Bounderies);
                    }
                }
            
        }

    }
    class Ghul : Enemy
    {
        public Ghul(Game game,Point Location) : base(game, Location, 10) { }

        public override void Move(Random random)
        {
            if (this.HitPoints > 0) { 
                int mv = random.Next(0, 3);
                if (mv == 1 || mv == 2)
                {
                    if (NearPlayer())
                        game.HitPlayer(4, random);
                    else
                    {
                        Move(FindPlayerDirection(game.PlayerLocation), game.Bounderies);
                    }
                }
                else
                {
                    Move((Direction)random.Next(4), game.Bounderies);

                }
            }
        }
    }
}
