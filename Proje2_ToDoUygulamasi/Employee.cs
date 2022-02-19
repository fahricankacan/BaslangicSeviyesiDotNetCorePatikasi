using System;

namespace Proje2_ToDoUygulamasi
{

    class Employee
    {
        private string _name;
        private string _surname;
        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public Employee()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
    }
}