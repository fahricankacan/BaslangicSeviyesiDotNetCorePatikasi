using System;

namespace StatikSiniflarVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı :{0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("fahri", "can", "ik");
            System.Console.WriteLine("Çalışan sayısı:{0}", Calisan.CalisanSayisi);

            System.Console.WriteLine(Islemler.Topla(5, 4));
            System.Console.WriteLine(Islemler.Cikar(5, 4));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        private string isim;
        private string SoyIsım;
        private string Departman;


        static Calisan() { calisanSayisi = 0; }
        public Calisan(string isim, string soyIsim, string departman)
        {
            this.isim = isim;
            this.SoyIsım = soyIsim;
            this.Departman = departman;
            calisanSayisi++;
        }

        public static int CalisanSayisi { get => calisanSayisi; }

    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2) => sayi1 + sayi2;
        public static long Cikar(int sayi1, int sayi2) => sayi1 - sayi2;
    }
}
