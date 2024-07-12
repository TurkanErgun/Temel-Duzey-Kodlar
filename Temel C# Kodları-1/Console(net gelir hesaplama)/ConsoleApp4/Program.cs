using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, ms, mu, tpl;//ay sonunda işçinin eline geçecek net miktar bulma
            char mh, ecd, st;
        basla:
            Console.Clear();
            Console.Write("Maaşı giriniz:");
            m = Convert.ToUInt16(Console.ReadLine());

            Console.Write("mesai saati:");
            ms = Convert.ToInt16(Console.ReadLine());


            Console.Write("1 saatlik mesai ücreti:");
            mu = Convert.ToUInt16(Console.ReadLine());
            tpl = m + ms + mu;
            Console.WriteLine("medeni halinizi giriniz...[E/B]");
            mh = Convert.ToChar(Console.ReadLine());
            if (mh =='E' || mh == 'e')
            {
                Console.WriteLine("eşi herhangi bir görevde çalışıyor mu...[E/H]");
                ecd = Convert.ToChar(Console.ReadLine());
                if (ecd == 'H')
                {
                    tpl = tpl + 8000;
                }
            }
            Console.WriteLine(tpl);
            Console.WriteLine("Devam etmek ister misiniz...[E/B]");
            st = Convert.ToChar(Console.ReadLine());
            if (st=='E' || st == 'e')
            {
                goto basla;
            }
            Console.ReadKey();



        }
    }
}
