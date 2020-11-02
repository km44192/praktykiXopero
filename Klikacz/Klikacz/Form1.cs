using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klikacz
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Statystyki staty = new Statystyki();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));

            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Koniec Gry");
                timer1.Stop();
                Start.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                dificultyBar.Value = 800 - timer1.Interval;
                staty.Update(true);
            }
            else
            {
                staty.Update(false);
            }
            correctLabel.Text = "Prawidłowych: " + staty.correct;
            missedStatus.Text = "Błędnych: " + staty.Missed;
            totalLabel.Text = "Wszystkich: " + staty.Total;
            accuracyLabel.Text = "Dokładność: " + staty.accuracy + " %";


        }
        
            

        private void Start_click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer1.Enabled=true;
            timer1.Interval =800;
            Start.Visible = false;
            listBox1.Focus();
        }
    }
}
