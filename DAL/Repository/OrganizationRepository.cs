using DAL.Mappers;
using DAL.Models;
using DAL.Models.Views;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Tool.Connection.DB;

namespace DAL.Repository
{
    /// <summary>
    /// Function to describe a Organiztion Repository
    /// </summary>
    public class OrganizationRepository : RepositoryBase<Organization,VOrganization, int>,IOrganizationRepository
    {
        public override IEnumerable<VOrganization> GetAll()
        {
            Command command = new Command("SELECT * FROM V_Organization");
            return Connection.ExecuteReader(command, (o) => o.ToDal());
        }
        public override VOrganization Get(int Id)
        {
            Command command = new Command("P_GetOneOrganization",true);
            command.AddParameter("@IdOrganization", Id);
            return Connection.ExecuteReader(command, (o) => o.ToDal()).SingleOrDefault();
        }
        public override int Create(Organization entity)
        {
            Command command = new Command("P_AddOrganization",true);
            command.AddParameter("@OrName", entity.OrName);
            command.AddParameter("@Organization", entity.TypeOrganization);
            command.AddParameter("@Tel1", entity.Tel1);
            command.AddParameter("@Tel2",entity.Tel2);
            command.AddParameter("@Email", entity.Email);
            command.AddParameter("@NameContact", entity.NameContact);
            command.AddParameter("@IdSensibleData", entity.IdSensibleData);
            int idCreated = (int)Connection.ExecuteScalar(command);
            if (idCreated == 0) throw new ArgumentException("Error raise during insertion");
            else return idCreated;
        }
        /// <summary>
        /// Function to Update a organization
        /// </summary>
        /// <param name="entity">Organization</param>
        /// <returns>Organization</returns>
        public VOrganization Update(Organization entity)
        {
            Command command = new Command("P_UpdateOrganization", true);
            command.AddParameter("@IdOrganization", entity.Id);
            command.AddParameter("@OrName", entity.OrName);
            command.AddParameter("@Organization", entity.TypeOrganization);
            command.AddParameter("@Tel1", entity.Tel1);
            command.AddParameter("@Tel2", entity.Tel2);
            command.AddParameter("@Email", entity.Email);
            command.AddParameter("@NameContact", entity.NameContact);
            command.AddParameter("@IdSensibleData", entity.IdSensibleData);
            VOrganization vorganization = Connection.ExecuteReader(command, (o) => o.ToDal()).SingleOrDefault();
            if (vorganization == null) throw new ArgumentException("Error raise during Update or Bill not find");
            else return vorganization;
        }
        /// <summary>
        /// Function to Switch IsActive.
        /// </summary>
        /// <param name="Id">int id of Organization</param>
        /// <returns>bool</returns>
        public bool SwitchIsActive(int Id)
        {
            Command command = new Command("P_SwitchIsActiveOrganization", true);
            command.AddParameter("@IdOrganization", Id);
            bool isDeleted = Connection.ExecuteNonQuery(command) == 1;
            if (!isDeleted) throw new ArgumentException("Error raise during Update or Bill not find");
            else return isDeleted;
        }

    }
}
