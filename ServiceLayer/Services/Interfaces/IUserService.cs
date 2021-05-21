using ServiceLayer.Models.Form.User;
using ServiceLayer.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IUserService : IService<UserForm, VUser, int>
    {
        /// <summary>
        /// Function to for Login
        /// </summary>
        /// <param name="form">LoginForm</param>
        /// <returns>VUser</returns>
        VUser Login(LoginForm form);
        /// <summary>
        /// Function to reset a password
        /// </summary>
        /// <param name="form">Reset¨Password</param>
        /// <returns>bool</returns>
        bool ResetPassword(ResetPassword form);
        /// <summary>
        /// Function to switch active User
        /// </summary>
        /// <param name="Id">Int id of User</param>
        /// <returns>bool</returns>
        bool SwitchActive(int Id);

        /// <summary>
        /// Function to update an User
        /// </summary>
        /// <param name="form">UserForm</param>
        /// <returns>VUser</returns>
        VUser Update(UserForm form);
        /// <summary>
        /// Function to change role
        /// </summary>
        /// <param name="Id">Id of user</param>
        /// <param name="IdRole">Id of role</param>
        /// <returns>bool</returns>
        bool UpdateRoleChange(int Id, int IdRole);
    }
}
