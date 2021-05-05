using DAL.Repository.Interfaces;
using ServiceLayer.Mappers;
using ServiceLayer.Models.Form.Organizations;
using ServiceLayer.Models.Views;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Services
{
    /// <summary>
    /// Class to describe a Organization service
    /// </summary>
    public class OrganizationService:IOrganizationService
    {
        private IOrganizationRepository _repository;
        public OrganizationService(IOrganizationRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<VOrganisation> GetAll()
        {
            return _repository.GetAll().Select((o)=>o.ToServiceLayer());
        }
        public VOrganisation Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayer();
        }
        public int Create(OrganizationForm body)
        {
            return _repository.Create(body.ToDal());
        }
        public VOrganisation Update(OrganizationUpdate body)
        {
            return _repository.Update(body.ToDal()).ToServiceLayer();
        }
        public bool SwitchIsActive(int Id)
        {
            return _repository.SwitchIsActive(Id);
        }
    }
}
