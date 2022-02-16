using System;

namespace metotOverloadVeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                System.Console.WriteLine("Başarılı!");
                System.Console.WriteLine(outSayi);

            }
            else
            {
                System.Console.WriteLine("Başarısız.");
            }

            Methodlar instance = new Methodlar();
            instance.Topla(4, 5, out int toplamSonuc);
            System.Console.WriteLine(toplamSonuc);


        }


    }

    class Methodlar
    {


        public void Topla(int a, int b, out int Toplam)
        {
            Toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            System.Console.WriteLine(veri1 + veri2);
        }
    }
}
