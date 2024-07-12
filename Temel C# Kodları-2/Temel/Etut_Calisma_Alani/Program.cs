using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//kütüphane dosya aç

namespace Etut_Calisma_Alani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GİRİLEN 2 TAM SAYININ TOPLAMINI EKRANA YAZDIRAN PROGRAM
            //int x, y, top;
            //Console.Write("1. Sayıyı Giriniz: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //y = Convert.ToInt32(Console.ReadLine());
            //top = x + y;
            //Console.WriteLine(x + " + " + y + " = " + top);

            //GİRİLEN 1 SAYININ %25 İNİ BULUP EKRANA YAZDIRAN PROGRAM
            //int x;
            //double sonuc;
            //Console.Write("Sayıyı Giriniz: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //sonuc = x / 4;
            //Console.WriteLine(x + " Sayısının %25'i " + sonuc + " dir");

            //GİRİLEN SAYİ 3'E VE 5'E TAM BÖLÜNÜYOR İSE EKRANA "TAM BÖLÜNÜR", BÖLÜNMÜYOR İSE EKRANA "TAM BÖLÜNMEZ" YAZAN PROGRAM
            //int X;
            //Console.Write("Sayı Girişi Yapınız: ");
            //X = Convert.ToInt32(Console.ReadLine());
            //if (X % 3 == 0 && X % 5 == 0)
            //    Console.WriteLine(X + " Sayısı 3 ve 5'e Tam Bölünür");
            //else
            //if (X % 3 != 0 && X % 5 != 0)
            //    Console.WriteLine(X + " Sayısı 3 ve 5'e Tam Bölünmez");

            //GİRİLEN 2 SAYIYI TOPLAYIP, ÇIKARIP, ÇARPIP, BÖLEN PROGRAM
            //double x, y, top, cikar, carp, bol;
            //Console.Write("1. Sayıyı Giriniz: ");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //y = Convert.ToDouble(Console.ReadLine());
            //top = x + y;
            //cikar = x - y;
            //carp = x * y;
            //bol = x / y;
            //Console.WriteLine(x + " ve " + y + " sayılarının toplamı " + top);
            //Console.WriteLine(x + " ve " + y + " sayılarının farkı " + cikar);
            //Console.WriteLine(x + " ve " + y + " sayılarının carpımı " + carp);
            //Console.WriteLine(x + " ve " + y + " sayılarının bolumu " + bol);

            //Console.ReadKey();

            //etiket:
            //byte s1 = 0, s2 = 0, s3 = 0; // HATA OLMA DURUMUNDA
            //try
            //{
            //    Console.Clear();
            //    Console.Write("Bir sayı giriniz: ");
            //    s1 = Convert.ToByte(Console.ReadLine());
            //    Console.Write("2. Sayıyı giriniz: ");
            //    s2 = Convert.ToByte(Console.ReadLine());
            //    s3 = Convert.ToByte(s1 / s2);
            //    Console.WriteLine(s3);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Sayıyı Sıfıra Bölünmez..");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Program Tekrar Kendini Yeniledi ");
            //}
            ////goto etiket;
            //Console.ReadKey();

            //using system 10 ekledik !!!!!!!!!!!!!!!!!!!!1

            //FileStream f = new FileStream("ybs.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //for (byte i = 0; i < 20; i++)
            //{
            //    f.WriteByte(i);
            //}
            //f.Position = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(f.ReadByte());
            //}
            //Console.ReadKey();


            //string[] isimler = new string[] { "istanbul", "düzce", "bolu", "bartın" };
            //using (StreamWriter sw = new StreamWriter("D:/at.txt"))
            //{
            //    foreach (var isim in isimler)
            //    {
            //        sw.WriteLine(isim);
            //    }
            //}
            //Console.ReadKey();



        }
    }
}
