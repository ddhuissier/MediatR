using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRLib.Queries
{
    public record GetPersonListQuery() : IRequest<List<Person>>;

    //public class GetPersonListQueryClass : IRequest<List<Person>>
    //    {
    //    }


}
