using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)//20 den küçük sayıları ekraana yazdırıyo
        {
            int a = 10;
            Console.WriteLine("while Döngüsü");
            while(a<20)
            {
                Console.WriteLine("a:" + a);
                a++;
            }
            Console.WriteLine("For Döngüsü");
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine("a:"+i);
            }
            Console.WriteLine("Do While Döngüsü");
            do
            {
                Console.WriteLine("a:" + a);
            }
            while (a < 20);
            Console.ReadKey();
        }   
        
       
    }
    
}
