using System;

namespace Proje2_ToDoUygulamasi
{
    class Program
    {

        static void Main(string[] args)
        {
            Board _board = new();
            Card _card = new();

            bool flag = true;

            while (flag)
            {
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine("(1) Board Listelemek");
                System.Console.WriteLine("(2) Board'a Kart Eklemek");
                System.Console.WriteLine("(3) Board'dan Kart Silmek");
                System.Console.WriteLine("(4) Kart Taşımak");
                System.Console.WriteLine("(5) Kart Güncelle");
                System.Console.WriteLine("(6) Çıkış");

                string userInput = Console.ReadLine();
                if (userInput == "1")
                    _board.GetLists();
                else if (userInput == "2")
                    _board.Add();
                else if (userInput == "3")
                    _board.Delete();
                else if (userInput == "4")
                    _board.CardTransport();
                else if (userInput == "5")
                    _board.Update();
                else if (userInput == "6")
                    flag = false;
            }
        }
    }
}
