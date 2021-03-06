using AppsFinancesMenagere.Mappers;
using AppsFinancesMenagere.Models;
using AppsFinancesMenagere.Models.Form.Bills;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppsFinancesMenagere.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [Authorize(Roles = "Tresorie")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private IBillService _service;
        public BillController(IBillService service)
        {
            _service = service;
        }
        /// <summary>
        /// Function To get all bill
        /// </summary>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Get All Bill")]
        [SwaggerResponse(200, "Return a List of Bill", typeof(BillGet))]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<BillGet> billGets = _service.GetAll().Select((b) => b.ToApi()).ToList();
            return Ok(billGets);
        }
        /// <summary>
        /// Function to get one bill
        /// </summary>
        /// <param name="id">int Id of bill</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Get One Bill By Id")]
        [SwaggerResponse(200, "Return One bill by id",typeof(BillGet))]
        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute, SwaggerParameter("Id of Bill", Required = true)] int Id)
        {
            BillGet billGet = _service.Get(Id).ToApi();
            return Ok(billGet);
        }
        /// <summary>
        /// Function to insert a new Bill
        /// </summary>
        /// <param name="form">BillForm</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Insert new Bill")]
        [SwaggerResponse(200, "Return Id was created", typeof(int))]
        [SwaggerResponse(400, "Error raise during insertion")]
        [HttpPost]
        public IActionResult Insert([FromBody, SwaggerRequestBody("Form to insert a new Bill", Required = true)] BillForm form)
        {
            try
            {
                int IdCreated = _service.Create(form.ToServiceLayer());
                return Ok(IdCreated);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        /// <summary>
        /// Function to update a Bill
        /// </summary>
        /// <param name="form">BillGet</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Update Bill")]
        [SwaggerResponse(200, "Return a bill updated", typeof(BillGet))]
        [SwaggerResponse(400, "Error raise during Update or Bill not find")]
        [HttpPut]
        public IActionResult Update([FromBody, SwaggerRequestBody("Form to update a Bill", Required = true)] BillUpdate form)
        {
            try
            {
                BillGet bill = _service.Update(form.ToServiceLayers()).ToApi();
                return Ok(bill);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        /// <summary>
        /// Funciton to delete a bill
        /// </summary>
        /// <param name="Id">Id of Bill</param>
        /// <returns></returns>
        [SwaggerOperation("Delete Bill")]
        [SwaggerResponse(200, "Return Bool",typeof(bool))]
        [SwaggerResponse(400, "Error raise during deletion or Bill not found")]
        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute,SwaggerParameter("Id of Bill to delete",Required = true)] int Id)
        {
            try
            {
                return Ok(_service.Delete(Id));
            }
            catch(ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        /// <summary>
        /// Function to pay a bill
        /// </summary>
        /// <param name="Id">int id of Bill</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Payement of Bill")]
        [SwaggerResponse(200,"Return a bool",typeof(bool))]
        [SwaggerResponse(400, "Error raise during deletion or Bill not found")]
        [HttpGet("payement/{Id}")]
        public IActionResult Payement([FromRoute,SwaggerParameter("Id of bill to delete",Required = true)]int Id)
        {
            try
            {
                return Ok(_service.Payement(Id));
            }
            catch(ArgumentNullException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        /// <summary>
        /// Function to add a Date Postponement
        /// </summary>
        /// <param name="form">BillDatePostponement</param>
        /// <returns>IActionResult</returns>
        [SwaggerOperation("Date postponement")]
        [SwaggerResponse(200,"Return bool",typeof(bool))]
        [SwaggerResponse(400, "Error raise during deletion or Bill not found")]
        [HttpPut("DatePostponement")]
        public IActionResult DatePostponement([FromBody,SwaggerRequestBody("Form to add a date postponement",Required = true)]BillDatePostponement form)
        {
            try
            {
                return Ok(_service.DatePostponement(form.ToServiceLayer()));
            }
            catch(ArgumentNullException e)
            {
                return new BadRequestObjectResult(e.Message);
            };
        }
    }
}
