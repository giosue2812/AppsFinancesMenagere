using DAL.Repository.Interfaces;
using ServiceLayer.Models;
using ServiceLayer.Models.Form.PersonalExpense;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Mappers;

namespace ServiceLayer.Services
{
    public class PersonalExpenseService : IPersonalExpenseService
    {
        private IPersonalExpenseRepository _repository;
        public PersonalExpenseService(IPersonalExpenseRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<PersonalExpense> GetAll()
        {
            return _repository.GetAll().Select(p => p.ToServiceLayerPersonalExpense());
        }
        public PersonalExpense Get(int Id)
        {
            throw new NotImplementedException();
        }
        public int Create(PersonalExpenseForm body)
        {
            return _repository.Create(body.ToDalPersonalExpenseForm());
        }
        public IEnumerable<PersonalExpense> GetExpenseByUser(int Id)
        {
            return _repository.GetExpenseByUser(Id).Select(p => p.ToServiceLayerPersonalExpense());
        }
    }
}
