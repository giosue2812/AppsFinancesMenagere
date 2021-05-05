using AppsFinancesMenagere.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using AppsFinancesMenagere.Mappers;
using System.Linq;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;
using AppsFinancesMenagere.Models.Form.Organizations;
using System;

namespace AppsFinancesMenagere.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private IOrganizationService _service;
        public OrganizationController(IOrganizationService service)
        {
            _service = service;
        }
        /// <summary>
        /// Function to Get all Organization
        /// </summary>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Get all Organization")]
        [SwaggerResponse(200,"Return a list of Organization",typeof(OrganizationGet))]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<OrganizationGet> organizations = _service.GetAll().Select((o) => o.ToApi()).ToList();
            return Ok(organizations);
        }
        /// <summary>
        /// Funtion to get an Organization
        /// </summary>
        /// <param name="Id">Int id of Organization</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Get Organization")]
        [SwaggerResponse(200,"Return an Organization",typeof(OrganizationGet))]
        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute,SwaggerParameter("Id of Organization",Required = true)]int Id)
        {
            OrganizationGet organization = _service.Get(Id).ToApi();
            return Ok(organization);
        }
        /// <summary>
        /// Function to insert a new Organization
        /// </summary>
        /// <param name="form">OrganizationForm</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Insert a new Organization")]
        [SwaggerResponse(200,"Return an Organization",typeof(int))]
        [SwaggerResponse(400, "Error raise during insertion")]
        [HttpPost]
        public IActionResult Insert([FromBody,SwaggerRequestBody("Form to add an organization",Required = true)]OrganizationForm form)
        {
            try
            {
                int idCreated = _service.Create(form.ToServiceLayer());
                return Ok(idCreated);
            }
            catch(ArgumentNullException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        /// <summary>
        /// Function to update an organization 
        /// </summary>
        /// <param name="form">OrganizationUpdate</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Update an organization")]
        [SwaggerResponse(200,"Return update organization",typeof(OrganizationGet))]
        [SwaggerResponse(400, "Error raise during Update or Bill not find")]
        [HttpPut]
        public IActionResult Update([FromBody,SwaggerRequestBody("Form to update an organization",Required = true)]OrganizationUpdate form)
        {
            try
            {
                OrganizationGet organization = _service.Update(form.ToServiceLayer()).ToApi();
                return Ok(organization);
            }
            catch(ArgumentNullException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        /// <summary>
        /// Function to switch IsActive of Organization
        /// </summary>
        /// <param name="Id">Id of Organization</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Switch the 'IsActive' of Organization")]
        [SwaggerResponse(200,"Return a Bool",typeof(bool))]
        [SwaggerResponse(400, "Error raise during Update or Bill not find")]
        [HttpGet("switch/{Id}")]
        public IActionResult SwitchIsActive([FromRoute,SwaggerParameter("Int id of Organization",Required = true)]int Id)
        {
            try
            {
                bool IsActive = _service.SwitchIsActive(Id);
                return Ok(IsActive);
            }
            catch(ArgumentNullException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}
