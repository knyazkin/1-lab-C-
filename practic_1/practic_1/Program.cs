using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibLab1;

namespace practic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\TestLogs";
            string inputFileName = "input.txt";
            string outputFileName = "output.txt";
            string text = Lab1.input(path, inputFileName);
            System.Console.WriteLine(text);
            string str = Lab1.EditString(text);
            System.Console.WriteLine(str);
            Lab1.output(path, outputFileName, str);
            str = System.Console.ReadLine();
        }


    }
}
