using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Banking
{
    class Guy
    {
       private string Name;
       private long account;

       public Guy(string Imie,long stan) { Name = Imie;account = stan; }


        public void giveMoney(int give) {

            if (AccountInf() < give)
            {
                MessageBox.Show((NameInfo() + " Nie ma tylu pieniędzy na koncie\n"));
            }
            else
            {
                MessageBox.Show((NameInfo() + " Dał " + give + " zł\n"));
                zmniejszstan(give);
            }
        
        }
        public void takeout(int n) { MessageBox.Show("Bank zabrał " + n + " zł" + NameInfo() + "owi\n"); zmniejszstan(n); }
        public void ReciveMoney(int rcv) {
            MessageBox.Show((NameInfo()+" Dostał "+rcv+"\n"));
            dodajstan(rcv);
        }
        public Guy() { }
        private void dodajstan(int x) { account = account + x; }
        private void zmniejszstan(int x) { account = account - x; }
        public string NameInfo() { return Name; }
        public long AccountInf() { return account; }
    }
}
