using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class PersonalExpense
    {
        public int Id { get; set; }
        public string ELabel { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateExpense { get; set; }
        public int IdUser { get; set; }
    }
}
