using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Zapis_odczyt_binarny
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = Int32.MaxValue;
            string stringValue = "Witaj!";
            byte[] array = { 33, 77, 254, 156 };
            float fValue = 988.765F;
            char cValue = 'C';


            using (FileStream output = File.Create("zmiennebinarne.dat"))
           using(BinaryWriter writer =new BinaryWriter(output))
            {
                writer.Write(intValue);
                writer.Write(stringValue);
                writer.Write(array);
                writer.Write(fValue);
                writer.Write(cValue);
                    
            }
            using (FileStream input = File.OpenRead("zmiennebinarne.dat"))
            using (BinaryReader reader = new BinaryReader(input))
            {
                int intRead = reader.ReadInt32();
                string strRead = reader.ReadString();
                byte[] byteRead = reader.ReadBytes(4);
                float fRead = reader.ReadSingle();
                char Cread = reader.ReadChar();

                // byte[] Odczyt = File.ReadAllBytes("zmiennebinarne.dat");
                Console.Write("var int: {0} var string:{1} bajty: ", intRead, strRead);
                foreach (byte x in byteRead)
                {
                    Console.Write("{0} ", x);
                }
                Console.Write(" var float: {0} var char: {1} ",fRead,Cread);

            }
            Console.ReadKey();
        }
    }
}
