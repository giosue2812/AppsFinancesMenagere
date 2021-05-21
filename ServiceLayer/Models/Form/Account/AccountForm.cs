using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Form.Account
{
    public class AccountForm
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public decimal Balance { get; set; }
        public string Note { get; set; }
        public int IdTitular { get; set; }
    }
}
