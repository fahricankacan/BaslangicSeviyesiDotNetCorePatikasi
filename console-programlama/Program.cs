using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("İsiminizi yazınız :");
            string Name = Console.ReadLine();
            System.Console.WriteLine($"İsminiz : {Name}");
        }
    }
}
