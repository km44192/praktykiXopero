using System;
using System.IO;
using System.Text;
namespace hexdump
{
    class Program
    {
        static void Main(string[] args)
        {
           if(args.Length !=1)
            {
                Console.Error.WriteLine("sposób użycia: hexdump plik-do-wyświetlenia");
                System.Environment.Exit(1);

            }
            if (!File.Exists(args[0]))
            {
                Console.Error.WriteLine("Plik nie istnieje {0}", args[0]);
                System.Environment.Exit(2);
            }
            using(Stream input = File.OpenRead(args[0]))
            {
                int position = 0;
                byte[] buffer = new byte[16];
                while(position<input.Length)
                {
                    int charread = input.Read(buffer, 0, buffer.Length);
                    if (charread > 0)
                    {
                        Console.Write("{0} ", String.Format("{0:x4}", position));
                        position += charread;


                        for(int i = 0; i < 16; i++)
                        {
                            if (i < charread)
                            {
                                string hex = String.Format("{0:x2}", (byte)buffer[i]);
                                Console.Write(hex + " ");
                            }
                            else
                                Console.WriteLine(" ");

                            if (i == 7)
                                Console.Write("-- ");
                            if (buffer[i] < 32 || buffer[i] > 250) { buffer[i] = (byte)'.'; }
                        }
                        //      string bufferCont = Encoding.UTF8.GetString(buffer);
                        Console.WriteLine(" ");
                    }
                }




            }
        }
    }
}
