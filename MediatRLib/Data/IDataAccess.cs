using System.Collections.Generic;

namespace MediatRLib
{
    public interface IDataAccess
    {
        List<Person> GetPeople();
        Person InsertPerson(string firtsName, string lastName);
    }
}