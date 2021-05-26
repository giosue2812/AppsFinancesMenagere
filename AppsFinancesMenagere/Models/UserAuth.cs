using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models
{
    public class UserAuth
    {
        public int IdUser { get; set; }
        public string Email { get; set; }
        public object IdAccount { get; set; }
        public string Role { get; set; }
    }
}
