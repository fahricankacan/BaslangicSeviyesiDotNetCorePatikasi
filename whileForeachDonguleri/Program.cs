using System;

namespace whileForeachDonguleri
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            System.Console.WriteLine(toplam / sayi);

            char character = 'a';
            while (character < 'z')
            {
                System.Console.WriteLine(character);
                character++;
            }
            System.Console.WriteLine("***foreach***");

            string[] arabalar = { "Tofaş", "BMW", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                System.Console.WriteLine(araba);
            }
        }
    }
}
