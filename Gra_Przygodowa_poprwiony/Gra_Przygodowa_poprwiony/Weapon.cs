using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Gra_Przygodowa_poprwiony
{//pamiętaj aby dokończyć
   abstract class Weapon:Mover
    {
        public bool PickedUp;
       
        public Weapon(Game game,Point locatin) : base(game, locatin)
        {
            PickedUp = false;
        }
        public void PickUpWeapon() { PickedUp = true; }
        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);
         public bool Nearby(Point location,Point Plocation,int distance)
        {
            if (Math.Abs(location.X - Plocation.X) < distance && Math.Abs(location.Y - Plocation.Y) < distance)
            {
               
                return true;
            }
            else
                return false;
        }
        public Point Move(Direction direction,Point target,int distance)
        {
            this.location.X = target.X;
            this.location.Y = target.Y;
            return location;
        }

        protected bool DamageEnemy(Direction direction,int radius,int damage,Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance = 0; distance < radius; distance++)
            {
                foreach(Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, distance);
            }
            return false;
        }
    }



    class Sword : Weapon 
    {
        public  Sword(Game game,Point location) : base(game, location)
        {

        }
        public override string Name { get{ return "Miecz"; } }
        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 10, 3, random))
            {

                if (!DamageEnemy(direction + 1, 10, 3, random))
                {
                    if (!DamageEnemy((direction - 1), 10, 3, random))
                    { }
                    else
                        DamageEnemy((direction - 1), 10, 3, random);
                }
                else
                    DamageEnemy(direction + 1, 10, 3, random);
            }
            else
                DamageEnemy(direction, 10, 3, random);


        }

    }
    class Bow : Weapon
    {
        public Bow(Game game,Point location) : base(game, location) { }
        public override string Name { get{ return "Łuk"; } }

        public override void Attack(Direction direction, Random random)
        {
            if (DamageEnemy(direction, 30, 1, random))
            {
                DamageEnemy(direction, 30, 1, random);
            }
        }
    }

    



}
