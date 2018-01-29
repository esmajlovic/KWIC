using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileName;
            string outputFileName;
            Console.WriteLine("The name of the input file is Input");
            Console.WriteLine("The input file name: ");
            inputFileName = Console.ReadLine();
            Console.WriteLine("The output file name: ");
            outputFileName = Console.ReadLine();

            Input input = new Input(inputFileName);
            List<string> inputString = input.readTextFile();
            List<string> outputList = new List<string>();
            List<string> temp = new List<string>();

            for (int i = 0; i < inputString.Count; i++)
            {
                outputList.Add(inputString[i]);
                string[] list = inputString[i].Split(' ');
                temp = new List<string>(list);
                for (int j = 1; j < list.Length; j++)
                {
                    CircularShift cs = new CircularShift();
                    temp = cs.circularShift(temp);
                    outputList.Add(string.Join(" ", temp.ToArray()));
                }
            }
            if (outputList.Count > 0)
            {
                Sort sort = new Sort(outputList);
                sort.SortList();
                Output output = new Output();
                output.createOutput(outputList, outputFileName);
                Console.Write(outputFileName + ".txt has been created.");
            }

            Console.ReadKey();
        }
    }
}
