using AppsFinancesMenagere.Mappers;
using AppsFinancesMenagere.Models;
using AppsFinancesMenagere.Models.Form.SensibleData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class SensibleDataController : ControllerBase
    {
        private ISensibleDataService _service;
        public SensibleDataController(ISensibleDataService sevice)
        {
            _service = sevice;
        }
        [SwaggerOperation("GetAll SensibleData for Organization")]
        [SwaggerResponse(200,"Return a list of SensibleData for Organization",typeof(SensibleDataGetByOrganization))]
        [Authorize(Roles = "Tresorie")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<SensibleDataGetByOrganization> sensibleDataGetByOrganizations = _service.GetAll().Select((s) => s.ToApi()).ToList();
            return Ok(sensibleDataGetByOrganizations);
        }
        [SwaggerOperation("Get SensibleData for Organization")]
        [SwaggerResponse(200,"Return a SensibleData for Organization",typeof(SensibleDataGetByOrganization))]
        [Authorize(Roles = "Tresorie,Default,Course")]
        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute,SwaggerParameter("Id of SensibleData",Required = true)]int Id)
        {
            SensibleDataGetByOrganization sensibleDataGetByOrganization = _service.Get(Id).ToApi();
            return Ok(sensibleDataGetByOrganization);
        }
        [SwaggerOperation("Get one sensible data")]
        [SwaggerResponse(200,"Return one sensible data",typeof(SensibleData))]
        [Authorize(Roles = "Tresorie,Default,Course")]
        [HttpGet("sensibleData/{Id}")]
        public IActionResult GetSensibleData([FromRoute,SwaggerParameter("Id of SensibleData",Required = true)]int Id)
        {
            SensibleData sensible = _service.GetSensibleData(Id).ToApiSensibleData();
            return Ok(sensible);
        }
        [SwaggerOperation("Insert a new Sensible Data")]
        [SwaggerResponse(200, "Return an Id of Sensible Data Created", typeof(int))]
        [SwaggerResponse(400, "Error raise during the insertion")]
        [Authorize(Roles = "Tresorie,Default,Course")]
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Create([FromBody,SwaggerRequestBody("Form to add a Sensible data",Required =true)]SensibleDataForm form)
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
        [SwaggerOperation("Update Sensible Data")]
        [SwaggerResponse(200,"Return Sensible data with Organization",typeof(SensibleDataGetByOrganization))]
        [SwaggerResponse(400, "Error raise during the update")]
        [Authorize(Roles = "Tresorie,Default,Course")]
        [HttpPut]
        public IActionResult Update([FromBody,SwaggerRequestBody("Form to update a Sensible Data",Required = true)]SensibleDataUpdate form)
        {
            try
            {
                SensibleDataGetByOrganization sensibleDataGetByOrganization = _service.Update(form.ToServiceLayer()).ToApi();
                return Ok(sensibleDataGetByOrganization);
            }
            catch(ArgumentNullException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("Update Sensible Data")]
        [SwaggerResponse(200, "Return sensible data", typeof(SensibleData))]
        [SwaggerResponse(400, "Error raise during the update")]
        [Authorize(Roles = "Tresorie,Default,Course")]
        [HttpPut("updateSensibleData")]
        public IActionResult UpdateSensibleData([FromBody, SwaggerRequestBody("Form to update a sensible Data",Required = true)]SensibleDataUpdate form)
        {
            try
            {
                SensibleData sensibleData = _service.UpdateSensibleData(form.ToServiceLayer()).ToApiSensibleData();
                return Ok(sensibleData);
            }
            catch(ArgumentNullException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}
