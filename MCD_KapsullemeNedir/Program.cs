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

            //1.Field ataması yapılmasın ama değer okunabilsin
            Console.WriteLine("Müşteri ID değeri: "+M1.ID .ToString ());
           
            //İsim ve Soyisim
            //İsim ve soyisim [soyisim] = set 
            //email adresi...
            //email get gmcc.emree@gmail.com
            //set: private

            M1.isim = "emre";
            M1.Soyisim = "gemici";
            Console.WriteLine(M1.EmailAdres);


            M1.TCKimlikNumarasi = "12o45678999";
            Console.WriteLine(M1 .TCKimlikNumarasi);
            Console.ReadKey();

        }
    }
}
