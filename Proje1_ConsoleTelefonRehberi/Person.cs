using System;

namespace Proje1_ConsoleTelefonRehberi
{

    class Person
    {
        private string _id;
        private string _name;
        private string _surname;
        private string _number;

        public Person()
        {

        }
        public Person(string name, string surname, string number)
        {
            this._name = name;
            this._surname = surname;
            this._number = number;
        }
        public string Id { get { return _id; } set { _id = RandomId(); } }
        public string Name { get { return _name; } set { _name = value; } }
        public string SurName { get { return _surname; } set { _surname = value; } }
        public string Number { get { return _number; } set { _number = value; } }

        private string RandomId()
        {

            Guid guid = Guid.NewGuid();
            string str = guid.ToString();
            return str;
        }

        public static void Print(Person person)
        {
            if (person == null)
            {
                // System.Console.WriteLine("İsim    : {}");
                // System.Console.WriteLine("Soy İsim: {}");
                // System.Console.WriteLine("Numara  : {}");
                System.Console.WriteLine("Bir sonuç bulunamadı.");
            }
            else
            {
                System.Console.WriteLine("İsim    : {0}", person.Name);
                System.Console.WriteLine("Soy İsim: {0}", person.SurName);
                System.Console.WriteLine("Numara  : {0}", person.Number);
            }

        }
    }
}

