using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IRoleRepository:IRepository<Role,Role,int>
    {
        /// <summary>
        /// Function to delete a Role
        /// </summary>
        /// <param name="Id">int id of role</param>
        /// <returns>bool</returns>
        bool Delete(int Id);
        /// <summary>
        /// Funtion to update a Role
        /// </summary>
        /// <param name="entity">Role</param>
        /// <returns>Role</returns>
        Role Update(Role entity);
    }
}
