using System;

namespace hatayonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                //int a= int.Parse(null);
                //int a= int.Parse("test");
                int a = int.Parse("-200000000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("Boş değer girdiniz");
                System.Console.WriteLine(ex);
            }

            catch (FormatException ex)
            {
                System.Console.WriteLine("Veri tipi uygun değil");
                System.Console.WriteLine(ex);
            }

            catch (OverflowException ex)
            {
                System.Console.WriteLine("Çok küçük yada büyük bir değer girdiniz.");
                System.Console.WriteLine(ex);
            }
        }
    }
}
