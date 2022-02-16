using System;

namespace extensionVeRecursiveMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            System.Console.WriteLine(result);

            Islemler instance = new();
            System.Console.WriteLine(instance.Expo(3, 4));
            //Extension
            string ifade = "Fahrican Kaçan";
            bool sonuc = ifade.CheckSpaces();
            System.Console.WriteLine(sonuc);

            System.Console.WriteLine(ifade.RemoveWhitespaces().ToUpper().ToLower());

            int[] dizi = { 1, 2, 3, 0, 2, 5, 45, 234, 61, 23, 42, 1 };
            dizi.SortArray();
            dizi.EkranaYazdir();

        }
    }

    class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;

            return Expo(sayi, us - 1) * sayi;
        }



    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhitespaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {

            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
                System.Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static bool IsOddNumber(this int param)
        {
            return param % 2 == 1;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
