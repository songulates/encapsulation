
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "songül";
            ogrenci.Soyisim = "ateş";
            ogrenci.OgrenciNo = 239;
            ogrenci.Sinif = 4;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("deneme   ", "test", 999, 1);
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }
    class Ogrenci
    {
        private string isim; //field

        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Soyisim
        {
            get => soyisim;
            set => soyisim = value;
        }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value >= 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {

        }

        public void OgrenciBilgileriniGetir()
        {
           
            Console.WriteLine("Öğrenci Adı : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci Numarası : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı : {0}", this.Sinif);

        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
