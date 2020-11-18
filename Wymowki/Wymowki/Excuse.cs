using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Wymowki
{[Serializable]
    class Excuse
    {

        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }
        public Excuse()
        {
            ExcusePath = "";

        }
        public Excuse(string path)
        {
            OpenFile(path);
        }
        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }
        private void OpenFile(string path)
        {
            ExcusePath = path;
            using (StreamReader reader = new StreamReader(path))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        private void Save(string pathName)
        {
            using(StreamWriter writer =new StreamWriter(pathName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }
    }

}
