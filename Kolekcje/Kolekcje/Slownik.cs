using System;
using System.Collections.Generic;
using System.Text;

namespace Kolekcje
{
    class Slownik
    {
        public Dictionary<string, string> słownik;

        public Slownik()
        {
            słownik = new Dictionary<string, string>();
            słownik.Add("Słownik", "zbiór wyrazów ulożonych i opracowanych według pewnej zadady,zwykle objaśnionych pod względem znaczeniowym");
            słownik.Add("Klucz", "metoda lub rzecz pozwalająca na osiągnięcie lub zrozumienie czegoś");
            słownik.Add("Wartość", "liczba określająca ile jednostek zawiera dana wielkosć fizyczna lub wielkośc mogąca zastąpić wyrazenia algebraiczne");


        }

     
    }
}
