using System;

namespace metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            System.Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            System.Console.WriteLine(sonuc);

            Methodlar ornek = new();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }

        static int Topla(int deger1, int deger2)
        {
            return deger2 + deger1;
        }
    }

    class Methodlar
    {

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger2 + deger1;
        }
    }
}
