using DAL.Mappers;
using DAL.Models;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Connection.DB;

namespace DAL.Repository
{
    public class RoleRepository : RepositoryBase<Role, Role, int>, IRoleRepository
    {
        public override IEnumerable<Role> GetAll()
        {
            Command command = new Command("SELECT * FROM V_Role");
            return Connection.ExecuteReader(command, (r) => r.ToDalRole());
        }
        public override Role Get(int Id)
        {
            Command command = new Command("P_GetOneRole", true);
            command.AddParameter("@IdRole", Id);
            return Connection.ExecuteReader(command, (r) => r.ToDalRole()).SingleOrDefault();
        }
        public override int Create(Role entity)
        {
            Command command = new Command("P_AddRole", true);
            command.AddParameter("@Rlabel", entity.RLabel);
            int idCreated = (int)Connection.ExecuteScalar(command);
            if (idCreated == 0) throw new ArgumentException("Error raise during the insertion");
            else return idCreated;
        }
        /// <summary>
        /// Funtion to update a Role
        /// </summary>
        /// <param name="entity">Role</param>
        /// <returns>Role</returns>
        public Role Update(Role entity)
        {
            Command command = new Command("P_UpdateRole", true);
            command.AddParameter("@IdRole", entity.Id);
            command.AddParameter("@RLabel",entity.RLabel);
            Role role = Connection.ExecuteReader(command, (b) => b.ToDalRole()).SingleOrDefault();
            if (role == null) throw new ArgumentException("Error raise during Update or Bill not find");
            else return role;
        }
        /// <summary>
        /// Function to delete a Role
        /// </summary>
        /// <param name="Id">int id of role</param>
        /// <returns>bool</returns>
        public bool Delete(int Id)
        {
            Command command = new Command("P_DeleteRole", true);
            command.AddParameter("@IdRole", Id);
            bool isDeleted = Connection.ExecuteNonQuery(command) == 1;
            if (!isDeleted) throw new ArgumentException("Error raise during delete or Bill not find");
            else return isDeleted;
        }
    }
}
