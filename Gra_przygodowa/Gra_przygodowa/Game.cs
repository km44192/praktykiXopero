using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Gra_przygodowa
{
    class Game
    {
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }



        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        private int level = 0;
        public int Level { get { return level; } }
        private Rectangle bounderies;
        public Rectangle Bounderies { get { return bounderies; } }


        public Game(Rectangle bounderies)
        {
            this.bounderies = bounderies;
            player = new Player(this, new Point(bounderies.Left + 10, bounderies.Top + 70);
        }
        public void Move(Direction direction,Random random)
        {
            player.Move(direction);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }
        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }
        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }
        public void HitPlayer(int maxDamage,Random random)
        {
            player.Hit(maxDamage, random);
        }
        public void IncreasePlayerHealth(int health,Random random)
        {
            player.IncreaseHealth(health, random);
        }
        public void Attack(Direction direction,Random random)
        {
            player.Attack(direction, random);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(bounderies.Left+random.Next(bounderies.Right/10-bounderies.Left/10)*10, bounderies.Top + random.Next(bounderies.Bottom / 10 - bounderies.Top / 10) * 10);
        }
        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat, GetRandomLocation(random));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));

                    break;
            }
        }
    }
}
