using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma_alanı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen Vize ve Final notlarının ortalaması ekrana yazdıran uygulama.
            int V, F, Ort;
        etiket:
            Console.Clear();
            Console.Write("Vize Notunuzu Giriniz : ");
            V = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Final Notunuzu Giriniz : ");
            F = (Convert.ToInt32(Console.ReadLine()));

            Ort = (Convert.ToInt32(V * 0.4 + F * 0.6));

            Console.WriteLine("Ortalamanız : " + Ort + "");

            if (Ort >= 50)
                Console.WriteLine("GEÇTİ");
            else
                Console.WriteLine("BAŞARISIZ");

            Console.ReadKey();


            //1'den 10'a kadar olan sayıların toplamını ekrana yazdıran uygulama.
            //    int T = 0, S = 0;
            //git:
            //    T = T + S;
            //    S = S + 1;
            //    if (S <= 10)
            //        goto git;
            //    Console.WriteLine(T);
            //    Console.ReadKey();



            //GİRİLEN 3 SAYININ TOPLAMINI YAZAN UYGULAMA
            //int x, y, z,sonuc;
            //Console.Write("1. Sayı : ");
            //x=Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayı : ");
            //y=Convert.ToInt32(Console.ReadLine());
            //Console.Write("3. Sayı : ");
            //z=Convert.ToInt32(Console.ReadLine());

            //sonuc = x + y + z;
            ////Console.Write(x+" + "+y+" + "+z+" = "+sonuc);
            ////Console.Write("Girdiğiniz " + x + ", " + y + " ve " + z + " Sayılarının Toplamı : "+sonuc);
            //Console.WriteLine("Girdiğiniz {0}, {1} ve {2} Sayılarının Toplamı = {3}",x,y,z,sonuc);
            //Console.ReadKey();


            //GİRİLEN 3 SAYININ HANGİSİNİN BUYUK OLDUGUNU YAZAN UYGULAMA



        }
    }
}
