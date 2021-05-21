using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Form
{
    public class PersonalExpenseForm
    {
        public int IdAcount { get; set; }
        public string ELabel { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateExpense { get; set; }
        public int IdUser { get; set; }
    }
}
