using AppsFinancesMenagere.Mappers;
using AppsFinancesMenagere.Models;
using AppsFinancesMenagere.Models.Form.SensibleData;
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
        [HttpGet]
        public IActionResult GetAll()
        {
            List<SensibleDataGetByOrganization> sensibleDataGetByOrganizations = _service.GetAll().Select((s) => s.ToApi()).ToList();
            return Ok(sensibleDataGetByOrganizations);
        }
        [SwaggerOperation("Get SensibleData for Organization")]
        [SwaggerResponse(200,"Return a SensibleData for Organization",typeof(SensibleDataGetByOrganization))]
        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute,SwaggerParameter("Id of SensibleData",Required = true)]int Id)
        {
            SensibleDataGetByOrganization sensibleDataGetByOrganization = _service.Get(Id).ToApi();
            return Ok(sensibleDataGetByOrganization);
        }
        [SwaggerOperation("Insert a new Sensible Data")]
        [SwaggerResponse(200, "Return an Id of Sensible Data Created", typeof(int))]
        [SwaggerResponse(400, "Error raise during the insertion")]
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
    }
}
