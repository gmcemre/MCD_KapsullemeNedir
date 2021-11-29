using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            /*
             * Field değer ataması yapılmasın ama değer okunabilsin.
             * Field değer ataması yapılsın ama değer okunamasın.
             * Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
             * Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
             * 
             */
           // M1.emailAdres = "gmcc.emree@gmail.com";  (field)

            // Genel olarak kapsülleme konusuna giriş yaptık.
            M1.EmailAdres = "gmcc.emree@gmail.com";
            Console.WriteLine(M1 .EmailAdres );

            Console.ReadKey();

        }
    }
}
