using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("");

            byte b = 5; //1byte
            sbyte c = 5;//1byte

            short s = 5; //2 byte
            ushort us = 5;//2 byte

            Int16 i16 = 2;   //2byte
            int i = 2;  // 4byte
            Int32 i32 = 2; //4byte
            Int64 i64 = 2; //8byte


            uint ui = 2; //4 byte;
            long l = 4; //8 byte
            ulong ul = 4; //8byte

            float f = 5; //4 byte;
            double d = 5; //8byte
            decimal de = 5; //16byte

            char ch = '2'; //2byte
            string str = "sa";///sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            System.Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Zikriye Ürkmez";
            string ad = "Zikyirye";
            string soyad = "Ürkmez";
            string tamİsim = $"{ad} {soyad}";

            int int1 = 5;
            int int2 = 3;
            int int3 = int1 + int2;


            bool bool1 = 10 > 2;

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            System.Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            string dateTime = DateTime.Now.ToString("dd.Mm.yyyy");
            System.Console.WriteLine(dateTime);

            string dateTime1 = DateTime.Now.ToString("dd/Mm/yyyy");
            System.Console.WriteLine(dateTime);

            string hour = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(hour);



        }


    }
}
