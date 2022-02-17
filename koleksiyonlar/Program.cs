using System;
using System.Collections.Generic;

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            System.Console.WriteLine(sayiListesi.Count);
            System.Console.WriteLine(renkListesi.Count);


            foreach (var item in sayiListesi)
                System.Console.WriteLine(item);

            foreach (var item in renkListesi)
                System.Console.WriteLine(item);


            sayiListesi.ForEach(p => System.Console.WriteLine(p));
            renkListesi.ForEach(p => System.Console.WriteLine(p));

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            sayiListesi.RemoveAt(1);

            sayiListesi.ForEach(p => System.Console.WriteLine(p));
            renkListesi.ForEach(p => System.Console.WriteLine(p));

            if (sayiListesi.Contains(10))
                System.Console.WriteLine("10 Liste içersinde bulundu!");

            System.Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.Clear();

            List<Kulanıclar> kullanıcıListesi = new List<Kulanıclar>();

            Kulanıclar kullanıcı1 = new();
            kullanıcı1.Isım = "Fahrican";
            kullanıcı1.SoyIsım = "Kaçan";
            kullanıcı1.Yas = 23;


            Kulanıclar kullanıcı2 = new();
            kullanıcı2.Isım = "Luffy";
            kullanıcı2.SoyIsım = "Monkey";
            kullanıcı2.Yas = 22;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kulanıclar> yeniListe = new();

            yeniListe.Add(new Kulanıclar()
            {
                Isım = "ahmet",
                SoyIsım = "mehmet",
                Yas = 23
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                System.Console.WriteLine("Kullanıcı adı : " + kullanıcı.Isım);
                System.Console.WriteLine("Kullanıcı soyadı : " + kullanıcı.SoyIsım);
                System.Console.WriteLine("Kullanıcı yaşı : " + kullanıcı.Yas);
            }

        }


        public class Kulanıclar
        {

            private string isim;
            private string soyisim;
            private int yas;

            public string Isım { get { return isim; } set { isim = value; } }
            public string SoyIsım { get { return soyisim; } set { soyisim = value; } }
            public int Yas { get { return yas; } set { yas = value; } }


        }
    }
}
