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
    public class ComplexAttrController : AttributeBaseController<ComplexAttr, ComplexAttrViewModel>
    {
        public ComplexAttrController(ComplexAttributeService attributeService) : base(attributeService)
        { }
    }
}