using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Gra_Przygodowa_poprwiony
{
    class Player:Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();
        public ICollection<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }


        public Player(Game game,Point location):base(game,location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage,Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health,Random random)
        {
            HitPoints += random.Next(1, health);
        }
        public void Equip(string weaponName)
        {
            equippedWeapon = game.WeaponInRoom;

            if(!inventory.Contains(game.WeaponInRoom))
            inventory.Add(game.WeaponInRoom);
          
        }
        public void Move(Direction direction)
        {
            
            if (!game.WeaponInRoom.PickedUp)
            {
                base.location = Move(direction, game.Bounderies);
            }
            else
            {
                base.location = Move(direction, game.Bounderies);
                game.WeaponInRoom.Move(direction, game.Bounderies);
            }
        }
        public void Attack(Direction direction,Random random)
        {
            foreach(Weapon weapon in inventory)
            {
               if(weapon==equippedWeapon)
                    weapon.Attack(direction, random);
            }

        }
    }
}
