using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LumberJack
{
    public enum Flapjack
    {
        Chrupkiego,
        Wilgotnego,
        Rumianego,
        Bananowego

    }

    class Lumberjack
    {
        private string name;
        public string Name {get {return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food,int howMany)
        {
            for (int i = 1; i <= howMany; i++)
                meal.Push(food);

        }
        public void EatFlapjacks()
        {
            while (meal.Count != 0)
            {
                
              MessageBox.Show(Name + "zjadł " + meal.Peek() + " naleśnika");
                meal.Pop();
            }
        }
    }
}
