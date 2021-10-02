using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRLib.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<Person>;

    //public class GetPersonByIdQuery : IRequest<List<Person>>
    //{
    //    public int Id { get; set; }
    //    public GetPersonByIdQuery(int id)
    //    {
    //        Id = id;
    //    }
    //}


}
