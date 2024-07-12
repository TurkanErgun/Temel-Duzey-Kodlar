using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizideki tek sayıları,tek sayıların toplamını ve tek sayıların ort bulan program ilk 3,7,8,12,13,14
            //yazılan sayıdan küçük sayıların veren koddur ilk 7,8,11
            //sayı kaçsa syıyı o kadar yazdıran koddur 7 ye kadar ve 10,11,15 açık olunca çalışır
            int[] a = new int[] { 4, 8, 3, 1, 18, 9, 21, 20, 5, 17, 81 };
          //  int count = 0;
           // int T_tpl = 0;
           // int sayi;
            //Console.WriteLine("Bir sayı giriniz..");
            //sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a.Length; i++)
            {
                //if (a[i]<sayi)
                if (a[i] %2 == 2)
                //for (int j = 0; j < a[i]; j++)
                //{
                    //Console.Write(a[i] + ",");
                    Console.WriteLine(a[i]);
                    //count = count + 1;
                    //T_tpl = T_tpl + a[i];
                //}
                //Console.WriteLine();
            }
           // Console.WriteLine(" Ne kadar  msayı dizide bulunmaktadır = " + count );
            //Console.WriteLine("dizideki tek sayıların ortalaması = " + (T_tpl / count));
           // Console.WriteLine("dizideki tek sayıların toplamı = " + T_tpl);
            Console.ReadKey();
        }
    }
}
