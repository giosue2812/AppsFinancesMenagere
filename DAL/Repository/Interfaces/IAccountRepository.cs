using DAL.Models;
using DAL.Models.Form;
using DAL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IAccountRepository : IRepository<AccountForm, Account, int>
    {
        /// <summary>
        /// Function to Add Mandatary
        /// </summary>
        /// <param name="IdAccount">IdAccount</param>
        /// <param name="IdMandatary">IdMandatary</param>
        /// <returns>Account</returns>
        Account AddMandatary(int IdAccount, int IdMandatary);
        IEnumerable<VAccountByMandatary> GetAccountByMandatary(int IdUserMandatary);
        IEnumerable<VAccountByTitular> GetAccountByTitular(int IdUserTitular);

        /// <summary>
        /// Function to active an Account
        /// </summary>
        /// <param name="IdAccount">IdAccount</param>
        /// <returns>bool</returns>
        bool SwitchActive(int IdAccount);
        /// <summary>
        /// Function to update an Account
        /// </summary>
        /// <param name="entity">AccountForm</param>
        /// <returns>Account</returns>
        Account Update(AccountForm entity);
    }
}
