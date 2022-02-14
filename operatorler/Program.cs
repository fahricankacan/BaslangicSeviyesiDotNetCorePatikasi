using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Atama ve işlemli Atama
            int x = 3;
            int y = 3;
            y = y + 2;
            y += 2;

            System.Console.WriteLine(y);
            y += 2;
            System.Console.WriteLine(y);
            y /= 1;
            System.Console.WriteLine(y);
            System.Console.WriteLine(x);
            x *= 2;

            //Mantıksal Operatörler
            // || , && , !

            bool isSuccess = true;
            bool isComplated = false;

            if (isSuccess && isComplated)
                System.Console.WriteLine("Perfect");

            if (isSuccess || isComplated)
                System.Console.WriteLine("Perfect");
            if (isSuccess && !isComplated)
                System.Console.WriteLine("Perfect");


            //ilişkisel Operatörler
            //<,>,<=,>=,==,!=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            System.Console.WriteLine(sonuc);
            sonuc = a > b;
            System.Console.WriteLine(sonuc);
            sonuc = a >= b;
            System.Console.WriteLine(sonuc);
            sonuc = a <= b;
            System.Console.WriteLine(sonuc);
            sonuc = a != b;
            System.Console.WriteLine(sonuc);
            sonuc = a == b;
            System.Console.WriteLine(sonuc);
            sonuc = a < b;

            // Artimatik Operatörler
            // /,*,+,-

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            System.Console.WriteLine(sonuc);
            sonuc1 = sayi1 * sayi2;
            sonuc1 = sayi1 + sayi2;
            sonuc1 = sayi1 - sayi2;
            sonuc1 = sayi1++;

        }
    }
}
