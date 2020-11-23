using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace kopiowanie
{
    public partial class Form2 : Form
    {
        public int size1 = 0;
        public int size2 = 0;
        public  long c = 0;
        private string d1 = "";
        private string d2 = "";
        private string afi = "";
        public Form2(string x,string y)
        {
            d1 = x;
            d2 = y;
            InitializeComponent();
            InitializeBackgroundWorker();
            startAsyncButton_Click();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            
        }
       


        private void startAsyncButton_Click()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
           
        }

        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
             
                backgroundWorker1.CancelAsync();
            }
        }
       
     
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            BackgroundWorker worker = sender as BackgroundWorker;

            string Source = d1;
            string Desti = d2;
    
            string[] a = Directory.GetFiles(d1, "*.*",SearchOption.AllDirectories);
    
            for(int i = 0; i < a.Length; i++)
            {
                size1 =size1+ a[i].Length;
            }
            

            
            

            MessageBox.Show(size1.ToString());
            MessageBox.Show(size2.ToString());
            while (size1 >= size2)
            {
              
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
               
                    CopyAll(Source,worker, Desti);
                   
                    
                }

            }
            
        }
        private void CopyAll(string source,BackgroundWorker worker,string target)
        {

            // Copy each file into the new directory.
            foreach (string dirpath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
            {
                
                Directory.CreateDirectory(dirpath.Replace(source, target));
            }

            // Copy each subdirectory using recursion.
            foreach (string newpath in Directory.GetFiles(source,"*",SearchOption.AllDirectories))
            {


                afi = newpath;
                size2 = size2 + newpath.Length;
                worker.ReportProgress((size2*50)/ size1);
               
                File.Copy(newpath, newpath.Replace(source, target), true);

        
            }
        
        
        
        
        
        }






        // Aktuualizacja postępu
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
            if(e.ProgressPercentage>0)
            Postep.Value = (e.ProgressPercentage);
            cpfiles.Text = cpfiles.Text + "\n" + afi;
        }

        //Sprawdzanie postepu
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                resultLabel.Text = "Done!";
                MessageBox.Show("Skopiowano");
                Application.Exit();
            }
        }

      
    }
}
