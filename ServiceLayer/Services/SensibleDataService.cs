using DAL.Repository.Interfaces;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using ServiceLayer.Models.Form.SensibleData;
using ServiceLayer.Models.Views;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Services
{
    /// <summary>
    /// Sensible Data service which implements ISensibleDataService
    /// </summary>
    public class SensibleDataService : ISensibleDataService
    {
        /// <summary>
        /// Repository
        /// </summary>
        private ISensibleDataRepository _repository;
        /// <summary>
        /// Constuctor of SensibleDataService
        /// </summary>
        /// <param name="repository">ISensibleDataRepository</param>
        public SensibleDataService(ISensibleDataRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Get all sensible data by organization
        /// </summary>
        /// <returns>IEnumerable of Sensible data by organization </returns>
        public IEnumerable<VSensibleDataByOrganization> GetAll()
        {
            return _repository.GetAll().Select((s) => s.ToServiceLayer());
        }
        /// <summary>
        /// Get one sensible by organization
        /// </summary>
        /// <param name="Id">id of Sensible Data</param>
        /// <returns>Sensible Data</returns>
        public VSensibleDataByOrganization Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayer();
        }
        /// <summary>
        /// Create new Sensible Data
        /// </summary>
        /// <param name="body">Sensible data form</param>
        /// <returns>int of sensible data created</returns>
        public int Create(SensibleDataForm body)
        {
            return _repository.Create(body.ToDal());
        }
        /// <summary>
        /// Funtion to update a SensibleData for organization
        /// </summary>
        /// <param name="form">SensibleData</param>
        /// <returns>VSensibleDataByOrganization</returns>
        public VSensibleDataByOrganization Update(SensibleData form)
        {
            return _repository.Update(form.ToDal()).ToServiceLayer();
        }
        /// <summary>
        /// Function to get one sensible data
        /// </summary>
        /// <param name="Id">id of sensible data</param>
        /// <returns>SensibleData</returns>
        public SensibleData GetSensibleData(int Id)
        {
            return _repository.GetSensibleData(Id).ToSeviceLayerSensibleData();
        }
        /// <summary>
        /// Update sensible data
        /// </summary>
        /// <param name="form">SensibleData</param>
        /// <returns>SensibleData</returns>
        public SensibleData UpdateSensibleData(SensibleData form)
        {
            return _repository.UpdateSensibleData(form.ToDal()).ToSeviceLayerSensibleData();
        }

    }
}
