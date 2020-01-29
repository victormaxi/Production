using AutoMapper;
using Production.Api.Core.Models;
using Production.Api.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Production.Api.Core.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterDTO, User>();
            CreateMap<UserDTO, User>();
            CreateMap<UpdateDTO, User>();
 
    }
    }
}
