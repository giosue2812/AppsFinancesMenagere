using AppsFinancesMenagere.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppsFinancesMenagere.Mappers;
using ServiceLayer.Services.Interfaces;
using AppsFinancesMenagere.Models.Form.Account;
using Microsoft.AspNetCore.Authorization;

namespace AppsFinancesMenagere.Controllers
{   
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _service;
        private IUserService _userService;
        public AccountController(IAccountService service, IUserService serviceUser)
        {
            _userService = serviceUser;
            _service = service;
        }
        [SwaggerOperation("GetAll Account")]
        [SwaggerResponse(200, "Return a list of Account", typeof(Account))]
        [Authorize(Roles = "Tresorie")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Account> accounts = _service.GetAll().Select((a) => a.ToApiAccount()).ToList();
            return Ok(accounts);
        }
        [SwaggerOperation("Get one Account")]
        [SwaggerResponse(200, "Return one Account", typeof(Account))]
        [Authorize(Roles = "Default,Tresorie,Course")]
        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute, SwaggerParameter("Id of Account")] int Id)
        {
            Account account = _service.Get(Id).ToApiAccount();
            return Ok(account);
        }
        [SwaggerOperation("Insert a new Account")]
        [SwaggerResponse(200, "Return Id created", typeof(int))]
        [SwaggerResponse(400, "Error raise during insertion")]
        [Authorize(Roles = "Tresorie")]
        [HttpPost]
        public IActionResult Insert([FromBody, SwaggerRequestBody("Form to insert an Account")] AccountForm form)
        {
            try
            {
                int idCreated = _service.Create(form.ToServiceLayerAccountFormInsert());
                return Ok(idCreated);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("Update an Account")]
        [SwaggerResponse(200, "Return user updated", typeof(Account))]
        [SwaggerResponse(400, "Error raise during update")]
        [Authorize(Roles = "Tresorie")]
        [HttpPut]
        public IActionResult Update([FromBody, SwaggerRequestBody("Form to update an Account", Required = true)] AccountFormUpdate form)
        {
            try
            {
                Account account = _service.Update(form.ToServiceLayerAccountFormUpdate()).ToApiAccount();
                return Ok(account);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("Add Mandatary for Account")]
        [SwaggerResponse(200, "Return account with mandatary", typeof(Account))]
        [SwaggerResponse(400, "Error raise during insert mandatary")]
        [Authorize(Roles = "Tresorie")]
        [HttpGet("mandatary/{IdUser}/{IdAccount}")]
        public IActionResult AddMandatary([FromRoute, SwaggerParameter("Id of User", Required = true)] int IdUser, [FromRoute, SwaggerParameter("Id of Account", Required = true)] int IdAccount)
        {
            try
            {
                Account account = _service.AddMandatary(IdAccount, IdUser).ToApiAccount();
                return Ok(account);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("SwitchActive account")]
        [SwaggerResponse(200, "Return bool", typeof(bool))]
        [SwaggerResponse(400, "Error raise during switch active account")]
        [Authorize(Roles = "Tresorie")]
        [HttpGet("switchActive/{Id}")]
        public IActionResult SwitchActive([FromRoute, SwaggerRequestBody("Id of Account", Required = true)] int Id)
        {
            try
            {
                bool isActive = _service.SwitchActive(Id);
                return Ok(isActive);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("Get account by user mandatary")]
        [SwaggerResponse(200, "return a list of account by user mandatary", typeof(ListAccountByUserMandatary))]
        [Authorize(Roles = "Default,Tresorie,Course")]
        [HttpGet("GetAccountMandatary/{Id}")]
        public IActionResult GetAccountMandatary([FromRoute, SwaggerParameter("Id of User Mandatary")] int Id)
        {
            ListAccountByUserMandatary listAccountByUserMandatary = new ListAccountByUserMandatary();
            listAccountByUserMandatary.vAccountByMandataries = _service.GetAccountByMandatary(Id).Select(a => a.ToApiAccountByMandatary()).ToList();
            listAccountByUserMandatary.vUser = _userService.Get(Id).ToApiUser();
            return Ok(listAccountByUserMandatary);
        }
        [SwaggerOperation("Get account by user titular")]
        [SwaggerResponse(200, "return a list of account by user titular", typeof(ListAccountByUserTitular))]
        [Authorize(Roles = "Default,Tresorie,Course")]
        [HttpGet("GetAccountTitular/{Id}")]
        public IActionResult GetAccountTitular([FromRoute,SwaggerParameter("Id of User Titular")]int Id)
        {
            ListAccountByUserTitular listAccountByUserTitular = new ListAccountByUserTitular();
            listAccountByUserTitular.vAccountByTitulars = _service.GetAccountByTitular(Id).Select(a => a.ToApiAccountByTitular()).ToList();
            listAccountByUserTitular.vUser = _userService.Get(Id).ToApiUser();
            return Ok(listAccountByUserTitular);
        }
    }
}
