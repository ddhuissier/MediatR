using MediatR;

namespace MediatRLib.Commands
{
     public record InsertPersonCommand(string FirstName, string LastName) : IRequest<Person>;
    //public class InsertPersonCommand : IRequest<Person>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public InsertPersonCommand(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}
}
