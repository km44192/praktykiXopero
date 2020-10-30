using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Powtarzanie_slow
{
    class gadacz
    {
        public static int papuga(string text, int ilepowt)
        {
            string text1 = "";

            for (int i = 1; i <= ilepowt; i++)
            {
                text1 = text1 + text + "\n";


            }
            MessageBox.Show(text1);
            return text1.Length;

        }

    }
}
