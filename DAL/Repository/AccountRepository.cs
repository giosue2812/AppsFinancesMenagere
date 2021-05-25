using DAL.Models;
using DAL.Models.Form;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Connection.DB;
using DAL.Mappers;
using DAL.Models.Views;

namespace DAL.Repository
{
    public class AccountRepository : RepositoryBase<AccountForm, Account, int>,IAccountRepository
    {
        public override IEnumerable<Account> GetAll()
        {
            Command command = new Command("SELECT * FROM V_Account");
            return Connection.ExecuteReader(command, (a) => a.ToDalAccount());
        }
        public override Account Get(int Id)
        {
            Command command = new Command("P_GetOneAccount",true);
            command.AddParameter("@IdAccount", Id);
            return Connection.ExecuteReader(command, (a) => a.ToDalAccount()).SingleOrDefault();
        }
        public override int Create(AccountForm entity)
        {
            Command command = new Command("P_AddAccount",true);
            command.AddParameter("@Account", entity.Account);
            command.AddParameter("@Balance", entity.Balance);
            command.AddParameter("@Note", entity.Note);
            command.AddParameter("@IdTitular", entity.IdTitular);
            command.AddParameter("@IsAccountFamily", entity.IsAccountFamily);
            int idCreated = (int)Connection.ExecuteScalar(command);
            if (idCreated == 0) throw new ArgumentException("Error raise during insertion");
            return idCreated;
        }
        /// <summary>
        /// Function to update an Account
        /// </summary>
        /// <param name="entity">AccountForm</param>
        /// <returns>Account</returns>
        public Account Update(AccountForm entity)
        {
            Command command = new Command("P_UpdateAccount", true);
            command.AddParameter("@IdAccount", entity.Id);
            command.AddParameter("@Account", entity.Account);
            command.AddParameter("@Balance", entity.Balance);
            command.AddParameter("@Note", entity.Note);
            command.AddParameter("@IdTitular", entity.IdTitular);
            command.AddParameter("@IsAccountFamily", entity.IsAccountFamily);
            Account account = Connection.ExecuteReader(command, (a) => a.ToDalAccount()).SingleOrDefault();
            if (account == null) throw new ArgumentException("Raise an error during an Update");
            else return account;
        }
        /// <summary>
        /// Function to Add Mandatary
        /// </summary>
        /// <param name="IdAccount">IdAccount</param>
        /// <param name="IdMandatary">IdMandatary</param>
        /// <returns>Account</returns>
        public Account AddMandatary(int IdAccount,int IdMandatary)
        {
            Command command = new Command("P_AddMandatary", true);
            command.AddParameter("@IdAccount", IdAccount);
            command.AddParameter("@IdMandatary", IdMandatary);
            Account account = Connection.ExecuteReader(command, (a) => a.ToDalAccount()).SingleOrDefault();
            if (account == null) throw new ArgumentException("Raise an error during an Update");
            else return account;
        }
        /// <summary>
        /// Function to active an Account
        /// </summary>
        /// <param name="IdAccount">IdAccount</param>
        /// <returns>bool</returns>
        public bool SwitchActive(int IdAccount)
        {
            Command command = new Command("P_SwitchActive", true);
            command.AddParameter("@IdAccount", IdAccount);
            bool isActive = Connection.ExecuteNonQuery(command) == 1;
            if (!isActive) throw new ArgumentException("Error raise during activation of Account");
            else return isActive;
        }
        public IEnumerable<VAccountByTitular> GetAccountByTitular(int IdUserTitular)
        {
            Command command = new Command("P_GetAccountTitular", true);
            command.AddParameter("@IdTitular", IdUserTitular);
            return Connection.ExecuteReader(command, (AT) => AT.ToDalAccountByTitular());
        }
        public IEnumerable<VAccountByMandatary> GetAccountByMandatary(int IdUserMandatary)
        {
            Command command = new Command("P_GetAccountMandatary", true);
            command.AddParameter("@IdMandatary", IdUserMandatary);
            return Connection.ExecuteReader(command, (AT) => AT.ToDalAccountByMandatary());
        }
        public int GetAccountPersonal(int IdUser)
        {
            Command command = new Command("P_GetPersonalAccount", true);
            command.AddParameter("@IdUser", IdUser);
            return (int)Connection.ExecuteScalar(command);
        }
    }
}
