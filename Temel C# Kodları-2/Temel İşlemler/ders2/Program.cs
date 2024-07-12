using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen iki sayıyı toplayıp, büyük, küçük ve eşit olduğunu ekranas yazdıran uygulama.
            //    int s1, s2, top;
            //etiket:
            //    Console.Write("1.Sayıyı Giriniz = ");
            //    s1 = (Convert.ToInt16(Console.ReadLine()));
            //    Console.Write("2.Sayıyı Giriniz = ");
            //    s2 = (Convert.ToInt16(Console.ReadLine()));

            //    if (s1 > s2)
            //        Console.WriteLine(s1 + " En Büyük");
            //    else
            //    if (s2 > s1)
            //        Console.WriteLine(s2 + " En Büyük");
            //    else
            //        Console.WriteLine("Sayılar Eşit");

            //    top = s1 + s2;
            //    //Console.WriteLine("{0}+{1}={2},s1,s2,top");
            //    Console.WriteLine(s1 + " + " + s2 + " = " + top);
            //    goto etiket;
            //    Console.ReadKey();


            //1'den 10 'a kadar olan tek sayıları ekrana yazdıran uygulama.
            //    int x = 1;
            //etiket:
            //    Console.WriteLine(x);
            //    x = x + 2;
            //    if (x <= 10)
            //        goto etiket;
            //    Console.ReadKey();


            //Ekrandan girilen sayının faktöriyelini kesaplayıp ekrana yazdıran uygulama.
            //        int gir, top = 1, s = 1;
            //    Console.Write("Sayıyı Giriniz = ");
            //    gir = Convert.ToInt32(Console.ReadLine());
            //etiket:
            //    if (gir >= s)
            //    {
            //        top = top * s;
            //        s++;//k=k+1
            //        goto etiket;
            //    }
            //    Console.WriteLine(top);
            //    Console.ReadKey();


            //    int m, ms, mu, t;
            //    char mh, ecd, st;//statues
            //basla:
            //    Console.Clear();
            //    Console.Write("Maaş Miktarını Giriniz : ");
            //    m = (Convert.ToInt32(Console.ReadLine()));
            //    Console.Write("Mesai Saatini Giriniz : ");
            //    ms = (Convert.ToInt32(Console.ReadLine()));
            //    Console.Write("Mesai Saati Ücretini Giriniz : ");
            //    mu = (Convert.ToInt32(Console.ReadLine()));

            //    t = m + ms * mu;

            //    Console.Write("Medeni Durumu E/B : ");
            //    mh = (Convert.ToChar(Console.ReadLine()));
            //    if (mh == 'E' || mh == 'e')
            //    {
            //        Console.WriteLine("Eşi Çalışmakta mı :");
            //        ecd = Convert.ToChar(Console.ReadLine());
            //        if (ecd == 'E' || ecd == 'e')
            //        {
            //            t = t + 8000;
            //        }

            //    }

            //    Console.WriteLine(t);

            //    Console.WriteLine("Devam Etmek İstermisiniz [E/H] ");
            //    st = Convert.ToChar(Console.ReadLine());
            //    if (st == 'E' || st == 'e')
            //    {
            //        goto basla;
            //    }


            ////x üssü y işlemini yapan uygulama.(Kendi Yaptığım)
            //int x, y, top = 1;
            //Console.Write("X Değerini Giriniz = ");
            //x = (Convert.ToInt16(Console.ReadLine()));
            //Console.Write("Y Değerini Giriniz = ");
            //y = (Convert.ToInt16(Console.ReadLine()));
            //for (int i = 1; i <= y; i++)
            //{
            //    top = top * x;
            //}
            //Console.WriteLine(top);
            //Console.ReadKey();


            //x üssü y işlemini yapan uygulama.(Hocanın Yaptığın)
            //    int x, y, k = 1, top = 1;
            //    Console.Write("X Değerini Giriniz = ");
            //    x = (Convert.ToInt32(Console.ReadLine()));
            //    Console.Write("Y Değerini Giriniz = ");
            //    y = (Convert.ToInt32(Console.ReadLine()));
            //basla:
            //    if (k <= y)
            //    {
            //        top = top * x;
            //        k++;
            //        goto basla;
            //    }
            //    Console.WriteLine(top);
            //    Console.ReadKey();


            //Ekrandan girilen iki sayıyı toplayıp, büyük, küçük ve eşit olduğunu ekranas yazdıran uygulama.
            //    int s1, s2, top;
            //etiket:
            //    Console.Write("1.Sayıyı Giriniz = ");
            //    s1 = (Convert.ToInt16(Console.ReadLine()));
            //    Console.Write("2.Sayıyı Giriniz = ");
            //    s2 = (Convert.ToInt16(Console.ReadLine()));

            //    if (s1 > s2)
            //        Console.WriteLine(s1 + " En Büyük");
            //    else
            //    if (s2 > s1)
            //        Console.WriteLine(s2 + " En Büyük");
            //    else
            //        Console.WriteLine("Sayılar Eşit");

            //    top = s1 + s2;
            //    //Console.WriteLine("{0}+{1}={2},s1,s2,top");
            //    Console.WriteLine(s1 + " + " + s2 + " = " + top);
            //    goto etiket;
            //    Console.ReadKey();


            //1'den 10 'a kadar olan tek sayıları ekrana yazdıran uygulama.
            //    int x = 1;
            //etiket:
            //    Console.WriteLine(x);
            //    x = x + 2;
            //    if (x <= 10)
            //        goto etiket;
            //    Console.ReadKey();


            //Ekrandan girilen sayının faktöriyelini kesaplayıp ekrana yazdıran uygulama.
            //        int gir, top = 1, s = 1;
            //    Console.Write("Sayıyı Giriniz = ");
            //    gir = Convert.ToInt32(Console.ReadLine());
            //etiket:
            //    if (gir >= s)
            //    {
            //        top = top * s;
            //        s++;//k=k+1
            //        goto etiket;
            //    }
            //    Console.WriteLine(top);
            //    Console.ReadKey();


            //Ekrandan girilen Vize ve Final notlarının ortalaması ekrana yazdıran uygulama.
            //    int V, F, Ort;
            //etiket:
            //    Console.Clear();
            //    Console.Write("Vize Notunuzu Giriniz : ");
            //    V = (Convert.ToInt32(Console.ReadLine()));
            //    Console.Write("Final Notunuzu Giriniz : ");
            //    F = (Convert.ToInt32(Console.ReadLine()));

            //    Ort = (Convert.ToInt32(V * 0.4 + F * 0.6));

            //    Console.WriteLine("Ortalamanız : " + Ort + "");

            //    if (Ort >= 50)
            //        Console.WriteLine("GEÇTİ");
            //    else
            //        Console.WriteLine("BAŞARISIZ");

            //    Console.ReadKey();


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


            //Ekranda girilen N sayısına kadar olan ASAL sayıların ekrana yazdıran uygulama.
            //int N,Top;
            //bool asal;
            //Console.WriteLine("Asal sayı Yazdırma Sınırını giriniz");
            //N = Convert.ToInt32(Console.ReadLine());
            //if (N == 2)
            //{
            //    Console.WriteLine(2);
            //}
            //else
            //{
            //    for (int k = 2; k <= N; k++)
            //    {
            //        asal = true;
            //        for (int y = 2; y <= (k - 1); y++)
            //        {
            //            if (k % y == 0)
            //            {
            //                asal = false;
            //                break;//DÖNGÜDEN ÇIKMAK İÇİN YAZILDI
            //            }
            //            else
            //            {
            //                continue;
            //            }
            //        }
            //        if (asal == true)
            //        {
            //            Console.WriteLine(k);
            //            Top = Top + k;
            //            continue;
            //        }
            //        else
            //        {
            //            continue;//DÖNGÜ BAŞINA GİTMEK İÇİN
            //        }
            //    }

            //}
            //Console.WriteLine(N+ "Kadar Olan ASAL Satıların Toplamı = " );

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
