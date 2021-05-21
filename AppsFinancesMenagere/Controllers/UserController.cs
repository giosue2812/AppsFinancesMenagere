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
using AppsFinancesMenagere.Models.Form.User;

namespace AppsFinancesMenagere.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        [SwaggerOperation("Get all User")]
        [SwaggerResponse(200, "Return a list of user", typeof(VUser))]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<VUser> users = _service.GetAll().Select((u) => u.ToApiUser()).ToList();
            return Ok(users);
        }
        [SwaggerOperation("Get one user")]
        [SwaggerResponse(200, "Return one user", typeof(VUser))]
        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute, SwaggerParameter("Id of User")] int Id)
        {
            VUser user = _service.Get(Id).ToApiUser();
            return Ok(user);
        }
        [SwaggerOperation("Update an User")]
        [SwaggerResponse(200, "Return updated's user", typeof(VUser))]
        [SwaggerResponse(400, "Error raise during update")]
        [HttpPut]
        public IActionResult Update([FromBody, SwaggerRequestBody("Form to update an User")] UserForm form)
        {
            try
            {
                VUser user = _service.Update(form.ToServiceLayerUserFormUpdate()).ToApiUser();
                return Ok(user);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("Reset Password")]
        [SwaggerResponse(200, "Return bool", typeof(bool))]
        [SwaggerResponse(400, "Error during reset Password")]
        [HttpPut("ResetPassword")]
        public IActionResult ResetPassword([FromBody, SwaggerRequestBody("Reset Password form")] ResetPassword form)
        {
            try
            {
                bool isReset = _service.ResetPassword(form.ToServiceLayerResetPassword());
                return Ok(isReset);
            }
            catch (ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        [SwaggerOperation("Switch Active User")]
        [SwaggerResponse(200, "Return bool", typeof(bool))]
        [SwaggerResponse(400, "Error during the switch")]
        [HttpGet("SwitchActive/{Id}")]
        public IActionResult SwitchActiveUser([FromRoute, SwaggerParameter("Id of User")] int Id)
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
        [SwaggerOperation("Change role")]
        [SwaggerResponse(200,"Return bool")]
        [SwaggerResponse(400,"Error raise during change role")]
        [HttpGet("RoleChange/{Id}/{IdRole}")]
        public IActionResult UpdateRoleChange([FromRoute,SwaggerParameter("id of user")] int Id, [FromRoute,SwaggerParameter("id of role")]int IdRole)
        {
            try
            {
                bool isChange = _service.UpdateRoleChange(Id, IdRole);
                return Ok(isChange);
            }
            catch(ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}
