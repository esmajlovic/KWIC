using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Output
    {
        public void createOutput(List<string> l, string fileName)
        {
            if (File.Exists(fileName + ".txt"))
            {
                File.Delete(fileName + ".txt");
            }
            using (StreamWriter sw = File.CreateText(fileName + ".txt"))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i]);
                }
            }
        }
    }
}
