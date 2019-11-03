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
    public class RealisticAttrController : AttributeBaseController<RealisticAttr, RealisticAttrViewModel>
    {
        public RealisticAttrController(IAttributeService<RealisticAttr> attributeService) : base(attributeService)
        { }
    }
}