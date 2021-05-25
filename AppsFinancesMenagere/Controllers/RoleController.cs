using AppsFinancesMenagere.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppsFinancesMenagere.Mappers;
using Swashbuckle.AspNetCore.Annotations;
using AppsFinancesMenagere.Models.Form.Role;
using Microsoft.AspNetCore.Authorization;

namespace AppsFinancesMenagere.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Authorize(Roles = "Tresorie")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRoleService _service;
        public RoleController(IRoleService service)
        {
            _service = service;
        }
        /// <summary>
        /// Function to return a list of role
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        [SwaggerOperation("Get All Role")]
        [SwaggerResponse(200, "Return a lis of role", typeof(Role))]
        public IActionResult GetAll()
        {
            List<Role> roles = _service.GetAll().Select((r) => r.ToApiRole()).ToList();
            return Ok(roles);
        }
        /// <summary>
        /// Function to return one role
        /// </summary>
        /// <param name="Id">id of role</param>
        /// <returns>IActionResult</returns>
        [HttpGet("{Id}")]
        [SwaggerOperation("Get one Role")]
        [SwaggerResponse(200, "Return one Role", typeof(Role))]
        public IActionResult Get([FromRoute,SwaggerParameter("Id of Role",Required = true)] int? Id)
        {
            if (Id == null) return Ok(0);
            Role role = _service.Get((int)Id).ToApiRole();
            return Ok(role);
        }
        /// <summary>
        /// Function to insert a new role
        /// </summary>
        /// <param name="form">RoleForm</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [SwaggerOperation("Insert a new Role")]
        [SwaggerResponse(200,"Return an int of id created",typeof(int))]
        [SwaggerResponse(400,"Error raise during insertion")]
        public IActionResult Insert([FromBody,SwaggerRequestBody("Form to create a new role",Required = true)] RoleForm form)
        {
            try
            {
                int idCreated = _service.Create(form.ToServiceLayerRoleInsert());
                return Ok(idCreated);
            }
            catch(ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }

        }
        /// <summary>
        /// Function to update a Role
        /// </summary>
        /// <param name="form">Role</param>
        /// <returns>Role</returns>
        [HttpPut]
        [SwaggerOperation("Update a role")]
        [SwaggerResponse(200,"Return a role updated",typeof(Role))]
        [SwaggerResponse(400,"Error raise during Update or Bill not find")]
        public IActionResult Update([FromBody,SwaggerRequestBody("Form to update a role",Required = true)]Role form)
        {
            try
            {
               Role role = _service.Update(form.ToServiceLayerRoleUpdate()).ToApiRole();
               return Ok(role);
            }
            catch(ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        /// <summary>
        /// Function to delete a role
        /// </summary>
        /// <param name="Id">id of role</param>
        /// <returns>bool</returns>
        [HttpDelete("{Id}")]
        [SwaggerOperation("Delete a role")]
        [SwaggerResponse(200,"Return bool",typeof(bool))]
        [SwaggerResponse(400, "Error raise during Update or Bill not find")]
        public IActionResult Delete([FromRoute,SwaggerParameter("Id of Role",Required = true)]int Id)
        {
            try
            {
                bool isDeleted = _service.Delete(Id);
                return Ok(isDeleted);
            }
            catch(ArgumentException e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}
