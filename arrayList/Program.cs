using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listele = new();
            listele.Add("Ayşe");
            listele.Add(2);
            listele.Add(true);
            listele.Add('A');

            System.Console.WriteLine(listele[1]);

            foreach (var item in listele)
                System.Console.WriteLine(item);

            System.Console.WriteLine("******Add Range *******");
            string[] renkler = { "kırmızı", "sari", "pembe" };
            List<int> sayılar = new() { 1, 2, 3, 4, 51, 321, 5, 123 };
            listele.AddRange(renkler);
            listele.AddRange(sayılar);

            foreach (var item in listele)
                System.Console.WriteLine(item);


            System.Console.WriteLine("**** Sort *****");
            sayılar.Sort();//array list içersinde 2 farklı ICollection olduğu için sıralamaz hata verir
            foreach (var item in sayılar)
                System.Console.WriteLine(item);

            System.Console.WriteLine("********Binary Search ********");
            System.Console.WriteLine(sayılar.BinarySearch(51));

            //reverse
            System.Console.WriteLine("****Reverse ****");
            listele.Reverse();
            foreach (var item in listele)
                System.Console.WriteLine(item);

            //clear
            System.Console.WriteLine("**** Clear ****");
            listele.Clear();

            foreach (var item in listele)
                System.Console.WriteLine(item);
        }
    }
}
