using System;

namespace Proje2_ToDoUygulamasi
{

    class Employee
    {
        private string _id;
        private string _name;
        private string _surname;
        public Employee(string id, string name, string surname)
        {
            _name = name;
            _surname = surname;
            Id = id;
        }

        public Employee(string id)
        {
            Id = id;
        }
        public Employee()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Id { get => _id; set => _id = value; }

        public static Employee[] employee = {
            new Employee("1","Fahrican","Kaçan"),
            new Employee("2","Bilbo","Bagins"),
            new Employee("3","Ronona","Zoro"),
            new Employee("4","Arnold","Schwarzenegger"),
        };
    }
}