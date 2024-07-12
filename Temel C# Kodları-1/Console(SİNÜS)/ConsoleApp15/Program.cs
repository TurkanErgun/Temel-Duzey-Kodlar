using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)//SİNUS KULLANARAK YAPILAN KOD 
        {
            double s = 2;
            int i = 1;
            do
            {
                s = s + 0.1;
                i++;
                Console.SetCursorPosition(i, (byte)(Math.Round(30 * Math.Sin(s)) + 49));
                Console.Write("AKMYO");
                System.Threading.Thread.Sleep(100);//YAZIYI EKRANA SAYI DEĞERİ VERİP HIZINI AYARLAR
            }
            while (i < 100);
            Console.ReadKey();
        }
    }
}
