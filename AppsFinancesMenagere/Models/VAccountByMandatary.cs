using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models
{
    public class VAccountByMandatary
    {
        public int IdMandatary { get; set; }
        public string Account { get; set; }
        public decimal Balance { get; set; }
        public string Note { get; set; }
    }
}
