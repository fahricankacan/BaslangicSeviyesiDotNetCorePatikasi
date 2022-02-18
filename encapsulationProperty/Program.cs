using System;

namespace encapsulationProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new("Fahrican", "Kaçan", 123, 3);
            ogrenci.OgrenciBilgileriniYazdir();

            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();

            ogrenci.OgrenciBilgileriniYazdir();


            ogrenci.SinifAtlat();
            ogrenci.SinifAtlat();
            ogrenci.SinifAtlat();

            ogrenci.OgrenciBilgileriniYazdir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyIsim;
        private int no;
        private int sinif;

        public Ogrenci() { }
        public Ogrenci(string isim, string soyIsim, int no, int sinif)
        {
            this.isim = isim;
            this.soyIsim = soyIsim;
            this.no = no;
            this.sinif = sinif;
        }

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif
        {
            get => sinif; set
            {
                if (value < 1)
                {
                    System.Console.WriteLine("Sinif 1'den küçük olamaz.");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public void OgrenciBilgileriniYazdir()
        {
            System.Console.WriteLine("**********Ogrenci Bilgileri**********");
            System.Console.WriteLine("Öğrenci Adı        :{0}", Isim);
            System.Console.WriteLine("Öğrenci Soyadı     :{0}", SoyIsim);
            System.Console.WriteLine("Öğrenci No         :{0}", No);
            System.Console.WriteLine("Öğrenci Sınıfı     :{0}", Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }

        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}
