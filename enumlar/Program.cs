using System;

namespace enumlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;

            if (sıcaklık <= (int)HavaSıcaklıgı.Normal)
                System.Console.WriteLine("Dışarı çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if (sıcaklık >= (int)HavaSıcaklıgı.Sıcak)
                System.Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");
            else if (sıcaklık >= (int)HavaSıcaklıgı.Normal && sıcaklık < (int)HavaSıcaklıgı.CokSıcak)
                System.Console.WriteLine("Hadi dışarı çıkalım.");
        }

        enum Gunler
        {
            Pazartesi = 1,
            Sali,
            Carsamba,
            Persembe,
            Cuma = 23,
            Cumartesi,
            Pazar
        }

        enum HavaSıcaklıgı
        {
            Soguk = 5,
            Normal = 20,
            Sıcak = 25,
            CokSıcak = 39
        }
    }
}
