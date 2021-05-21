using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models
{
    public class ListAccountByUserTitular
    {
        public IEnumerable<VAccountByTitular> vAccountByTitulars { get; set; }
        public VUser vUser { get; set; }
    }
}
