using DAL.Repository.Interfaces;
using ServiceLayer.Models;
using ServiceLayer.Models.Form.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Mappers;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Models.Views;

namespace ServiceLayer.Services
{
    public class AccountService:IAccountService
    {
        private IAccountRepository _repository;
        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Account> GetAll()
        {
            return _repository.GetAll().Select((a)=>a.ToServiceLayerAccount());
        }
        public Account Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayerAccount();
        }
        public int Create(AccountForm body)
        {
            return _repository.Create(body.ToDalAccountInsert());
        }
        /// <summary>
        /// Funciton to update an Account
        /// </summary>
        /// <param name="body">AccountForm</param>
        /// <returns>Account</returns>
        public Account Update(AccountForm body)
        {
            return _repository.Update(body.ToDalAccountUpdate()).ToServiceLayerAccount();
        }
        /// <summary>
        /// Function to add mandatary
        /// </summary>
        /// <param name="IdAccount">Id of account</param>
        /// <param name="IdMandatary">Id of User</param>
        /// <returns>Account</returns>
        public Account AddMandatary(int IdAccount,int IdMandatary)
        {
            return _repository.AddMandatary(IdAccount, IdMandatary).ToServiceLayerAccount();
        }
        /// <summary>
        /// Function to switch active an Account
        /// </summary>
        /// <param name="IdAccount">Id of account</param>
        /// <returns>bool</returns>
        public bool SwitchActive(int IdAccount)
        {
            return _repository.SwitchActive(IdAccount);
        }
        public IEnumerable<VAccountByTitular> GetAccountByTitular(int IdUserTitular)
        {
            return _repository.GetAccountByTitular(IdUserTitular).Select((AT) => AT.ToServiceLayerAccountTitular());
        }
        public IEnumerable<VAccountByMandatary> GetAccountByMandatary(int IdUserMandatary)
        {
            return _repository.GetAccountByMandatary(IdUserMandatary).Select((AM) => AM.ToServiceLayerAccountMandatary());
        }
    }
}
