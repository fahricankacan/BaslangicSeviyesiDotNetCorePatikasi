using System;

namespace diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            //clear
            System.Console.WriteLine("Clear");
            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            //Reverse
            System.Console.WriteLine("Reverse");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            //IndexOf
            System.Console.WriteLine("indexOf");

            System.Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize
            System.Console.WriteLine("Resize");

            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);


        }
    }
}
