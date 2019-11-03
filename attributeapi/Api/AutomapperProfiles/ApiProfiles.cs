using Api.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.AutomapperProfiles
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                Mapper.Initialize(ConfigAction);
            });
        }

        public static Action<IMapperConfigurationExpression> ConfigAction = cfg =>
        {
            cfg.AddProfile<ApiProfiles>();
        };
    }

    public class ApiProfiles : Profile
    {
        public ApiProfiles()
        {
            CreateMap<SimpleAttrViewModel, Data.SimpleAttr>().ReverseMap();
        }
    }
}
