using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class MapperPersonalExpense
    {
        public static PersonalExpense ToDalPersonalExpense(this IDataRecord record)
        {
            if (record == null) return null;
            return new PersonalExpense
            {
                Id = (int)record["IdExpense"],
                Balance = (decimal)record["Balance"],
                DateExpense = (DateTime)record["DateExpense"],
                ELabel = (string)record["ELabel"],
                IdUser = (int)record["IdUser"]
            };
        }
    }
}
