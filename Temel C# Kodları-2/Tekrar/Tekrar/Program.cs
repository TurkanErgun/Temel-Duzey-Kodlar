using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sa = 0, se = 0, su = 0, sü = 0, si = 0, sı = 0, so = 0, sö = 0, sb = 0;
            string metin = "";//Ekrandan girilen metninde bulunan sesli harfleri ve kac adet olduklarını yazdırır
            Console.WriteLine("Bir Metin Giriniz..");
            metin = Console.ReadLine();
            metin = metin.ToLower();
            //Console.WriteLine(metin.ToLower());
            for (int i = 0; i < metin.Length; i++)
            {
                switch (metin[i])
                {
                    case 'a':
                        sa++; break;
                    case 'e':
                        se++; break;
                    case 'u':
                        su++; break;
                    case 'ü':
                        su++; break;
                    case 'i':
                        si++; break;
                    case 'ı':
                        sı++; break;
                    case 'o':
                        so++; break;
                    case 'ö':
                        sö++; break;
                    case ' ':
                        sb++; break;

                    default:
                        //Console.WriteLine("Hatalı Değerler");
                        break;
                }
            }
            Console.WriteLine(" a harfinden " + sa + " adet var");
            Console.WriteLine(" e harfinden " + se + " adet var");
            Console.WriteLine(" u harfinden " + su + " adet var");
            Console.WriteLine(" ü harfinden " + sü + " adet var");
            Console.WriteLine(" i harfinden " + si + " adet var");
            Console.WriteLine(" ı harfinden " + sı + " adet var");
            Console.WriteLine(" o harfinden " + so + " adet var");
            Console.WriteLine(" ö harfinden " + sö + " adet var");
            Console.WriteLine(" Metin" + sb + " kelimeden oluşmaktadır");


            //int[] dz = new int[10];
            //Random rnd = new Random();


            //for (int i = 0; i < dz.Length; i++)
            //{

            //    dz[i] = rnd.Next(100);
            //    Console.WriteLine(dz[i]);
            //    for (int j = i + 1; j < dz.Length; j++)
            //    {
            //        Console.WriteLine(dz[i]);

            //        if (dz[i] > dz[j])
            //        {
            //            int gecici = j;
            //            dz[j] = dz[i];
            //            dz[i] = gecici;
            //        }
            //    }
            //}

            //for (int i = 0; i < dz.Length; i++)
            //{

            //    //Console.WriteLine(dz[i]);

            //}  


            //int[] dz = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < dz.Length; i++)
            //{
            //    dz[i] = r.Next(0, 101);
            //}
            //foreach (int s in dz)
            //{
            //    Console.WriteLine(s + " ");
            //}
            //Console.WriteLine("Sayıları K<B sıralanışı için bir tuşa tıklayın");
            //Console.ReadKey();
            //Array.Sort(dz);
            //foreach (int s in dz)
            //{
            //    Console.WriteLine(s + " ");
            //}


            //int[] a = new int[] { 4, 8, 3, 1, 18, 9, 21, 25, 17 };
            ////int sayac = 0;
            ////int t_tpl = 0;
            ////int sayi;
            ////Console.WriteLine("Bir Sayı Giriniz..");
            ////sayi = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int j = 0; j < a[i]; j++)
            //    {
            //        Console.Write(a[i] + " ");
            //    }
            //    Console.WriteLine();


            //    //for (int j = 0; j < 5; j++)//sayıyı ekrana 5 kere yazdıran döngü
            //    //{
            //    //    Console.Write(a[i] + " ,");
            //    //}
            //    //if (a[i] < sayi)
            //    //{
            //    //    //Console.WriteLine(a[i] +" ,");
            //    //    if (a[i] % 2 == 1)
            //    //    {
            //    //        Console.Write(a[i]+" ,");
            //    //        //sayac = sayac + 1;
            //    //        //t_tpl = t_tpl + a[i];
            //    //    }
            //    //}
            //    //if (a[i] % 2 == 1)
            //    //{
            //    //    Console.WriteLine(a[i]);
            //    //    sayac = sayac + 1;
            //    //    t_tpl = t_tpl + a[i];
            //    //}


            //Console.WriteLine(sayac+" tane tek sayı dizide bulunmaktadır..");
            //Console.WriteLine("dizideki tek sayıların toplamı = "+ t_tpl);
            //Console.WriteLine("dizideki tek sayıların ortalması = " + (t_tpl/sayac));


            // verilen değerlerden çift olanları ekrana yazma

            //int[] a = new int[] { 4, 8, 3, 1, 18, 9, 21, 25, 17 };
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] % 2 == 0)
            //        Console.WriteLine(a[i]);
            //}

            // verilen değerlerden tek olanları ekrana yazma

            //int[] a = new int[] { 4, 8, 3, 1, 18, 9, 21, 25, 17 };
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i]%2==1)
            //    Console.WriteLine(a[i]);
            //    }



            //int[] n = new int[1000];/* n is an array of 10 integers*/
            //int j;
            ///* initialize elements of array n */

            //for (int i = 0; i < 1000; i++)
            //{
            //    n[i] = i + 100;
            //    Console.WriteLine(n[i]);
            //    //System.Threading.Thread.Sleep(100);
            //}
            //Console.ReadKey();
            //Console.WriteLine("*********************************");
            //for (int i = 0; i < n.Length; i++) //dizinin uzunluğu kadar
            //{
            //    Console.WriteLine(n[i]=(n[i]-100));
            //}
            //Console.ReadKey();
            //Console.WriteLine("*********************************");
            //for (int i = 0; i < n.Length; i++) //dizinin uzunluğu kadar
            //{
            //    Console.WriteLine(n[i]);
            //}
            //foreach (var a in n)
            //{
            //    Console.WriteLine(a);
            //}




            //int[,] n = new int[3, 4];
            //Random rnd = new Random();
            //for (int r = 0; r < 3; r++)
            //{
            //    for (int c = 0; c < 4; c++)
            //    {
            //        n[r, c] = rnd.Next(0, 500);
            //    }
            //}
            //int sayac;
            //foreach (var a in n)
            //{
            //    sayac++;
            //    Console.Write(a + " ");
            //    if (sayac == 4)
            //    {
            //        sayac = 0;
            //        Console.WriteLine();
            //    }
            //}


            //Ekrandaki sayıları küçükten büyüğe doğru sıralama




            Console.ReadKey();

        }
    }
}


