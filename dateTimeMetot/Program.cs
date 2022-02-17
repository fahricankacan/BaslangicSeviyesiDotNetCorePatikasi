using System;

namespace dateTimeMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(DateTime.Now.Date);
            System.Console.WriteLine(DateTime.Now.Day);
            System.Console.WriteLine(DateTime.Now.Month);
            System.Console.WriteLine(DateTime.Now.Year);
            System.Console.WriteLine(DateTime.Now.Hour);
            System.Console.WriteLine(DateTime.Now.Minute);
            System.Console.WriteLine(DateTime.Now.Second);


            System.Console.WriteLine(DateTime.Now.DayOfWeek);
            System.Console.WriteLine(DateTime.Now.DayOfYear);


            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            System.Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Console.WriteLine(DateTime.Now.ToLongTimeString());
            System.Console.WriteLine(DateTime.Now.ToShortTimeString());

            System.Console.WriteLine(DateTime.Now.AddDays(2));
            System.Console.WriteLine(DateTime.Now.AddHours(3));
            System.Console.WriteLine(DateTime.Now.AddSeconds(30));
            System.Console.WriteLine(DateTime.Now.AddMonths(5));
            System.Console.WriteLine(DateTime.Now.AddYears(10));
            System.Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format   
            System.Console.WriteLine(DateTime.Now.ToString("dd")); //24
            System.Console.WriteLine(DateTime.Now.ToString("ddd")); //fab
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));//fabruary

            System.Console.WriteLine(DateTime.Now.ToString("MM")); //04
            System.Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            System.Console.WriteLine(DateTime.Now.ToString("MMMM"));//april

            System.Console.WriteLine(DateTime.Now.ToString("yy")); //21
            System.Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

            //Math kütüphanesi
            System.Console.WriteLine(Math.Abs(-25));//25
            System.Console.WriteLine(Math.Sin(10));//
            System.Console.WriteLine(Math.Cos(10));//
            System.Console.WriteLine(Math.Tan(10));//

            System.Console.WriteLine(Math.Ceiling(22.3));
            System.Console.WriteLine(Math.Round(22.7));
            System.Console.WriteLine(Math.Floor(22.7));


            System.Console.WriteLine(Math.Max(2, 6));
            System.Console.WriteLine(Math.Min(2, 6));

            System.Console.WriteLine(Math.Pow(3, 4));
            System.Console.WriteLine(Math.Sqrt(9));
            System.Console.WriteLine(Math.Log(9, 3));
            System.Console.WriteLine(Math.Log10(9));



        }
    }
}
