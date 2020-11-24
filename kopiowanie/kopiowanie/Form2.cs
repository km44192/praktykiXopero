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
       double  size1 = 0;
        double size2 = 0;
        
        private string d1 = "";
        private string d2 = "";
        private string afi = "";
        private string[] dir1;
        private string[] dir2;
        private bool locked = false;
        ManualResetEvent eventer;

        public Form2(string x,string y)
        {
            d1 = x;
            d2 = y;
            InitializeComponent();
            InitializeBackgroundWorker();
            startAsyncButton_Click();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            eventer = new ManualResetEvent(false);
            
        }
       

        //Rozpoczęcie kopiowania
        private void startAsyncButton_Click()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                resultLabel.Text = "Waiting for response";
                backgroundWorker1.RunWorkerAsync();
            }
           
        }
        //zatrzymania zadania na chwilę nie działa w 100%
        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Paused!";
            locked = true;
          
    
            
        }
      


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            BackgroundWorker worker = sender as BackgroundWorker;
             dir1 = Directory.GetFiles(d1, "*.*", SearchOption.AllDirectories);
             dir2 = Directory.GetFiles(d2, "*.*", SearchOption.AllDirectories);
          
        string Source = d1;
            string Desti = d2;

          
           
            for(int i = 0; i < dir1.Length; i++)
            {
                FileInfo finfo = new FileInfo(dir1[i]);
                size1 = size1 + finfo.Length;
            }
          

            
           

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
             
                    if(!Directory.Exists(dirpath.Replace(source,target)))
                    Directory.CreateDirectory(dirpath.Replace(source, target));
            }
    
            // Copy each subdirectory using recursion.
            foreach (string newpath in Directory.GetFiles(source,"*",SearchOption.AllDirectories))
            {   if (locked == true)
                    eventer.WaitOne();
                else
                {
                    FileInfo tmp1;
                    FileInfo tinfo = new FileInfo(newpath);
                    size2 = size2 + tinfo.Length;
                    int x = (int)((size2 / (size1)) * 50);
                    worker.ReportProgress(x);
                    //    MessageBox.Show((size2 / size1).ToString());

                    //warunek sprawdzający czy istnieje
                    //  MessageBox.Show(target.Contains(newpath.Replace(source, target)).ToString());
                    if (!File.Exists(newpath.Replace(source, target)))
                    {

                        File.Copy(newpath, newpath.Replace(source, target), true);
                        afi = newpath.Replace(source, target);

                    }
                    else
                    {
                      //  tmp1 = new FileInfo(newpath.Replace(source, target));
                        //if (tinfo.Length == tmp1.Length)
                          //  afi = newpath.Replace(source, target) + "...skipped";

                    }
                }
              
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
                //Application.ExitThread();
            }
        }

        private void startAsyncButton_Click(object sender, EventArgs e)
        {
            locked = false;
            eventer.Set();
            resultLabel.Text = "Resumed!";
        }
    }
}
