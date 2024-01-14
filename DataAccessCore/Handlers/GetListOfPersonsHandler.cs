using DataAccessCore.DataAccess.Implementation;
using DataAccessCore.DataAccess.Interfaces;
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
	public class GetListOfPersonsHandler:IRequestHandler<GetPersonsListQuery , List<Person>>
	{
		private readonly IDataAccessDemo _data;

		public GetListOfPersonsHandler(IDataAccessDemo data)
		{
			_data = data;
		}

		public Task<List<Person>> Handle(GetPersonsListQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_data.GetListOfPerson());
		}
	}
}
