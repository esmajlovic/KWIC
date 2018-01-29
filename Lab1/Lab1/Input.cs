using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Input
    {
        private string fileName;
        public Input(String fileName)
        {
            this.fileName = fileName;
        }

        public List<string> readTextFile()
        {
            List<string> l = new List<string>();
            string line;
            if (File.Exists(fileName + ".txt"))
            {
                StreamReader file = new StreamReader(fileName + ".txt");
                while (true)
                {
                    line = file.ReadLine();
                    if (line == null) break;
                    l.Add(line);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Invalid Input File");
            }
            return l;
        }
    }
}
