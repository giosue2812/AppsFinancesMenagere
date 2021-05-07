﻿using DAL.Mappers;
using DAL.Models;
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
    public class SensibleDataRepository : RepositoryBase<SensibleData, VSensibleDataByOrganization, int>,ISensibleDataRepository
    {
        public override IEnumerable<VSensibleDataByOrganization> GetAll()
        {
            Command command = new Command("SELECT * FROM V_SensibleDataByOrganization");
            return Connection.ExecuteReader(command, (s) => s.ToDalSensibleData());
        }
        public override VSensibleDataByOrganization Get(int Id)
        {
            Command command = new Command("P_GetOneSensibleDataByOrganization", true);
            command.AddParameter("@IdOrganization", Id);
            return Connection.ExecuteReader(command, (s) => s.ToDalSensibleData()).SingleOrDefault();
        }
        public override int Create(SensibleData entity)
        {
            Command command = new Command("P_AddSensibleData", true);
            command.AddParameter("@AddStreet", entity.AddStreet);
            command.AddParameter("@AddPostalCode", entity.AddPostalCode);
            command.AddParameter("@AddCountry", entity.AddCountry);
            command.AddParameter("@AddNumber", entity.AddNumber);
            int idCreated = (int)Connection.ExecuteScalar(command);
            if (idCreated == 0) throw new ArgumentNullException("Error raise during the insertion");
            else return idCreated;
        }
        /// <summary>
        /// Function to update a Sensible data
        /// </summary>
        /// <param name="entity">SensibleData</param>
        /// <returns>VSensibleDataByOrganization</returns>
        public VSensibleDataByOrganization Update(SensibleData entity)
        {
            Command command = new Command("P_UpdateSensibleData", true);
            command.AddParameter("@IdSensible", entity.Id);
            command.AddParameter("@AddStreet", entity.AddStreet);
            command.AddParameter("@AddPostalCode", entity.AddPostalCode);
            command.AddParameter("@AddCountry", entity.AddCountry);
            command.AddParameter("@AddNumber", entity.AddNumber);
            VSensibleDataByOrganization vSensibleDataByOrganization = Connection.ExecuteReader(command, (s) => s.ToDalSensibleData()).SingleOrDefault();
            if (vSensibleDataByOrganization == null) throw new ArgumentNullException("Error during update");
            else return vSensibleDataByOrganization;
        }

    }
}