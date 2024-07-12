using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//kütüphane ekledik

namespace ConsoleApp18
{
    internal class Program// isimleri dosyada yazdırdık
    {
        static void Main(string[] args)
        {
            //açılan dosyanın içine girilen metinleri gösteren ve dosyayı açan kod
            string[] isimler = new string[] { "GEBZE", "İSTANBUL", "DÜZCE", "İZMİR", "ANKARA" };
            using (StreamWriter sw = new StreamWriter("D:\\at.txt")) 
            {
                foreach (string isim in isimler)//diziler için sayısal veya mentinsel dizi içindeki sırasıyla değişkene atama işlemi yaparak listeleme işlemi yapar
                {
                    sw.WriteLine(isim);
                }
            }
            Console.ReadKey();
        }
    }
}
