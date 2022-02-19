using System.Collections.Generic;

namespace Proje1_ConsoleTelefonRehberi
{

    interface Crud
    {
        void Add(Person person);
        bool Delete(string personNameOrSurname);
        void Update(Person person, Person oldPerson);
        List<Person> GetList();
        Person Search(string personsNameOrNumberOrSurname);

        List<Person> SearchAll(string personsNameOrNumberOrSurname);

    }
}
