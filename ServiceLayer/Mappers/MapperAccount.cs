using S = ServiceLayer.Models;
using D = DAL.Models;

namespace ServiceLayer.Mappers
{
    public static class MapperAccount
    {
        /// <summary>
        /// Convert Dal Account to ServiceLayer Account
        /// </summary>
        /// <param name="entity">Dal Account</param>
        /// <returns>ServiceLayer Account</returns>
        public static S.Account ToServiceLayerAccount(this D.Account entity)
        {
            if (entity == null) return null;
            return new S.Account
            {
                AccountNumber = entity.AccountNumber,
                Balance = entity.Balance,
                CreationDate = entity.CreationDate,
                Id = entity.Id,
                IdMandatary = entity.IdMandatary,
                IdTitular = entity.IdTitular,
                IsActive = entity.IsActive,
                Note = entity.Note
            };
        }
        /// <summary>
        /// Convert to ServiceLayer AccountForm to Dal AccountForm
        /// </summary>
        /// <param name="form">ServiceLayer AccountForm</param>
        /// <returns>Dal AccountForm</returns>
        public static D.Form.AccountForm ToDalAccountInsert(this S.Form.Account.AccountForm form)
        {
            if (form == null) return null;
            return new D.Form.AccountForm
            {
                Account = form.Account,
                Balance = form.Balance,
                IdTitular = form.IdTitular,
                Note = form.Note
            };
        }
        /// <summary>
        /// Convert to ServiceLayer AccountForm to Dal AccountForm
        /// </summary>
        /// <param name="form">ServiceLayer AccountForm</param>
        /// <returns>Dal AccountForm</returns>
        public static D.Form.AccountForm ToDalAccountUpdate(this S.Form.Account.AccountForm form)
        {
            if (form == null) return null;
            return new D.Form.AccountForm
            {
                Id = form.Id,
                Account = form.Account,
                Balance = form.Balance,
                IdTitular = form.IdTitular,
                Note = form.Note
            };
        }
        public static S.Views.VAccountByTitular ToServiceLayerAccountTitular(this D.Views.VAccountByTitular entity)
        {
            if (entity == null) return null;
            return new S.Views.VAccountByTitular
            {
                Account = entity.Account,
                Balance = entity.Balance,
                IdTitular = entity.IdTitular,
                Note = entity.Note
            };
        }
        public static S.Views.VAccountByMandatary ToServiceLayerAccountMandatary(this D.Views.VAccountByMandatary entity)
        {
            if (entity == null) return null;
            return new S.Views.VAccountByMandatary
            {
                Account = entity.Account,
                Balance = entity.Balance,
                IdMandatary = entity.IdManadatary,
                Note = entity.Note
            };
        }
    }
}
