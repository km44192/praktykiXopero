using System.Reflection.Emit;
using System.Windows.Forms;
namespace Wyścig
{
    class Wlepy
    {
        public System.Windows.Forms.Label MyLabel;


        public bool goingForward = true;

        public void move() { 
            if(MyLabel != null) 
            {
                if (goingForward == true) {
                    MyLabel.Left += 5;
                    if(MyLabel.Left >- MyLabel.Parent.Width - MyLabel.Width) { goingForward = false; }
                
              
                }            
            }
            else { MyLabel.Left -= 5;
            if(MyLabel.Left <= 0) { goingForward = true; }
            }
        
        
        }
    }
}
