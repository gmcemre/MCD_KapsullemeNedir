using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsullemeNedir
{
    class Musteri
    {
        //Class => Field (Alan)
        int id;
        public string isim;
        public string soyisim;

        //Class => Property
        private string emailAdres;
        public string EmailAdres
        {
            //get; //Database veya farklı bir veri kaynağı class çağıran programcıya datayı gösterdiğimiz alan
            
            //set; // Dış dünyadan alınan datanın içerisinde private olarak saklanan field içerisine değer atandığı kısım...

            set
            {
                this.emailAdres = value;
            }
            get
            {
                return this.emailAdres;
            }


        }

        

    }
}
