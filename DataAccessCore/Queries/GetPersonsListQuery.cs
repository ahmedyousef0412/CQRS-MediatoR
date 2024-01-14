using DataAccessCore.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Queries
{
	public record GetPersonsListQuery():IRequest<List<Person>>;
	
}
