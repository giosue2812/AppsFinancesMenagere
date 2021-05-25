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
    public class SensibleDataService : ISensibleDataService
    {
        private ISensibleDataRepository _repository;
        public SensibleDataService(ISensibleDataRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<VSensibleDataByOrganization> GetAll()
        {
            return _repository.GetAll().Select((s) => s.ToServiceLayer());
        }
        public VSensibleDataByOrganization Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayer();
        }
        public int Create(SensibleDataForm body)
        {
            return _repository.Create(body.ToDal());
        }
        /// <summary>
        /// Funtion to update a SensibleData
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
        public SensibleData UpdateSensibleData(SensibleData form)
        {
            return _repository.UpdateSensibleData(form.ToDal()).ToSeviceLayerSensibleData();
        }

    }
}
