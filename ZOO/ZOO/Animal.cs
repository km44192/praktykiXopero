using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ZOO
{
    class Animal
    {
        public PictureBox Picture;
        public string Food;
        public bool Hunger;
        public int Bounderies;
        public string Location;
      


        virtual public string MakeNoise() { return ""; }
        virtual public string Eat() {
            return "nic";
        }
        public void Sleep() { }
        public void Roam() { }


    }
}
