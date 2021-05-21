using D = DAL.Models;
using S = ServiceLayer.Models;

namespace ServiceLayer.Mappers
{
    public static class MapperPersonalExpense
    {
        public static S.PersonalExpense ToServiceLayerPersonalExpense(this D.PersonalExpense entity)
        {
            if (entity == null) return null;
            return new S.PersonalExpense
            {
                Balance = entity.Balance,
                DateExpense = entity.DateExpense,
                ELabel = entity.ELabel,
                Id = entity.Id,
                IdUser = entity.IdUser
            };
        }
        public static D.Form.PersonalExpenseForm ToDalPersonalExpenseForm(this S.Form.PersonalExpense.PersonalExpenseForm form)
        {
            if (form == null) return null;
            return new D.Form.PersonalExpenseForm
            {
                Balance = form.Balance,
                DateExpense = form.DateExpense,
                ELabel = form.ELabel,
                IdAcount = form.IdAccount,
                IdUser = form.IdUser
            };
        }
    }
}
