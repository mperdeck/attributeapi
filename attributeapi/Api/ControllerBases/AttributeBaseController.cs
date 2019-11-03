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
    [Route("api/[controller]/{id?}")]
    [ApiController]
    public class AttributeBaseController<T, VM> : Controller
        where T: class
        where VM: class
    {
        private readonly IAttributeService<T> _attributeService;

        public AttributeBaseController(IAttributeService<T> attributeService)
        {
            _attributeService = attributeService;
        }

        [HttpGet]
        public IActionResult Get(Guid id)
        {
            var data = _attributeService.Get(id);
            var viewData = Mapper.Map<T, VM>(data);
            return Ok(viewData);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _attributeService.Delete(id);
            return Ok();
        }

        /// <summary>
        /// Post is used to insert records
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] VM viewModel)
        {
            var data = Mapper.Map<VM, T>(viewModel);
            _attributeService.Add(data);

            // Exception handling goes here - leading to 500 (if Exception) or BadRequest (if ApplicationException)

            return Ok();
        }

        /// <summary>
        /// Put is used to update records
        /// </summary>
        /// <param name="viewModelData"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromBody] VM viewModel)
        {
            var data = Mapper.Map<VM, T>(viewModel);
            _attributeService.Update(data);

            // Exception handling goes here - leading to 500 (if Exception) or BadRequest (if ApplicationException)

            return Ok();
        }
    }
}
