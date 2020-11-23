using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Banking
{
    [Serializable]
    class Guy
    {
       private string Name;
       private long account;
       

       public Guy(string Imie,long stan) { Name = Imie;account = stan; }


        public bool giveMoney(int give) {

            if (AccountInf() < give)
            {
                MessageBox.Show((NameInfo() + " Nie ma tylu pieniędzy na koncie\n"));
                return false;
            }
            else
            {
         
                zmniejszstan(give);
                return true;
            }
        
        }
        public void takeout(int n) {
            try
            {
                MessageBox.Show("Bank zabrał " + n + " zł" + NameInfo() + "owi\n");
                zmniejszstan(n);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                MessageBox.Show("Niedozwolona operacja");
                zmniejszstan(0);
            }
        }
        public void ReciveMoney(int rcv) {


            try
            {
                MessageBox.Show((NameInfo() + " Dostał " + rcv + "\n"));

                dodajstan(rcv);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally { MessageBox.Show("Niedozowlona Operacja"); }
            
           
        }
        public Guy() { }
        private void dodajstan(int x) { account = account + x; }
        private void zmniejszstan(int x) { account = account - x; }
        public string NameInfo() { return Name; }
        public long AccountInf() { return account; }
    }
}
