using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;
using System.Security.Permissions;
using System.Security;

namespace kopiowanie
{
    public partial class Form2 : Form
    {
       
       

        Copiing_Operator kopi;
        

        public Form2(string x,string y,Copiing_Operator files)
        {
            kopi = files;
            if (kopi.d1 != "" && kopi.d2 != "")
                kopi.Get_directories(kopi.d1, kopi.d2);
            else
                kopi.Get_directories(x, y);
            InitializeComponent();
         
          
            kopi.resultLabel = resultLabel;
            kopi.Postep = Postep;
            kopi.cpfiles = cpfiles;
            kopi.backgroundWorker1 = this.backgroundWorker1;
            InitializeBackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            kopi.eventer = new ManualResetEvent(false);
            kopi.Begin();
        }
   

        private void Cancel_Click(object sender, EventArgs e)
        {
            kopi.SaveToFile(kopi);
            kopi.Cancle();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            kopi.Resume();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
