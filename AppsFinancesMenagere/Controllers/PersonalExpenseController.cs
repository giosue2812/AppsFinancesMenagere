using AppsFinancesMenagere.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppsFinancesMenagere.Mappers;
using AppsFinancesMenagere.Models.Form.PersonalExpense;

namespace AppsFinancesMenagere.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalExpenseController : ControllerBase
    {
        private IPersonalExpenseService _service;
        public PersonalExpenseController(IPersonalExpenseService service)
        {
            _service = service;
        }
        [SwaggerOperation("Get all personal expense")]
        [SwaggerResponse(200, "Return list of personal expense", typeof(PersonalExpense))]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<PersonalExpense> personalExpenses = _service.GetAll().Select(p => p.ToApiPersonalExpense()).ToList();
            return Ok(personalExpenses);
        }
        [SwaggerOperation("Get one personal expense")]
        [SwaggerResponse(200, "Return one personal expense", typeof(PersonalExpense))]
        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute,SwaggerParameter("Id of User",Required = true)] int Id)
        {
            PersonalExpense personalExpense = _service.Get(Id).ToApiPersonalExpense();
            return Ok(personalExpense);
        }
        [SwaggerOperation("Insert new Expense")]
        [SwaggerResponse(200,"Return id of expense created",typeof(int))]
        [SwaggerResponse(400,"Error raise durin insert expense")]
        [HttpPost]
        public IActionResult InsertExpense([FromBody,SwaggerRequestBody("Form to insert new Expense",Required = true)]PersonalExpenseForm form)
        {
            try
            {
                int idCreated = _service.Create(form.ToServiceLayerPersonalExpense());
                return Ok(idCreated);
            }
            catch(ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}
