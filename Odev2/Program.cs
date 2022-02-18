using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            Soru3();
        }

        static void Soru3()
        {
            //char[] harf = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü', };

            string cumledekiSesliHarfler = "";

            string cumle = Console.ReadLine();
            string birlesikCumle = cumle.Replace(" ", "");
            var chrArr = birlesikCumle.ToCharArray();

            foreach (var item in chrArr)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'ı' || item == 'o' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                {
                    cumledekiSesliHarfler += item;
                }
            }

            foreach (var item in cumledekiSesliHarfler)
                System.Console.WriteLine(item);
        }
        static void Soru2()
        {
            int[] sayılar = NTaneSayiAl(20);
            Array.Sort(sayılar);

            int enBuyuk3Toplamı = 0;
            int enKucuk3Toplamı = 0;

            int enBuyuk3Ortlaması = 0;
            int enKucuk3Ortalaması = 0;
            for (int i = 0; i < 3; i++)
            {
                enKucuk3Toplamı += sayılar[i];
                enBuyuk3Toplamı += sayılar[sayılar.Length - 1 - i];
            }
            enKucuk3Ortalaması = enKucuk3Toplamı / 3;
            enBuyuk3Ortlaması = enBuyuk3Toplamı / 3;

            System.Console.WriteLine($"Ortalamaların toplamı :{enBuyuk3Ortlaması + enKucuk3Ortalaması}");
        }
        static void Soru1()
        {
            ArrayList asal = new();
            ArrayList asalOlmayan = new();

            for (int i = 0; i < 20; i++)
            {
                System.Console.WriteLine($"{i + 1}-Sayi ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi < 0)
                {
                    System.Console.WriteLine("Lütfen pozitif sayı giriniz : ");
                    i--;
                    continue;
                }

                if (sayi.AsalSayıMı())
                    asal.Add(sayi);

                else
                    asalOlmayan.Add(sayi);

            }
            asal.Sort();
            asal.Reverse();
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            System.Console.WriteLine("Asal Sayılar");
            foreach (var item in asal)
                System.Console.Write(item + "-");

            System.Console.WriteLine(" ");
            System.Console.WriteLine("Asal Olmayan Sayılar");
            foreach (var item in asalOlmayan)
                System.Console.Write(item + "-");
        }

        public static int[] NTaneSayiAl(int n)
        {
            List<int> sayiListesi = new();
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"{i + 1}-Sayi ");
                int sayi = int.Parse(Console.ReadLine());

                sayiListesi.Add(sayi);
            }

            return sayiListesi.ToArray();
        }
    }



    static class Extension
    {
        public static bool AsalSayıMı(this int n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {

                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
