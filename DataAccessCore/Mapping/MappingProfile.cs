using AutoMapper;
using DataAccessCore.DTOS;
using DataAccessCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Mapping
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<Person, AddPersonDto>().ReverseMap();
		}
	}
}
