using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sesli harfden kaç tane varsa onu yazdıran kod 
            string metin = "";
            Console.WriteLine("Bir Metin İçeriği Giriniz...");
            metin = Console.ReadLine();
            metin = metin.ToLower();
            int sb = 0, sa = 0, se = 0, sı = 0, si = 0, so = 0, sö = 0, su = 0, sü = 0;

            //Console.WriteLine(metin.ToLower());
            //Console.WriteLine(metin.ToUpper());
            for (int i = 0; i < metin.Length; i++)
            {
                switch(metin[i])
                {
                    case 'a':
                        {
                            sa++;
                            break;
                        }
                    case 'e':
                        {
                            se++;
                            break;
                        }
                    case 'ı':
                        {
                            sı++;
                            break;
                        }
                    case 'i':
                        {
                            si++;
                            break;
                        }
                    case 'o':
                        {
                            so++;
                            break;
                        }
                    case 'ö':
                        {
                            sö++;
                            break;
                        }
                    case 'u':
                        {
                            su++;
                            break;
                        }
                    case 'ü':
                        {
                            sü++;
                            break;
                        }
                    case ' ':
                        {
                            sb++;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            Console.WriteLine("a harfinden" + sa + "kadar var");
            Console.WriteLine("e harfinden" + se + "kadar var");
            Console.WriteLine("ı harfinden" + sı + "kadar var");
            Console.WriteLine("i harfinden" + si + "kadar var");
            Console.WriteLine("o harfinden" + so + "kadar var");
            Console.WriteLine("ö harfinden" + sö + "kadar var");
            Console.WriteLine("u harfinden" + su + "kadar var");
            Console.WriteLine("ü harfinden" + sü + "kadar var");
            Console.ReadKey();
        }
    }
}
