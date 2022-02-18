using System;

namespace instanceFieldProperty
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("****Ronona Zoro****");
            Calisan Zoro = new("Ronona", "Zoro", 2, "SunnyGo");
            Zoro.CalisanBilgileri();

            System.Console.WriteLine("****Big Mom***");
            Calisan BigMom = new("Big", "Mom");
            BigMom.CalisanBilgileri();

            System.Console.WriteLine("*****Calisan1*****");
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Fahrican";
            calisan1.Soyad = "Kaçan";
            calisan1.Departman = "Ev";
            calisan1.No = 3;
            calisan1.CalisanBilgileri();
            System.Console.WriteLine("************");

            Calisan calisan2 = new();
            calisan2.Ad = "Luffy";
            calisan2.Soyad = "Monkey";
            calisan2.Departman = "Merigo";
            calisan2.No = 1;

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {

        public Calisan()
        {

        }

        public Calisan(string ad, string soyadı, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyadı;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyadı)
        {
            this.Ad = ad;
            this.Soyad = soyadı;

        }
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Ad :{0}", Ad);
            System.Console.WriteLine("Soyad :{0}", Soyad);
            System.Console.WriteLine("No :{0}", No);
            System.Console.WriteLine("Departman :{0}", Departman);

        }
    }
}
