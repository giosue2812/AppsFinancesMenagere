using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Form.PersonalExpense
{
    public class PersonalExpenseForm
    {
        public int IdAccount { get; set; }
        public string ELabel { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateExpense { get; set; }
        public int IdUser { get; set; }
    }
}
