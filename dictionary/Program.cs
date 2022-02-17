using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullancılar = new Dictionary<int, string>();
            //keyler benzersiz olmalı yoksa hata verir.
            kullancılar.Add(1, "fako");
            kullancılar.Add(12, "Luffy");
            kullancılar.Add(13, "Zoro");
            kullancılar.Add(14, "Sanji");
            kullancılar.Add(123, "Chopper");

            System.Console.WriteLine("****Elemanlara Erişim ***");
            System.Console.WriteLine(kullancılar[12]);
            foreach (var item in kullancılar)
            {
                System.Console.WriteLine(item);
            }

            //count
            System.Console.WriteLine(kullancılar.Count);

            //Contains
            System.Console.WriteLine(kullancılar.ContainsKey(12));
            System.Console.WriteLine(kullancılar.ContainsValue("Sanji"));


            //Remove 
            System.Console.WriteLine("***Remove****");
            kullancılar.Remove(13);

            foreach (var item in kullancılar)
            {
                System.Console.WriteLine(item.Value);
            }

            //Keys 
            System.Console.WriteLine("****KEYS***");
            foreach (var item in kullancılar.Keys)
                System.Console.WriteLine(item);

            System.Console.WriteLine("****VALUES***");
            foreach (var item in kullancılar.Values)
                System.Console.WriteLine(item);
        }



    }
}
