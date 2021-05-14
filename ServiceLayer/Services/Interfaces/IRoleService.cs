using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IRoleService : IService<Role, Role, int>
    {
        /// <summary>
        /// Function delete a role
        /// </summary>
        /// <param name="Id">Int of role</param>
        /// <returns>Bool</returns>
        bool Delete(int Id);
        /// <summary>
        /// Function to update role
        /// </summary>
        /// <param name="body">Role</param>
        /// <returns>Role</returns>
        Role Update(Role body);
    }
}
