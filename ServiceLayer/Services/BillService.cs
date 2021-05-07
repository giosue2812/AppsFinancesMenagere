using DAL.Repository.Interfaces;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using ServiceLayer.Models.Form.Bills;
using ServiceLayer.Models.Views;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace ServiceLayer.Services
{
    /// <summary>
    /// Service for Bill
    /// </summary>
    public class BillService:IBillService
    {
        private IBillRepository _repository;
        public BillService(IBillRepository repository)
        {
            _repository = repository;
        }
        public VBillWithOrganization Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayer();
        }
        public IEnumerable<VBillWithOrganization> GetAll()
        {
            return _repository.GetAll().Select((b) => b.ToServiceLayer());
        }
        public int Create(BillForm body)
        {
            return _repository.Create(body.ToDal());
        }
        public VBillWithOrganization Update(BillUpdate bill)
        {
            return _repository.Update(bill.ToDal()).ToServiceLayer();
        }
        public bool Delete(int Id)
        {
            return _repository.Delete(Id);
        }
        public bool Payement(int id)
        {
            return _repository.Payement(id);
        }
        public bool DatePostponement(BillDatePostponement form)
        {
            return _repository.DatePostponement(form.ToDal());
        }
    }
}
