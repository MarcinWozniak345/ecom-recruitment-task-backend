using AutoMapper;
using Backend.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Mappings
{
    public class FootbalersMappingProfile : Profile
    {
        public FootbalersMappingProfile() 
        {
            CreateMap<Backend.Domain.Entities.Footballer, FootballerDTO>();
        }
    }
}
