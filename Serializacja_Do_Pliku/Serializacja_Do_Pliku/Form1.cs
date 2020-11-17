using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace Serializacja_Do_Pliku
{ /// <summary>
/// Nie da się dokonać serializacji z powodu istnienia w kodzie funkcji random, która totże zostałą wyłączona z bibliotek uprawnionych do tejże funckji
/// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
  
        private Deck RandomDeck(int ile)
        {
            Random random = new Random();
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 1; i < ile; i++)
            {
                myDeck.Add(new Card(
                    (Suits)random.Next(4),
                (Values)random.Next(1, 14)
                    ));

            }
            return myDeck;

        }
        private void DealCards(Deck deckToDeal, string Title)
        {
            MessageBox.Show(Title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);

            }
            Console.WriteLine("-----------------------");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Deck decktoWrite = RandomDeck(5);
            using (Stream output = File.Create("Zestaw1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, decktoWrite);

            }
            DealCards(decktoWrite, "Zapisałem do pliku");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deck deckFromFile;
            using (Stream input = File.OpenRead("Zestaw1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                deckFromFile = (Deck)bf.Deserialize(input);
                DealCards(deckFromFile, "Odczytano z pliku");
            }


        }
    
    }



    
       

  
}
