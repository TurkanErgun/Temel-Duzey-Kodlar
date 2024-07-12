using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinav_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen N sayının ortalamasını bulan uygulama.
            //int N = 0, Top = 0, Sayi = 0;
            //double Ort;
            //Console.Write("Sayıyı Giriniz : ");
            //N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.Write(i + ". Sayı : ");
            //    Sayi = Convert.ToInt32(Console.ReadLine());
            //    Top = Top + Sayi;
            //}
            //Ort = Top / N;
            //Console.WriteLine("Girilen " + N + " Sayının Ortalaması : " + Ort + " ☺☻");
            //Console.ReadKey();

            //Erdi Hocanın Kodu
            int sayi = 0, toplam = 0, N = 0;
            double ortalama;
            Console.Write("Kac sayi girisi yapacaksiniz : ");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write(i + ". sayi : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            ortalama = toplam / N;
            Console.WriteLine("Ortalama : {0}", ortalama);
            Console.ReadKey();
        }
    }
}
