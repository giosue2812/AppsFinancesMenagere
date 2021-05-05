using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form.Organizations
{
    /// <summary>
    /// Class to describe a OrganizationUpdate
    /// </summary>
    public class OrganizationUpdate
    {
        public int Id { get; set; }
        public string OrName { get; set; }
        public string Organization { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public string NameContact { get; set; }
    }
}
