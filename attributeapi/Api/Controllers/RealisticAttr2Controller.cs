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
    public class RealisticAttr2Controller : AttributeBaseController<RealisticAttr2, RealisticAttrViewModel>
    {
        public RealisticAttr2Controller(IAttributeService<RealisticAttr2> attributeService) : base(attributeService)
        { }
    }
}