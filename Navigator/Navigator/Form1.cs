using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navigator
{
    public partial class Form1 : Form
    {
        Navigator Trasa = new Navigator();
        House Budynek = new House();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void kalkuluj_Click(object sender, EventArgs e)
        {
            if (Avoid.Text == "") {
                Trasa.SetDestination(celPodróży.Text); Trasa.TotalDistance();
            }
            else { Trasa.SetDestination(celPodróży.Text);Trasa.TotalDistance(); Trasa.ModifyRouteToAvoid(Avoid.Text); }
            MessageBox.Show(Trasa.GetRoute());
            dystans.Text ="Przewidywany dystans "+Trasa.route+" km";
        }
    }
}
