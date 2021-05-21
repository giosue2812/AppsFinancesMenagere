using DAL.Repository.Interfaces;
using ServiceLayer.Mappers;
using ServiceLayer.Models.Form.User;
using ServiceLayer.Models.Views;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<VUser> GetAll()
        {
            return _repository.GetAll().Select((u) => u.ToServiceLayerUser());
        }
        public VUser Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayerUser();
        }
        public int Create(UserForm body)
        {
            return _repository.Create(body.ToDalUserForm());
        }
        /// <summary>
        /// Function to update an User
        /// </summary>
        /// <param name="form">UserForm</param>
        /// <returns>VUser</returns>
        public VUser Update(UserForm form)
        {
            return _repository.Update(form.ToDalUserFormUpdate()).ToServiceLayerUser();
        }
        /// <summary>
        /// Function to for Login
        /// </summary>
        /// <param name="form">LoginForm</param>
        /// <returns>VUser</returns>
        public VUser Login(LoginForm form)
        {
            return _repository.Login(form.ToDalLogin()).ToServiceLayerUser();
        }
        /// <summary>
        /// Function to reset a password
        /// </summary>
        /// <param name="form">Reset¨Password</param>
        /// <returns>bool</returns>
        public bool ResetPassword(ResetPassword form)
        {
            return _repository.ResetPassword(form.ToDalResetPassword());
        }
        /// <summary>
        /// Function to switch active User
        /// </summary>
        /// <param name="Id">Int id of User</param>
        /// <returns>bool</returns>
        public bool SwitchActive(int Id)
        {
            return _repository.SwitchActiveUser(Id);
        }
        /// <summary>
        /// Function to change role
        /// </summary>
        /// <param name="Id">Id of user</param>
        /// <param name="IdRole">Id of role</param>
        /// <returns>bool</returns>
        public bool UpdateRoleChange(int Id,int IdRole)
        {
            return _repository.UpdateRoleUser(Id, IdRole);
        }
    }
}
