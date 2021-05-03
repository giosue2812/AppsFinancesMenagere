using DAL.Repository;
using DAL.Repository.Interfaces;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using ServiceLayer.Models.Form;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Bill Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayer();
        }
        public IEnumerable<Bill> GetAll()
        {
            return _repository.GetAll().Select((b) => b.ToServiceLayer());
        }
        public int Create(BillForm body)
        {
            return _repository.Create(body.ToDal());
        }
        public Bill Update(BillUpdate bill)
        {
            return _repository.Update(bill.ToDal()).ToServiceLayer();
        }
        public bool Delete(int Id)
        {
            return _repository.Delete(Id);
        }
    }
}
