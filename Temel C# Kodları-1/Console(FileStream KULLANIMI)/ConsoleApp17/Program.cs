using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//kütüphane
using System.ComponentModel;
using System.Security.Cryptography;

namespace ConsoleApp17
{
    internal class Program//FileStream nesnesi yeni bir dosya oluşturmak için kullanılmaktadır.
                          //FileStream nesnesini kullanabilmek için; kütüphaneye IO YU EKLEMEK LAZIM
    {
        static void Main(string[] args)
        {
            //Dosya açıp içine 0 dan 19 a kadar yazılan kod
            FileStream f = new FileStream("akmyo.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for  (byte i = 0; i < 20; i++)
            {
                f.WriteByte(i);
            }
            f.Position = 0;// dosyanın başlangıç sayısını belirler
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(f.ReadByte());
            }
            Console.ReadKey();
        }
    }
    /* 
     * FileMode : Dosya açılış şekillerini belirler
   Append : Dosyayı açarak dosyanın sonuna ekleme yapmak amacıyla kullanılır.Eğer dosya yoksa oluşturulur.
  Create : Yeni bir dosya oluşturulmak istendiğinde kullanılır. Eğer aynı isimde bir dosya bulunuyorsa üzerine yazılır.
  CreateNew : Yeni dosya oluşturmak için kullanılır.Eğer dosya mevcutsa hata meydana gelir.
  Open : Dosyayı açmak için kullanılır.
  OpenOrCreate : Belirtilen dosya varsa açılır, yoksa yeni dosya oluşturulur.
  Truncate : Belirtilen dosya açılarak içindeki bilgiler silinir.

    FileAccess : Dosya erişim şekillerini belirler.
  Read : Dosyayı okumak üzere açar.
  Write : Dosya sadece yazmak üzere açılır.
  ReadWrite : Dosyayı okunmak ve yazmak amacıyla açar.

    FileShare :Dosya paylaşım şekillerini belirler. 
  None : Dosya kapatılana kadar başka işlem tarafından açılmasını engeller.
  Read : Dosya açıkken başka işlemler tarafından açılıp okunabilmesi sağlanır.
  Write : Dosya açıkken başka işlemler tarafından açılıp yazılabilmesini sağlar.
  ReadWrite : Dosya açıkken dosyanın açılıp okunup yazılabilmesi sağlanır.

     FileOptions : Dosya seçenekleri ayarlanır.
  None : Herhangi bir özellik içermez.
  WriteThrough : Sistemin herhangi bir arabellek tarafından doğrudan disk üzerine yazılacağını gösterir.
  Asynchronous : Bir dosyanın asenkron olarak okuma ve yazma için kullanılabileceğini ayarlar.
  RandomAccess : Dosyaya rasgele erişilebileceğinigösterir. Örnek olarak bir önbellek dosyasını optimize etmek için kullanılabilir.
  DeleteOnClose : Dosyanın kullanımda olmadığı zaman otomatik olarak silineceğini gösterir.
  Encrypted : Dosyanın şifrelendiğini ve şifrelemede kullanılan kullanıcı hesabıyla çözülebileceğini gösterir.*/
}
