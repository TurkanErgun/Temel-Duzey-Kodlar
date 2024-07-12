using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, top = 1, k = 1;//Faktöriyel alma örneği
            Console.WriteLine("Sayı giriniz:");
            x = Convert.ToInt32(Console.ReadLine());
            e1:
            if (k <= x)
            { top = top * k;
                k++;
                goto e1;
            }
            Console.WriteLine(top);
            Console.ReadKey();
        }
    }
}
