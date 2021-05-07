using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form.SensibleData
{
    /// <summary>
    /// Class to describe a Sensible Data
    /// </summary>
    public class SensibleDataUpdate
    {
        public int Id { get; set; }
        public string AddCountry { get; set; }
        public string AddNumber { get; set; }
        public string AddStreet { get; set; }
        public string AddPostalCode { get; set; }
    }
}
