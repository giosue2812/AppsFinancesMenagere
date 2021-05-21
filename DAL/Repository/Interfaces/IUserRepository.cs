using DAL.Models;
using DAL.Models.Form;
using DAL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IUserRepository:IRepository<UserForm, VUser, int>
    {
        /// <summary>
        /// Function login
        /// </summary>
        /// <param name="form">LoginForm</param>
        /// <returns>User</returns>
        VUser Login(LoginForm form);
        /// <summary>
        /// Function to reset password
        /// </summary>
        /// <param name="form">ResetPassword</param>
        /// <returns>ResetPassword</returns>
        bool ResetPassword(ResetPassword form);
        /// <summary>
        /// Function to switch active user
        /// </summary>
        /// <param name="Id">Id of User</param>
        /// <returns>bool</returns>
        bool SwitchActiveUser(int Id);
        /// <summary>
        /// Function to update an user
        /// </summary>
        /// <param name="entity">UserForm</param>
        /// <returns>User</returns>
        VUser Update(UserForm entity);
        /// <summary>
        /// Funciton to change role
        /// </summary>
        /// <param name="Id">id of user</param>
        /// <param name="IdRole">id of role</param>
        /// <returns>bool</returns>
        bool UpdateRoleUser(int Id, int IdRole);
    }
}
