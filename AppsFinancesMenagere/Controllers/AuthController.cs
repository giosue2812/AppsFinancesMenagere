using AppsFinancesMenagere.Mappers;
using AppsFinancesMenagere.Models;
using AppsFinancesMenagere.Models.Form.User;
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
    [AllowAnonymous]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserService _service;
        private IAccountService _accountService;
        private IRoleService _roleService;
        private TokenManager _tokenManager;
        public AuthController(IUserService service, IAccountService accountService,IRoleService roleService,TokenManager tokenManager)
        {
            _service = service;
            _accountService = accountService;
            _roleService = roleService;
            _tokenManager = tokenManager;
        }

        [SwaggerOperation("Insert a new user")]
        [SwaggerResponse(200, "Int id of new User", typeof(int))]
        [SwaggerResponse(400, "Error raise during insertion")]
        [HttpPost("register")]
        public IActionResult Insert([FromBody, SwaggerRequestBody("Form to insert a new User")] UserFormInsert form)
        {
            try
            {
                int idCreated = _service.Create(form.ToServiceLayerUserForm());
                return Ok(idCreated);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("Login for user")]
        [SwaggerResponse(200,"Return user connected",typeof(VUser))]
        [SwaggerResponse(400, "Password or email is invalid")]
        [HttpPost]
        public IActionResult Login([FromBody,SwaggerRequestBody("Form login user")]LoginForm form)
        {
            try
            {
                UserAuth userAuth = new UserAuth();
                VUser user = _service.Login(form.ToServiceLayerLogin()).ToApiUser();
                userAuth.Email = user.Email;
                userAuth.IdUser = user.Id;

                userAuth.IdAccount = _accountService.GetPersonalAccount(user.Id);
                userAuth.Role = _roleService.Get((int)user.IdRole).ToApiRole().RLabel;
                string token = _tokenManager.GenerateJwt(userAuth);
                return Ok(token);
            }
            catch(Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}
