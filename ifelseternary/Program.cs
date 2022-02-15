using System;

namespace ifelseternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            // if (time <= 10)
            //     System.Console.WriteLine("Günaydın");
            // else if (time >= 22)
            //     System.Console.WriteLine("İyi geceler");
            // else
            //     System.Console.WriteLine("İyi günler");

            string sonuc = time <= 18 ? "İyi Günler!" : "İyi Geceler";

            sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "İyi günler!" : "İyi geceler";

            System.Console.WriteLine(sonuc);
        }
    }
}
