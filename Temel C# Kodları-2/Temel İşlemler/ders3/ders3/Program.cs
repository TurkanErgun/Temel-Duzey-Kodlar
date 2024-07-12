using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekranda girilen N sayısına kadar olan ASAL sayıların ekrana yazdıran uygulama.
            int N,Top;
            bool asal;
            Console.WriteLine("Asal sayı Yazdırma Sınırını giriniz");
            N = Convert.ToInt32(Console.ReadLine());
            if (N == 2)
            {
                Console.WriteLine(2);
            }
            else
            {
                for (int k = 2; k <= N; k++)
                {
                    asal = true;
                    for (int y = 2; y <= (k - 1); y++)
                    {
                        if (k % y == 0)
                        {
                            asal = false;
                            break;//DÖNGÜDEN ÇIKMAK İÇİN YAZILDI
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (asal == true)
                    {
                        Console.WriteLine(k);
                        Top = Top + k;
                        continue;
                    }
                    else
                    {
                        continue;//DÖNGÜ BAŞINA GİTMEK İÇİN
                    }
                }

            }
            Console.WriteLine(N+ "Kadar Olan ASAL Satıların Toplamı = " );

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i==50)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine((i + 1) + ": DÜZCE ÜNİVERSİTESİ");
            //}

            //////GOTO YETERSİZ KALMAKTA
            //int N;
            //Console.WriteLine("Asal sayı Yazdırma Sınırını giriniz");
            //N=Convert.ToInt32(Console.ReadLine());
            //if(N==2)
            //{
            //    Console.WriteLine(2);
            //}
            //else
            //{
            //    int k = 3;
            //    if(k<=N)
            //    {
            //        asal = true;
            //        int y = 2;
            //        if(y<=(k-1))
            //        {
            //            if((k%y)==0) 
            //            {

            //            }
            //        }
            //    }
            //}
            //////GOTO YETERSİZ
            Console.ReadKey();
        }
    }
}
