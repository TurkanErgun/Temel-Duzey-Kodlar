using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //açılan dosyanın içine girilen metinleri gösteren ve dosyayı açan kod
            string[] isimler = new string[] { "GEBZE", "İSTANBUL", "DÜZCE", "İZMİR", "ANKARA" };
            using (StreamWriter sw = new StreamWriter("D:\\mrv.txt"))
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
