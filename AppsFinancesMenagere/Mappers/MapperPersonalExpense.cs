using A = AppsFinancesMenagere.Models;
using S = ServiceLayer.Models;

namespace AppsFinancesMenagere.Mappers
{
    public static class MapperPersonalExpense
    {
        public static A.PersonalExpense ToApiPersonalExpense(this S.PersonalExpense entity)
        {
            if (entity == null) return null;
            return new A.PersonalExpense
            {
                Balance = entity.Balance,
                DateExpense = entity.DateExpense,
                ELabel = entity.ELabel,
                Id = entity.Id,
                IdUser = entity.IdUser
            };
        }
        public static S.Form.PersonalExpense.PersonalExpenseForm ToServiceLayerPersonalExpense(this A.Form.PersonalExpense.PersonalExpenseForm form)
        {
            if (form == null) return null;
            return new S.Form.PersonalExpense.PersonalExpenseForm
            {
                Balance = form.Balance,
                DateExpense = form.DateExpense,
                ELabel = form.ELabel,
                IdAccount = form.IdAccount,
                IdUser = form.IdUser
            };
        }
    }
}
