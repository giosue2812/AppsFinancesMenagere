using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models
{
    public class ListAccountByUserMandatary
    {
        public IEnumerable<VAccountByMandatary> vAccountByMandataries { get; set; }
        public VUser vUser { get; set; }
    }
}
