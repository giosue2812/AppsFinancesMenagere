using DAL.Models;
using DAL.Models.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IPersonalExpenseRepository : IRepository<PersonalExpenseForm, PersonalExpense, int>
    {
        IEnumerable<PersonalExpense> GetExpenseByUser(int Id);
    }
}
