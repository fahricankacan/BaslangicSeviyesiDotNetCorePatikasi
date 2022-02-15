using System;

namespace forLoopBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Lütfen bir sayi giriniz : ");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 1; i < sayac; i++)
            // {
            //     if (i % 2 == 1)
            //         System.Console.WriteLine(i);
            // }


            // int tekToplam = 0;
            // int ciftToplam = 0;

            // for (int i = 0; i <= 1000; i++)
            // {
            //     if (i % 2 == 0)
            //         ciftToplam += i;
            //     else
            //         tekToplam += i;
            // }

            // System.Console.WriteLine("Tek Toplam :" + tekToplam);
            // System.Console.WriteLine("Çift Toplam :" + ciftToplam);

            for (int i = 0; i < 10; i++)
            {
                if (i == 1)
                    continue;
                if (i == 4)
                    break;
                System.Console.WriteLine(i);
            }
        }
    }
}
