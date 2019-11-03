using Api.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.AutomapperProfiles
{
    public class ApiProfiles : Profile
    {
        public ApiProfiles()
        {
            CreateMap<SimpleAttrViewModel, Data.SimpleAttr>().ReverseMap();
        }
    }
}
