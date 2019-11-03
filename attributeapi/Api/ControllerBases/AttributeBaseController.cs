using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Services;
using AutoMapper;

namespace Api.ControllerBases
{
    public class AttributeBaseController<T, VM> : Controller
        where T: class
        where VM: class
    {
        private readonly IAttributeService<T> _attributeService;
        private readonly IMapper _mapper; // automapper

        public AttributeBaseController(IAttributeService<T> attributeService, IMapper mapper)
        {
            _attributeService = attributeService;
            _mapper = mapper;
        }

        public IActionResult Get(Guid externalId)
        {
            var data = _attributeService.Get(externalId);
            var viewData = _mapper.Map<T>(data);
            return Ok(viewData);
        }

        public IActionResult Delete(Guid externalId)
        {
            _attributeService.Delete(externalId);
            return Ok();
        }

        /// <summary>
        /// Post is used to insert records
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public IActionResult Post(VM viewModel)
        {
            var data = _mapper.Map<T>(viewModel);
            _attributeService.Add(data);

            // Exception handling goes here - leading to 500 (if Exception) or BadRequest (if ApplicationException)

            return Ok();
        }

        /// <summary>
        /// Put is used to update records
        /// </summary>
        /// <param name="viewModelData"></param>
        /// <returns></returns>
        public IActionResult Put(VM viewModel)
        {
            var data = _mapper.Map<T>(viewModel);
            _attributeService.Update(data);

            // Exception handling goes here - leading to 500 (if Exception) or BadRequest (if ApplicationException)

            return Ok();
        }
    }
}
