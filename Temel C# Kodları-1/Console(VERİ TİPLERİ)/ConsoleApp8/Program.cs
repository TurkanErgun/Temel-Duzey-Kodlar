using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 0;
            bool condition = false;
            char character = 'A';
            double number5 = 10.4;
            decimal number6 = 10.4m;
            var number7 = 10;
            number7 = 'A';
            //number7 = "A"; YANLIŞTIR VAR DA NEYLE BAŞLADIYSAN ONLA DEVAM EDERSİN
            Console.WriteLine("number1 is {0}", number1);
            Console.WriteLine("number2 is {0}", number2);
            Console.WriteLine("number3 is {0}", number3);
            Console.WriteLine("number4 is {0}", number4);
            Console.WriteLine("character is : {0}", (int)character);
            Console.WriteLine("number5 is {0}", number5);
            Console.WriteLine("number6 is {0}", number6);
            Console.WriteLine("number7 is {0}", number7);
            Console.WriteLine((int)days.Friday);
            Console.WriteLine("Bu Sayılar Sınır Sayılarıdır İnt,Long,Short,Byte Veri Tiplerinin");
            Console.ReadLine();


        }
            enum days
            {  
               Mondey,Tuesday, Wendnesday, Thursday, Friday, Saturday, Sunday
            }
                  
        
    }
     

         

}
