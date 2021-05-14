using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form.Organizations
{
    /// <summary>
    /// Class to describe a OrganizationForm
    /// </summary>
    public class OrganizationForm
    {
        [MaxLength(50)]
        public string OrName { get; set; }
        [MaxLength(50)]
        public string Organization { get; set; }
        [MaxLength(50)]
        public string Tel1 { get; set; }
        [MaxLength(50)]
        public string Tel2 { get; set; }
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string NameContact { get; set; }
        public int IdSensibleData { get; set; }
    }
}
