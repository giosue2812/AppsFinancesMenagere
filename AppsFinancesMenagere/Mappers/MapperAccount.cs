using A = AppsFinancesMenagere.Models;
using S = ServiceLayer.Models;

namespace AppsFinancesMenagere.Mappers
{
    public static class MapperAccount
    {
        public static A.Account ToApiAccount(this S.Account entity)
        {
            if (entity == null) return null;
            return new A.Account
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
        public static S.Form.Account.AccountForm ToServiceLayerAccountFormInsert(this A.Form.Account.AccountForm form)
        {
            if (form == null) return null;
            return new S.Form.Account.AccountForm
            {
                Account = form.Account,
                Balance = form.Balance,
                IdTitular = form.IdTitular,
                Note = form.Note
            };
        }
        public static S.Form.Account.AccountForm ToServiceLayerAccountFormUpdate(this A.Form.Account.AccountFormUpdate form)
        {
            if (form == null) return null;
            return new S.Form.Account.AccountForm
            {
                Id = form.Id,
                Account = form.Account,
                Balance = form.Balance,
                IdTitular = form.IdTitular,
                Note = form.Note
            };
        }
        public static A.VAccountByTitular ToApiAccountByTitular(this S.Views.VAccountByTitular entity)
        {
            if (entity == null) return null;
            return new A.VAccountByTitular
            {
                Account = entity.Account,
                Balance = entity.Balance,
                IdTitular = entity.IdTitular,
                Note = entity.Note
            };
        }
        public static A.VAccountByMandatary ToApiAccountByMandatary(this S.Views.VAccountByMandatary entity)
        {
            if (entity == null) return null;
            return new A.VAccountByMandatary
            {
                Account = entity.Account,
                Balance = entity.Balance,
                IdMandatary = entity.IdMandatary,
                Note = entity.Note
            };
        }
    }
}
