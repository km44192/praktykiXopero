using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Wlepy[] biegacz = new Wlepy[3];

        private void move(int index,Label info)
        {
            if (biegacz[index] == null) { biegacz[index] == new Wlepy();
           biegacz}


        }

    }
}
