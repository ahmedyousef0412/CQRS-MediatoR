using DataAccessCore.DTOS;
using DataAccessCore.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Commands
{
	public record InsertPersonCommand(AddPersonDto PersonDto):IRequest<Person>;
	
}
