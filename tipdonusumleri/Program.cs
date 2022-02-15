using System;

namespace tipdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***Implicit conversion***");

            //Implicit Conversion (Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            System.Console.WriteLine("d:" + d);

            long h = d;
            System.Console.WriteLine("h:" + h);

            float i = h;
            System.Console.WriteLine("i:" + i);

            string e = "zikriye";
            char f = 'k';
            object g = e + f + d;
            System.Console.WriteLine("g:" + g);

            //Explicit Conversion (Bilinçli Dönüşüm)

            System.Console.WriteLine("***Exclipt conversion***");

            int x = 4;
            byte y = (byte)x;
            System.Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            System.Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("v:" + v);

            //*** ToString Metodu ***

            System.Console.WriteLine("*** ToString Metodu ***");
            int xx = 6;
            string yy = xx.ToString();
            System.Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            System.Console.WriteLine(zz);

            //System.Convert
            System.Console.WriteLine("*******System.Convert********");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi2 + sayi1;
            System.Console.WriteLine("Toplam:" + Toplam);

            //Parse 
            System.Console.WriteLine("****Parse****");

            ParseMethod();


        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            System.Console.WriteLine("rakam1:" + rakam1);
            System.Console.WriteLine("double1:" + double1);
        }
    }
}
