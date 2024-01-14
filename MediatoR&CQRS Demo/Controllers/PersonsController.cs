using DataAccessCore.Commands;
using DataAccessCore.DTOS;
using DataAccessCore.Models;
using DataAccessCore.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatoR_CQRS_Demo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonsController(IMediator mediator) : ControllerBase
	{
        private readonly IMediator _mediator = mediator;

		[HttpGet]
		public async Task<List<Person>> GetPersons()
		{
			return await _mediator.Send(new GetPersonsListQuery());
		}

		[HttpGet("{id}")]
		public async Task<Person> GetPersonById(int id)
		{
			return await _mediator.Send(new GetPersonByIdQuery(id));
		}

		[HttpPost]
		public async Task<Person> AddPerson([FromBody]AddPersonDto dto)
		{
			var model = new InsertPersonCommand(dto);

			return await _mediator.Send(model);
		}
    }
}
