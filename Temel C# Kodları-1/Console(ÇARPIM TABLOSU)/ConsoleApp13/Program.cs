using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j < 11; j++)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.Write(j + "x" + i + "=" + (j * i) + "\t");// \t amacı tablolu yazması için 

                }
                Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
