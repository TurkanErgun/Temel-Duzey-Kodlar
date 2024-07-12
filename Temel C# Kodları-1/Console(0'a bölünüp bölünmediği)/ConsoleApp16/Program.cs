using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sayının 0 a bölünüp bölünmediğini ve hatalı olup oladığını kontrol eden kod
            //git1://goto için etiketdir nereye koyarsan ordan sonrasını tekrarlar
            byte s1 = 0, s2 = 0, s3;
            try//Yapılmasını istediğimiz ve hataya sebep olma ihtimali olan kodları buraya yazarız.
            {
                Console.Clear();//amacı ekranı temizlemek goto varsa çalışır
                Console.WriteLine("Bir Sayı Giriniz...");
                s1 = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("2. SAYIYI GİRİNİZ...");
                s2 = Convert.ToByte(Console.ReadLine());
                s3 = Convert.ToByte(s1 / s2);
                Console.WriteLine(s3);
            }
            catch (Exception e)//try da hata olursa burdaki mesaj ekrana verilir
            {
                Console.WriteLine("sayı sıfıra bölünemez");
                Console.WriteLine(e.Message);
            }
            finally//hatalı olsada olmasada istenilen mesaj ekrana yazılır
            {
                Console.WriteLine("program tekrardan kendini sonlandırır");

            }
            //goto git1;//goto komutu bir nevi döngü oluşturmamızı sağlar.
            Console.ReadKey();
        }
    }
}
