using DAL.Mappers;
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
            command.AddParameter("@IdSensible", Id);
            return Connection.ExecuteReader(command, (s) => s.ToDalSensibleData()).SingleOrDefault();
        }
        /// <summary>
        /// Function to get one sensible data
        /// </summary>
        /// <param name="Id">is of Sensible data</param>
        /// <returns>SensibleData</returns>
        public SensibleData GetSensibleData(int Id)
        {
            Command command = new Command("P_GetOneSensibleData", true);
            command.AddParameter("@IdSensibleData", Id);
            return Connection.ExecuteReader(command, (s) => s.ToDalSensible()).SingleOrDefault();
        }
        public override int Create(SensibleData entity)
        {
            Command command = new Command("P_AddSensibleData", true);
            command.AddParameter("@AddStreet", entity.AddStreet);
            command.AddParameter("@AddPostalCode", entity.AddPostalCode);
            command.AddParameter("@AddCountry", entity.AddCountry);
            command.AddParameter("@AddNumber", entity.AddNumber);
            command.AddParameter("@AddCity", entity.AddCity);
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
            command.AddParameter("@AddCity", entity.AddCity);
            VSensibleDataByOrganization vSensibleDataByOrganization = Connection.ExecuteReader(command, (s) => s.ToDalSensibleData()).SingleOrDefault();
            if (vSensibleDataByOrganization == null) throw new ArgumentNullException("Error during update");
            else return vSensibleDataByOrganization;
        }
        public SensibleData UpdateSensibleData(SensibleData entity)
        {
            Command command = new Command("P_UpdateSensibleDataUser", true);
            command.AddParameter("@IdSensible", entity.Id);
            command.AddParameter("@AddStreet", entity.AddStreet);
            command.AddParameter("@AddPostalCode", entity.AddPostalCode);
            command.AddParameter("@AddCountry", entity.AddCountry);
            command.AddParameter("@AddNumber", entity.AddNumber);
            command.AddParameter("@AddCity", entity.AddCity);
            SensibleData sensibleData = Connection.ExecuteReader(command, (s) => s.ToDalSensible()).SingleOrDefault();
            if (sensibleData == null) throw new ArgumentNullException("Error during update");
            else return sensibleData;
        }
    }
}
