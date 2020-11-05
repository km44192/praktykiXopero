using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planowanie_przyjęcia
{
    public partial class Form1 : Form
    {
        DinnerParty Impreza=new DinnerParty();
        public Form1()
        {
            InitializeComponent();
           
        
        }
        
        
        private void fit_CheckedChanged(object sender, EventArgs e)
        {

            Impreza.fit = fit.Checked;
            kwota.Text = Impreza.KosztImprezy(fit.Checked).ToString("c");
        }

        private void deco_CheckedChanged(object sender, EventArgs e)
        {
            Impreza.deco = deco.Checked;
            kwota.Text = Impreza.KosztImprezy(fit.Checked).ToString("c");

        }

        private void kwota_Click(object sender, EventArgs e)
        {
            Impreza.Partyamm((int)IleGosci.Value);
         
            kwota.Text = Impreza.KosztImprezy(fit.Checked).ToString("c");
        }
    }
}
