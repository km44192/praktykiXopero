﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Gra_przygodowa
{
    public enum Direction
    {
        Up,
        Down,
        Right,
        Left,
    }
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game,Point location) {
            this.game = game;
            this.location = location;
        
        }

        public bool Nearby(Point locationToCheck,int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            else
                return false;
            
        }

        public Point Move(Direction direction,Rectangle bounderies)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                
                        if (newLocation.Y - MoveInterval >= bounderies.Top)
                            newLocation.Y -= MoveInterval;
                    break;

                case Direction.Down:
                     if (newLocation.Y + MoveInterval <= bounderies.Bottom)
                        newLocation.Y += MoveInterval;

                    break;
                case Direction.Left:

                    if (newLocation.X - MoveInterval >= bounderies.Left)
                        newLocation.X -= MoveInterval;

                    break;
                case Direction.Right:
                     if (newLocation.Y + MoveInterval <= bounderies.Right)
                        newLocation.Y += MoveInterval;
                    break;
                default:
                    break;
            }
            return newLocation;
        }
    }
}
