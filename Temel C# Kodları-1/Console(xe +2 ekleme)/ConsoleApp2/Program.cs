using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;//x e +2 ekleme
           etiket:
            Console.WriteLine(x);
            x = x + 2;
            if (x <= 10)
                goto etiket;
            Console.ReadKey();
        }
    }
}
