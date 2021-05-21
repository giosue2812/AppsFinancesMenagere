using DAL.Mappers;
using DAL.Models;
using DAL.Models.Form;
using DAL.Models.Views;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Connection.DB;

namespace DAL.Repository
{
    public class UserReopository : RepositoryBase<UserForm, VUser, int>, IUserRepository
    {
        public override IEnumerable<VUser> GetAll()
        {
            Command command = new Command("SELECT * FROM V_User");
            return Connection.ExecuteReader(command, (u) => u.ToDalUser());
        }
        public override VUser Get(int Id)
        {
            Command command = new Command("P_GetOneUser", true);
            command.AddParameter("@IdUser", Id);
            return Connection.ExecuteReader(command, (u) => u.ToDalUser()).SingleOrDefault();
        }
        public override int Create(UserForm entity)
        {
            Command command = new Command("P_AddUser", true);
            command.AddParameter("@FirstName", entity.FirstName);
            command.AddParameter("@LastName", entity.LastName);
            command.AddParameter("@Email", entity.Email);
            command.AddParameter("@Tel", entity.Tel);
            command.AddParameter("@BirthDate", entity.BirthDate);
            command.AddParameter("@UPassword", entity.UPassword);
            command.AddParameter("@IdSensibleData", entity.IdSensibleData);
            int idCreated = (int)Connection.ExecuteScalar(command);
            if (idCreated == 0) throw new ArgumentException("Error raise during insert");
            else return idCreated;
        }
        /// <summary>
        /// Function to update an user
        /// </summary>
        /// <param name="entity">UserForm</param>
        /// <returns>User</returns>
        public VUser Update(UserForm entity)
        {
            Command command = new Command("P_UpdateUser",true);
            command.AddParameter("@IdUser", entity.Id);
            command.AddParameter("@FirstName", entity.FirstName);
            command.AddParameter("@LastName", entity.LastName);
            command.AddParameter("@Email", entity.Email);
            command.AddParameter("@Tel", entity.Tel);
            command.AddParameter("@BirthDate", entity.BirthDate);
            command.AddParameter("@IdSensibleData", entity.IdSensibleData);
            VUser user = Connection.ExecuteReader(command, (u) => u.ToDalUser()).SingleOrDefault();
            if (user == null) throw new ArgumentException("Error raiser during update");
            else return user;
        }
        /// <summary>
        /// Function login
        /// </summary>
        /// <param name="form">LoginForm</param>
        /// <returns>User</returns>
        public VUser Login(LoginForm form)
        {
            Command command = new Command("P_LoginUser", true);
            command.AddParameter("@Email", form.Email);
            command.AddParameter("@Password", form.Password);
            VUser user = Connection.ExecuteReader(command,(u)=>u.ToDalUser()).SingleOrDefault();
            if (user == null) throw new ArgumentException("Password or email is invalid");
            else return user;
        }
        /// <summary>
        /// Function to reset password
        /// </summary>
        /// <param name="form">ResetPassword</param>
        /// <returns>ResetPassword</returns>
        public bool ResetPassword(ResetPassword form)
        {
            Command command = new Command("P_ResetPassword", true);
            command.AddParameter("@IdUser", form.Id);
            command.AddParameter("@Email", form.Email);
            command.AddParameter("@UPassword", form.Password);
            bool isReset = Connection.ExecuteNonQuery(command) == 1;
            if (!isReset) throw new ArgumentException("Error during reset");
            else return isReset;
        }
        /// <summary>
        /// Function to switch active user
        /// </summary>
        /// <param name="Id">Id of User</param>
        /// <returns>bool</returns>
        public bool SwitchActiveUser(int Id)
        {
            Command command = new Command("P_SwitchActiveUser", true);
            command.AddParameter("@IdUser", Id);
            bool isActive = Connection.ExecuteNonQuery(command) == 1;
            if (!isActive) throw new ArgumentException("Error during the switch");
            else return isActive;
        }
        /// <summary>
        /// Funciton to change role
        /// </summary>
        /// <param name="Id">id of user</param>
        /// <param name="IdRole">id of role</param>
        /// <returns>bool</returns>
        public bool UpdateRoleUser(int Id,int IdRole)
        {
            Command command = new Command("P_UpdateRoleUser", true);
            command.AddParameter("@IdUser", Id);
            command.AddParameter("@IdRole", IdRole);
            bool isChange = Connection.ExecuteNonQuery(command) == 1;
            if (!isChange) throw new ArgumentException("Error raise during role change");
            else return isChange;
        }
    }
}
