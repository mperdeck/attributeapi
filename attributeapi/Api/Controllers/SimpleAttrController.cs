using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.ControllerBases;
using Api.Models;
using AutoMapper;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleAttrController : AttributeBaseController<SimpleAttr, SimpleAttrViewModel>
    {
        public SimpleAttrController(IAttributeService<SimpleAttr> attributeService, IMapper mapper) : base(attributeService, mapper)
        { }
    }
}