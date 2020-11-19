using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziedziczenie_Ul
{
    public partial class Form1 : Form
    {
        public Random random = new Random();
        private Krolowa krolowa;
        private StingPatrol s;
        public Form1()
        {
            InitializeComponent();
            prace.Items.Add("Zbieranie Nektaru");
            prace.Items.Add("Wytwarzanie miodu");
            prace.Items.Add("Pielegnacja jaj");
            prace.Items.Add("Nauczanie pszczółek");
            prace.Items.Add("Utrzymanie ula");
            prace.Items.Add("Patrol z żądłami");
            //rozdział 7 interfejsy
            IWorker[] Pszczoly = new IWorker[3];
            Pszczoly[0] = new NectarStinger(new string[] { "Zbieranie Nektaru", "Wytwarzanie miodu", "Patrol z żądłami" }, 175);
            Pszczoly[1] = new RoboBee();
            Pszczoly[2] = new Robotnica(new string[] { "Zbieranie Nektaru", "Wytwarzanie miodu", "Pielegnacja jaj", "Nauczanie pszczółek", "Utrzymanie Ula", "Patrol z żądłami" }, 100) as IWorker;


            for(int i = 0; i < Pszczoly.Length; i++) { 
                if(Pszczoly[i] is INectarCollector) 
                { 
                    INectarCollector thisCollector;
                    thisCollector = Pszczoly[i] as INectarCollector;
                    thisCollector.GatherNectar();
                }
            }
            //---------------
            StingPatrol guard = new StingPatrol(new string[] { "Patrol z żądłami" } , 200);
            Robotnica[] robotnice = new Robotnica[5];
            PrzypiszPrace.TabIndex = 0;
            robotnice[0] = new Robotnica(new string[] { "Zbieranie Nektaru", "Wytwarzanie miodu" }, 175);
            robotnice[1] = new Robotnica(new string[] { "Pielegnacja jaj", "Nauczanie pszczółek" }, 114);
            robotnice[2] = new Robotnica(new string[] { "Utrzymanie Ula", "Patrol z żądłami" }, 149);
            robotnice[3] = new Robotnica(new string[] { "Zbieranie Nektaru", "Wytwarzanie miodu", "Pielegnacja jaj", "Nauczanie pszczółek", "Utrzymanie ula", "Patrol z żądłami" }, 155);
            robotnice[4] = guard;
          
            Krolowa królowa = new Krolowa(robotnice, 275);

            krolowa = królowa;
            s = guard;
        }
        
     

        private void WorkNextShift_Click(object sender, EventArgs e)
        {
            report.Text = krolowa.WorkTheNextShift(); s.Sting(random);
        }

        private void PrzypiszPrace_Click(object sender, EventArgs e)
        {
            if (krolowa.AssignWork(prace.Text, (int)numerPszczoły.Value) == false)
                MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania " + PrzypiszPrace.Text + ",", " Królowa pszczół mówi...");
            else
                MessageBox.Show("Zadanie " + PrzypiszPrace.Text + " będzie ukończone za " + numerPszczoły.Value + " zmiany ", " Królowa Pszczół mówi...");

        }
    }
}
