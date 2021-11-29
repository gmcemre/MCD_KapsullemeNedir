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

        public  Musteri()
        {
            this.id = IDuret();
        }

        

        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public string isim;
        private string _soyisim;
        public string Soyisim
        {
            get 
            {
                return this._soyisim;
            }
            set
            {
                this._soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@hotmail.com", isim, _soyisim);
            }
        }


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
        //Ara Odev

        private string _tcKimlikNumarasi;
        public string TCKimlikNumarasi
        {
            get 
            {
                if (_tcKimlikNumarasi != null)
                    return _tcKimlikNumarasi.Substring(0, 3) + "********";
                else
                    return "";
            }
            set
            {
                if (value .Length ==11)
                {
                    
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol )
                        {
                            //sayılsal değer demektir...
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }

                    if (bayrak)
                    {
                        Console.WriteLine("TC Kimlik Numarası içindeki değerler sayısal olmalıdır...");
                    }
                    else
                    {
                        this._tcKimlikNumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası 11 hane olmalıdır...");
                }
            }
        }

        private int IDuret()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }

    }
}
