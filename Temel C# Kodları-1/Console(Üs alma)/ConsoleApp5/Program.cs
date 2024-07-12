using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int x, top = 1, y, k = 1;// xY x üzeri y yazma işlemi
            Console.WriteLine("x değerini giriniz:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y değerini giriniz:");
            y = Convert.ToInt32(Console.ReadLine());
         basla:
            if (k <= y)
            { top = top * x;
                k++;
                goto basla;
            }
            Console.WriteLine(top);
            Console.ReadKey();

                

        }
    }
}
