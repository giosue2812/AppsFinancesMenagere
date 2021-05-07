using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models
{
    /// <summary>
    /// Class to describe a SensibleDataGetByOrganization
    /// </summary>
    public class SensibleDataGetByOrganization
    {
        public int IdOrganization { get; set; }
        public int Id { get; set; }
        public string AddCountry { get; set; }
        public string AddNumber { get; set; }
        public string AddStreet { get; set; }
        public string AddPostalCode { get; set; }
    }
}
