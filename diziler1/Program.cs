using System;

namespace diziler1
{
    class Program
    {
        static void Main(string[] args)
        {
            //diziler1
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kediler", "Köpekler", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";
            dizi[3] = 10;

            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);

            System.Console.WriteLine("Lütgen dizinn eleman sayisini giriniz : ");
            int diziUzulugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzulugu];

            for (int i = 0; i < diziUzulugu; i++)
            {
                System.Console.WriteLine("Lütfen {0}, sayısı giriniz", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            System.Console.WriteLine("Ortalama : " + toplam / diziUzulugu);
        }
    }
}
