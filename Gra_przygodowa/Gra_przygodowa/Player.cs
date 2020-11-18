using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Gra_przygodowa
{
    class Player:Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
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
            foreach(Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }
        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Bounderies);
            if (!game.WeaponInRoom.PickedUp)
            {

            }
        }
    }
}
