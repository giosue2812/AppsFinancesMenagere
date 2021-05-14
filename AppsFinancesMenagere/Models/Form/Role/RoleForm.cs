using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form.Role
{
    public class RoleForm
    {
        [MaxLength(50)]
        public string RLabel { get; set; }
    }
}
