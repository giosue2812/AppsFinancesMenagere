using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models
{
    /// <summary>
    /// Class to describe a Organization
    /// </summary>
    public class OrganizationGet
    {
        public int Id { get; set; }
        public string OrName { get; set; }
        public string TypeOrganization { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public string NameContact { get; set; }
        public bool IsActive { get; set; }
    }
}
