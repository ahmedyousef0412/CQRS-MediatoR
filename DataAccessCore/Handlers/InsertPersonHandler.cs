using AutoMapper;
using DataAccessCore.Commands;
using DataAccessCore.DataAccess.Interfaces;
using DataAccessCore.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Handlers
{
	public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, Person>
	{
		private readonly IDataAccessDemo _data;
		private readonly IMapper _map;
		public InsertPersonHandler(IDataAccessDemo data, IMapper map)
		{
			_data = data;
			_map = map;
		}
		public Task<Person> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
		{

			var person = _map.Map<Person>(request.PersonDto);

			return Task.FromResult(_data.InsertPerson(person));
		}
	}
}
