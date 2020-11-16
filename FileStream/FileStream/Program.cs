using System;
using System.IO;

namespace filestream
{
    class Program
    {
        static void Main(string[] args)
        { //StreamWriter x = new StreamWriter(@"C:\\Users\\dak10\\desktop\\pliczek.txt",true);
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamReader reader = new StreamReader(folder + @"\plany.txt");
            StreamWriter writer = new StreamWriter(folder + @"\specialmessage.txt");
          
            writer.WriteLine("To: xxxxx@zut.edu.pl");
            writer.WriteLine("From: dakxxxx0@o2.pl");
            writer.WriteLine("Subject: Tajna przesyłka");
            writer.WriteLine();
            writer.WriteLine("znaleźliśmy złoty pociąg");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                writer.WriteLine("Plan ->" + line);
            }
            writer.WriteLine();
            writer.WriteLine("Czy można pomóc?");
            writer.Close();
            reader.Close();
            //x.Write(ananas);
            //x.Close();

            
         //   Console.WriteLine("Hello World!");
        }
    }
}
