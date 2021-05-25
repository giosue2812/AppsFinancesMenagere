using ServiceLayer.Models;
using ServiceLayer.Models.Form.Account;
using ServiceLayer.Models.Views;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccountService : IService<AccountForm, Account, int>
    {
        /// <summary>
        /// Function to add mandatary
        /// </summary>
        /// <param name="IdAccount">Id of account</param>
        /// <param name="IdMandatary">Id of User</param>
        /// <returns>Account</returns>
        Account AddMandatary(int IdAccount, int IdMandatary);
        IEnumerable<VAccountByMandatary> GetAccountByMandatary(int IdUserMandatary);
        IEnumerable<VAccountByTitular> GetAccountByTitular(int IdUserTitular);
        int GetPersonalAccount(int IdUser);

        /// <summary>
        /// Function to switch active an Account
        /// </summary>
        /// <param name="IdAccount">Id of account</param>
        /// <returns>bool</returns>
        bool SwitchActive(int IdAccount);

        /// <summary>
        /// Funciton to update an Account
        /// </summary>
        /// <param name="body">AccountForm</param>
        /// <returns>Account</returns>
        Account Update(AccountForm body);
    }
}
