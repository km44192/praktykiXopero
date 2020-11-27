using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Security.Permissions;
using System.Security;

namespace kopiowanie
{   [Serializable]
    class Copiing_Operator
    {
       public double size1 { get; set; }
    public  double size2 { get; set; }
        public string d1 { get; set; }
        public string d2 { get; set; }
        public string afi { get; set; }
        public string[] dir1 { get; set; }
        public string[] dir2 { get; set; }
        public bool locked { get; set; }
       public double bfsum { get; set; }
       public ManualResetEvent eventer { get; set; }
       public ProgressBar Postep { get; set; }
      public  RichTextBox cpfiles { get; set; }
       public Label resultLabel { get; set; }
      public  BackgroundWorker backgroundWorker1 { get; set; }



        public Copiing_Operator()
        {
            size1 = 0;
            size2 = 0;
            d1 = "";
            d2 = "";
            afi = "";
        }
        public void Begin()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
               
                backgroundWorker1.RunWorkerAsync();
                resultLabel.Text = "Waiting for response";
            }
        }
        //zatrzymania zadania na chwilę nie działa w 100%
        public void Cancle()
        {

            locked = true;
            resultLabel.Text= "Paused!";
          
        }
        public void WorkOn(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                dir1 = Directory.GetFiles(d1, "*.*", SearchOption.AllDirectories);
                 dir2 = Directory.GetFiles(d2, "*.*", SearchOption.AllDirectories);
                bfsum = Check_Sum(d1);
                MessageBox.Show(bfsum.ToString());
                string Source = d1;
                string Desti = d2;
                for (int i = 0; i < dir1.Length; i++)
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
                        CopyAll(Source, worker, Desti);
                    }
                }
            }
            catch(Exception w)
            {
                throw w;
            }
           
        }
        private void CopyAll(string source, BackgroundWorker worker, string target)
        {
            try
            {
                foreach (string dirpath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
                {
                    if (!Directory.Exists(dirpath.Replace(source, target)))
                        Directory.CreateDirectory(dirpath.Replace(source, target));
                }

                foreach (string newpath in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
                {
                    if (locked == true)
                        eventer.WaitOne();
                    else
                    {
                        // FileInfo tmp1;
                        FileInfo tinfo = new FileInfo(newpath);
                        size2 = size2 + tinfo.Length;
                        int x = (int)((size2 / (size1)) * 50);
                        worker.ReportProgress(x);


                        //warunek sprawdzający czy istnieje

                        if (!File.Exists(newpath.Replace(source, target)))
                        {

                            File.Copy(newpath, newpath.Replace(source, target), true);
                            afi = newpath.Replace(source, target);

                        }

                    }
                }

            }
            catch(Exception e) {
                throw e;
            }
           

        }
        private double Check_Sum(string x)
        {
            double sum = 0;
            foreach (string newpath in Directory.GetFiles(x, "*", SearchOption.AllDirectories))
            {          
                    
                    FileInfo tinfo = new FileInfo(newpath);
               
                    sum = sum + tinfo.Length;  
            }
            return sum;
        }

       public void ProgrssChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
            if (e.ProgressPercentage > 0)
                Postep.Value = (e.ProgressPercentage);
            cpfiles.Text = cpfiles.Text + "\n" + afi;
        }

        //Sprawdzanie postepu
        public void WorkComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text= "Canceled!";
            }
            else if (e.Error != null)
            {
               resultLabel.Text= "Error: " + e.Error.Message;
            }

            else
            {
          //      MessageBox.Show("recived " + Check_Sum(d2).ToString());
                if (bfsum == Check_Sum(d2))
                {
                    resultLabel.Text = "Done!";
                    MessageBox.Show("Skopiowano");
                }
                else
                {
                    resultLabel.Text = "CheckSum_Error";
                }
        //Application.ExitThread();
            }
        }
        public void Resume()
        {
            locked = false;
            eventer.Set();
            resultLabel.Text= "Resumed!";
        }
        public void Get_directories(string t1,string t2)
        {
            d1 = t1;
            d2 = t2;
        }


        public void SaveToFile(Copiing_Operator operat)
        {
            Copiing_Operator worker = new Copiing_Operator()
            {
                size1 = operat.size1,
                size2 = operat.size2,
                d1 = operat.d1,
                d2 = operat.d2,
                dir1 = operat.dir1,
                dir2 = operat.dir2,
                bfsum = operat.bfsum,
            };
            try
            {
                FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.AllAccess, @"D:\json.txt");
                fileIOPermission.Demand();
                string toFile = JsonConvert.SerializeObject(worker);
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;
                if (!File.Exists(@"D:\json.txt"))
                    File.Create(@"D:\json.txt");
                else
                    using (StreamWriter sw = new StreamWriter(@"D:\json.txt"))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, toFile);
                        // {"ExpiryDate":new Date(1230375600000),"Price":0}
                        sw.Close();
                        writer.Close();
                    }
            }
            catch (SecurityException m)
            {
                throw m;
            }
           
        }

    }
 }
            
        
