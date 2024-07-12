using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//kütüphane ekledik

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
            //dosyada aradığın kelimenin kaç tane olduğunu söyleyen kod
        {
            int sayac = 0;
            using (StreamReader sr = new StreamReader("D:\\at.txt"))
            {
                string Line;
                string ara;
                Console.WriteLine("Aramak İstediğiniz İsmi Giriniz");
                ara = Console.ReadLine();
                while ((Line = sr.ReadLine()) != null)//while ın amacı kelime aratmak için kullanmak
                {
                    if (Line.ToLower().Contains(ara.ToLower()))//Contains dizide olup olmadığını gösterir.
                    {
                       // Console.WriteLine("BULUNDU");
                        //Console.WriteLine(line);
                        sayac++;
                    }
                }
            }
            Console.WriteLine(sayac);
            Console.ReadKey();
           
             


        }
    }
}
