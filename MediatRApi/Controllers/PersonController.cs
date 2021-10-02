﻿using MediatR;
using MediatRLib;
using MediatRLib.Commands;
using MediatRLib.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<Person>> Get() => await _mediator.Send(new GetPersonListQuery());

        //public async Task<List<Person>> Get()
        //{
        //    return await _mediator.Send(new GetPersonListQuery());
        //}

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<Person> Get(int id) => await _mediator.Send(new GetPersonByIdQuery(id));

        //public async Task<Person> Get(int id)
        //{
        //    return await _mediator.Send(new GetPersonByIdQuery(id));
        //}

        // POST api/<PersonController>
        [HttpPost]
        public async Task<Person> Post([FromBody] Person value)
        {
            var model = new InsertPersonCommand(value.FirstName, value.LastName);
            return await _mediator.Send(model);
        }

    }
}
