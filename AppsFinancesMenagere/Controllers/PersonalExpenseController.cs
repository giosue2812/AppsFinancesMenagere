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
using Microsoft.AspNetCore.Authorization;

namespace AppsFinancesMenagere.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
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
        [Authorize(Roles = "Tresorie")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<PersonalExpense> personalExpenses = _service.GetAll().Select(p => p.ToApiPersonalExpense()).ToList();
            return Ok(personalExpenses);
        }
        [SwaggerOperation("Insert new Expense")]
        [SwaggerResponse(200,"Return id of expense created",typeof(int))]
        [SwaggerResponse(400,"Error raise durin insert expense")]
        [Authorize(Roles = "Default,Tresorie,Course")]
        [HttpPost]
        public IActionResult InsertExpense([FromBody,SwaggerRequestBody("Form to insert new Expense",Required = true)]PersonalExpenseForm form)
        {
            try
            {
                int idCreated = _service.Create(form.ToServiceLayerPersonalExpense());
                return Ok(idCreated);
            }
            catch(Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("Get expense by user")]
        [SwaggerResponse(200,"Return list of expense by user")]
        [Authorize(Roles = "Default,Tresorie,Course")]
        [HttpGet("ExpenseByUser/{Id}")]
        public IActionResult GetExpenseUser([FromRoute,SwaggerParameter("Id of user")]int Id)
        {
            List<PersonalExpense> personalExpenses = _service.GetExpenseByUser(Id).Select(p => p.ToApiPersonalExpense()).ToList();
            return Ok(personalExpenses);
        }
    }
}
