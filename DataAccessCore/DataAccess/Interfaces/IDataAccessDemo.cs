using DataAccessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.DataAccess.Interfaces
{
	public interface IDataAccessDemo
	{
		List<Person> GetListOfPerson();

		Person InsertPerson(Person person);
	}
}
