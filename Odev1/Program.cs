using System;
using System.Linq;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ödev 1
            //CiftSayilar(PozitifBirSayiAl());
            //Ödev 2
            //Odev2(PozitifBirSayiAl(), PozitifBirSayiAl());
            //Ödev 3
            //Odev3(PozitifBirSayiAl());
            // Ödev 4
            Odev4();
        }

        public static void Odev4()
        {
            System.Console.WriteLine("Bir cümle yazınız");
            string Cumle = Console.ReadLine();

            System.Console.WriteLine($"kelime sayısı : {Cumle.KelimeSayısı()} |||  Harf Sayısı : {Cumle.HarfSayısı()}");
        }
        public static void Odev3(int n)
        {
            var kelimeler = NKadarKelimeDondur(n);
            System.Console.WriteLine("Kelimeler :");
            kelimeler.StringArrayTersCevir().EkranaYazdir();
        }
        public static void Odev2(int n, int m)
        {
            var sayilar = NKadarSayiDondur(n);
            System.Console.WriteLine("m ye bölünen ve m'ye eşitler");
            foreach (var item in sayilar)
            {
                if (item == m && item % m == 0)
                    System.Console.WriteLine(item);
            }
        }
        public static void CiftSayilar(int n)
        {

            var sayilar = NKadarSayiDondur(n);

            System.Console.WriteLine("Çift Sayılar");
            Array.Sort(sayilar);
            sayilar.CiftSayilariEkranaYazdir();

        }

        public static string[] NKadarKelimeDondur(int n)
        {
            string[] kelimeler = new string[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Kelime: ");
                string kelime = Console.ReadLine();
                kelimeler[i] = kelime;
            }

            return kelimeler;
        }

        public static int[] NKadarSayiDondur(int n)
        {
            int[] sayilar = new int[n];


            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Sayi:");
                bool success = int.TryParse(Console.ReadLine(), out int result);

                if (!success || !PozitifMi(result))
                {
                    System.Console.WriteLine("Lütfen pozitif sayi giriniz : ");
                    i--;
                    continue;

                }
                sayilar[i] = result;

            }
            return sayilar;
        }

        public static int PozitifBirSayiAl()
        {
            bool success = false;
            while (true)
            {
                System.Console.WriteLine("Sayi gir: ");
                success = int.TryParse(Console.ReadLine(), out int sayi);
                if (success && PozitifMi(sayi) == true)
                    return sayi;
                else
                    System.Console.WriteLine("Lütfen sayi giriniz.");
            }

        }

        public static bool PozitifMi(int x)
        {
            if (x >= 0)
                return true;
            return false;
        }
    }

    static class Extensions
    {

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
                System.Console.WriteLine(item);
        }
        public static void EkranaYazdir(this string[] param)
        {
            foreach (var item in param)
                System.Console.WriteLine(item);
        }

        public static void CiftSayilariEkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                if (item % 2 == 0)
                    System.Console.WriteLine(item);
            }
        }

        public static string[] StringArrayTersCevir(this string[] param)
        {
            Array.Reverse(param);
            return param;
        }

        public static int KelimeSayısı(this string param)
        {
            return param.Split(' ').Length;
        }

        public static int HarfSayısı(this string param)
        {
            String.Join(' ', param);
            return param.Where(x => char.IsLetter(x) == true).Count();
        }


    }
}
