using ServiceLayer.Models;
using ServiceLayer.Models.Form.PersonalExpense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IPersonalExpenseService:IService<PersonalExpenseForm,PersonalExpense,int>
    {
    }
}
