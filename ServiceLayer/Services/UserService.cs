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
    /// <summary>
    /// User Service which implement interface IUserService
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Property Repository
        /// </summary>
        private IUserRepository _repository;
        /// <summary>
        /// Constructor of UserService
        /// </summary>
        /// <param name="repository">IUserRepository</param>
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Get all User
        /// </summary>
        /// <returns>IEnumerable of VUser</returns>
        public IEnumerable<VUser> GetAll()
        {
            return _repository.GetAll().Select((u) => u.ToServiceLayerUser());
        }
        /// <summary>
        /// Get one user
        /// </summary>
        /// <param name="Id">id of User</param>
        /// <returns>VUser</returns>
        public VUser Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayerUser();
        }
        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="body">UserForm</param>
        /// <returns>int of user created</returns>
        public int Create(UserForm body)
        {
            return _repository.Create(body.ToDalUserForm());
        }
        /// <summary>
        /// Update an User
        /// </summary>
        /// <param name="form">UserForm</param>
        /// <returns>VUser</returns>
        public VUser Update(UserForm form)
        {
            return _repository.Update(form.ToDalUserFormUpdate()).ToServiceLayerUser();
        }
        /// <summary>
        /// Function login
        /// </summary>
        /// <param name="form">LoginForm</param>
        /// <returns>VUser</returns>
        public VUser Login(LoginForm form)
        {
            return _repository.Login(form.ToDalLogin()).ToServiceLayerUser();
        }
        /// <summary>
        /// Function to resset a password
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
