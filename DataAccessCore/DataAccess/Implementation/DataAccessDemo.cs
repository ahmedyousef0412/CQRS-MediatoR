using DataAccessCore.DataAccess.Interfaces;
using DataAccessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.DataAccess.Implementation
{
	public class DataAccessDemo : IDataAccessDemo
	{

		private List<Person> persons = new();

        public DataAccessDemo()
        {
			persons.Add(new Person { Id = 1, FirstName = "Ahmed", LastName = "Yousef" ,Address ="Cairo" , Age = 27 });
			persons.Add(new Person { Id = 2, FirstName = "Omer", LastName = "Yousef", Address = "Alex", Age = 23 });
		}
        public List<Person> GetListOfPerson()
		{
			return persons;
		}

		public Person InsertPerson(Person person)
		{

			Person newPerson = new()
			{
				FirstName = person.FirstName,
				LastName = person.LastName,
				Address = person.Address,
				Age = person.Age
			};

			newPerson.Id = persons.Max(x => x.Id) + 1;

			persons.Add(newPerson);

			return newPerson;
		}
	}
}
