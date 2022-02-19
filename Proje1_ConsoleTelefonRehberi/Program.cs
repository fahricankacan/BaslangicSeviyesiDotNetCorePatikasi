using System;

namespace Proje1_ConsoleTelefonRehberi
{
    partial class Program
    {
        static Phone phone = new Phone();
        static void Main(string[] args)
        {


            bool exitFlag = false;
            string choose = "";

            while (!exitFlag)
            {
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                System.Console.WriteLine("******************************************");
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
                System.Console.WriteLine("(2) Varolan Numarayı Silmek");
                System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                System.Console.WriteLine("(4) Rehberi Listelemek");
                System.Console.WriteLine("(5) Rehberde Arama Yapmak");
                choose = Console.ReadLine();
                if (choose == "0")
                    exitFlag = true;
                else if (choose == "1")
                    Add();
                else if (choose == "2")
                    Delete();
                else if (choose == "3")
                    Update();
                else if (choose == "4")
                    GetList();
                else if (choose == "5")
                    Search();
            }
            static void Add()
            {
                System.Console.Write("Lütfen bir isim giriniz     : ");
                string getName = Console.ReadLine();
                System.Console.WriteLine("");
                System.Console.Write("Lütfen bir Soy İsim giriniz : ");
                string getSurname = Console.ReadLine();
                System.Console.WriteLine("");
                System.Console.Write("Lütfen bir Numara giriniz   : ");
                string getNumber = Console.ReadLine();
                System.Console.WriteLine("");
                phone.Add(new Person
                {
                    Name = getNumber,
                    SurName = getSurname,
                    Number = getNumber
                });
            }
            static void Delete()
            {
                bool flag = true;
                while (flag)
                {
                    System.Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                    string input = Console.ReadLine();
                    System.Console.WriteLine(input);
                    var searchResult = phone.Search(input);
                    if (searchResult == null)
                    {
                        System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        System.Console.WriteLine("* Yeniden denemek için      : (2)");
                        string choose = Console.ReadLine();
                        if (choose == "1")
                        {
                            flag = false;
                        }

                    }
                    else if (searchResult != null)
                    {
                        System.Console.WriteLine($"{searchResult.Name} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                        string yesOrNo = Console.ReadLine();
                        if (yesOrNo == "y")
                        {
                            var deleteResult = phone.Delete(input);
                            if (deleteResult)
                                flag = false;
                            if (!deleteResult)
                            {
                                string userDesicon = "";

                                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                                System.Console.WriteLine("* Yeniden denemek için      : (2)");
                                userDesicon = Console.ReadLine();
                                if (userDesicon == "1")
                                    flag = false;

                                if (userDesicon == "2")
                                {

                                }

                            }
                        }

                    }

                }


            }
            static void Update()
            {
                bool flag = true;
                while (flag)
                {
                    System.Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string nameOrSurname = Console.ReadLine();
                    var result = phone.Search(nameOrSurname);
                    if (result == null)
                    {

                        string userDesicon = "";

                        System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        System.Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                        System.Console.WriteLine("* Yeniden denemek için      : (2)");
                        userDesicon = Console.ReadLine();
                        if (userDesicon == "1")
                            flag = false;

                        if (userDesicon == "2")
                        {

                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Degiştirmek istediğiniz Özellikleri tuşlayın.:");
                        System.Console.WriteLine("İsim için      (1): ");
                        System.Console.WriteLine("Soy İsim için  (2): ");
                        System.Console.WriteLine("Numara için    (3): ");

                        string userChooses = Console.ReadLine();
                        Person p = new();
                        foreach (var item in userChooses)
                        {
                            if (item == '1')
                            {
                                System.Console.Write("Yeni isim ..:");
                                p.Name = Console.ReadLine();
                            }
                            else if (item == '2')
                            {
                                System.Console.Write("Yeni soy isim ..: ");
                                p.SurName = Console.ReadLine();
                            }
                            else if (item == '3')
                            {
                                System.Console.Write("Yeni numara ..: ");
                                p.Number = Console.ReadLine();
                            }
                        }

                        System.Console.WriteLine("Güncellemek istediğinizden eminmisiniz..:(y)/(n)");
                        string userDesicon = Console.ReadLine();
                        if (userDesicon == "y")
                        {
                            phone.Update(p, result);
                            flag = false;

                        }
                        else
                        {
                            System.Console.WriteLine("Devam etmek istiyormusunuz..:(y)/(n)");
                            string userDesiconForContinue = Console.ReadLine();

                            if (userDesiconForContinue == "n")
                            {
                                flag = false;
                            }
                        }
                    }
                }
            }
            static void GetList()
            {
                System.Console.WriteLine("***************Telefon Rehberi****************");
                foreach (var item in phone.GetList())
                {
                    System.Console.WriteLine("İsim:" + item.Name);
                    System.Console.WriteLine("Soy isim:" + item.SurName);
                    System.Console.WriteLine("Numara:" + item.Number);
                    System.Console.WriteLine("-");
                }
            }
            static void Search()
            {
                bool flag = true;
                while (flag)
                {
                    System.Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
                    System.Console.WriteLine("****************************************");

                    System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                    System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

                    string userChoose = Console.ReadLine();
                    Person p = new();
                    if (userChoose == "1")
                    {
                        System.Console.Write("İsim veya soyisim giriniz: ");
                        string userNameOrSurname = Console.ReadLine();
                        var result = phone.Search(userNameOrSurname);
                        Person.Print(result);

                    }
                    else if (userChoose == "2")
                    {
                        System.Console.Write("Numara giriniz: ");
                        string userNumber = Console.ReadLine();
                        var result = phone.Search(userNumber);
                        Person.Print(result);
                    }
                    flag = false;
                }
            }

        }
    }
}
