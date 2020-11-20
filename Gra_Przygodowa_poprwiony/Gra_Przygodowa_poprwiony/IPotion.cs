using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Gra_Przygodowa_poprwiony
{
    public interface IPotion
    {
        bool Used { get; }
    }
        class Blue_Potion:Weapon,IPotion
        {
             public bool Used { get; }
             public override string Name { get {return "BEliksir"; } }
        
             public Blue_Potion(Game game,Point location) : base(game, location) {
                 Used = false;
             }
                public override void Attack(Direction direction,Random random)
                {
                if(Used)
                game.IncreasePlayerHealth(5, random);
                 }

        }

    class Red_Potion : Weapon, IPotion
    {
        public bool Used { get; }
        public override string Name { get { return "Heal"; } }

        public Red_Potion(Game game,Point location) : base(game, location)
        {
            Used = false;
        }
       
        public override void Attack(Direction direction, Random random)
        {
            if (Used)
                game.IncreasePlayerHealth(10, random);
        }
    }
}
