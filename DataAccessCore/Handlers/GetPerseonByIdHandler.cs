using DataAccessCore.DataAccess.Interfaces;
using DataAccessCore.ExceptionHandlers;
using DataAccessCore.Models;
using DataAccessCore.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Handlers
{
	public class GetPerseonByIdHandler:IRequestHandler<GetPersonByIdQuery,Person>
	{
        private readonly IMediator _mediator;
		public GetPerseonByIdHandler(IMediator mediator)
		{
			_mediator = mediator;
		}

		public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
		{

			var persons = await _mediator.Send(new GetPersonsListQuery(), cancellationToken);

			var person = persons.FirstOrDefault(p => p.Id == request.id);

			return person == null ? throw new NotFoundException($"Person with ID {request.id} not found.") : person;
		}
	}
}
