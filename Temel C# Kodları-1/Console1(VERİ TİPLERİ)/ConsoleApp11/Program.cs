using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Tuşa Basın...");
            Console.ReadLine();
            Console.WriteLine("Bir Tuşa Bastınız...");

             
            int Ucret = 10;
            int UCRET;
            UCRET = 50;
            Console.WriteLine(Ucret);
            Console.WriteLine(UCRET);


            
            {
                float f = 3.12F;
                Console.WriteLine(f);
                double d1 = 4.25;
                double d2 = 3D;
                double d3 = 4d;
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);
            }
            {
                bool b1 = false;
                bool b2 = true;

                int a = 50;
                bool b3 = a < 60;
                Console.WriteLine(b1);
                Console.WriteLine(b2);
                Console.WriteLine(b3);

                char c1 = 'A';
                char c2 = (char)90;
                char c3 = '\u0058';
                Console.WriteLine(c1);
                Console.WriteLine(c2);
                Console.WriteLine(c3);
            }

            {
                string s1 = "MERHABA";
                string s2 = ".NET";
                string s3 = s1 + s2;//yana yana yazdırdık
                string s4 = "Escape Karaketerleri (\',\\) ";
                string s5 = @"Escape Karaketerleri(',\)";
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine(s3);
                Console.WriteLine(s4);
                Console.WriteLine(s5);

            }

            { //object veri türü gizli olarak türediği veri türüdür bana aşağağıda veeri türlerini gösteririr
                object a;
                a = 5;
                Console.WriteLine(a.GetType());
                a = 'A';
                Console.WriteLine(a.GetType());
                a = 12.5F;
                Console.WriteLine(a.GetType());
                a = true;
                Console.WriteLine(a.GetType());
                a = 3.14M;
                Console.WriteLine(a.GetType());

            }
            { // var veri tipi ile değişkenlerin tipleri bildirilmeden yazabiniyor
                var num = 4;
                var str = "ALİ";
                var dd = 3.4;
                Console.WriteLine(num);
                Console.WriteLine(str);
                Console.WriteLine(dd);
            }

            Console.ReadKey();
        }
    }
}
