using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje1_ConsoleTelefonRehberi
{

    class Phone : Crud
    {
        static List<Person> phoneList = new();

        List<Person> stockPhoneList = new List<Person>{
               new Person("Monkey","Luffy","15343"),
               new Person("Ronnoa","Zoro","123412"),
               new Person("Chopper","merry","123412"),
               new Person("Nami","a","2342"),
               new Person("Robin","r","634512")
            };

        public Phone()
        {
            phoneList.AddRange(stockPhoneList);
        }


        public void Add(Person person)
        {
            phoneList.Add(person);
        }

        public bool Delete(string personNameOrSurname)
        {

            var person = phoneList.Find(x => x.Name == personNameOrSurname || x.SurName == personNameOrSurname);
            if (person != null)
            {
                phoneList.Remove(person);
                return true;
            }
            return false;
        }

        public List<Person> GetList()
        {
            return phoneList;
        }

        public Person Search(string personsNameOrNumberOrSurname)
        {
            return phoneList.Find(x => x.Name == personsNameOrNumberOrSurname || x.SurName == personsNameOrNumberOrSurname || x.Number == personsNameOrNumberOrSurname);
        }

        public List<Person> SearchAll(string personsNameOrNumberOrSurname)
        {
            return phoneList.FindAll(x => x.Name == personsNameOrNumberOrSurname || x.SurName == personsNameOrNumberOrSurname || x.Number == personsNameOrNumberOrSurname);
        }

        public void Update(Person person, Person oldPerson)
        {
            var beforeUpdatePerson = phoneList.Find(x => x.Id == oldPerson.Id);
            beforeUpdatePerson.Name = person.Name;
            beforeUpdatePerson.SurName = person.SurName;
            beforeUpdatePerson.Number = person.Number;
        }




    }
}

