using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public string Note { get; set; }
        public int? IdMandatary { get; set; }
        public int IdTitular { get; set; }
        public bool IsActive { get; set; }
        public bool IsAccountFamily { get; set; }
    }
}
