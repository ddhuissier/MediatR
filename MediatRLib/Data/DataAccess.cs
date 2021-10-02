using System;
using System.Collections.Generic;
using System.Linq;

namespace MediatRLib
{
    public class DataAccess : IDataAccess
    {
        public List<Person> people = new();
        public DataAccess()
        {
            people.Add(new Person { Id = 1, FirstName = "Davy", LastName = "D'HUISSIER" });
            people.Add(new Person { Id = 2, FirstName = "Ben", LastName = "Crow" });
        }

        public List<Person> GetPeople()
        {
            return people;
        }

        //public Person GetPeopleById(int id)
        //{
        //    return people.FirstOrDefault(x=> x .Id == id);
        //}

        public Person InsertPerson(string firtsName, string lastName)
        {
            Person p = new() { FirstName = firtsName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }

    }
}
