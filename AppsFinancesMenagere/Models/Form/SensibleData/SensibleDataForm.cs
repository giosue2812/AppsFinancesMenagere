using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form.SensibleData
{
    /// <summary>
    /// Class to describe a Sensible Data Form
    /// </summary>
    public class SensibleDataForm
    {
        [MaxLength(100)]
        public string AddCountry { get; set; }
        [MaxLength(100)]
        public string AddNumber { get; set; }
        [MaxLength(100)]
        public string AddStreet { get; set; }
        [MaxLength(100)]
        public string AddPostalCode { get; set; }
        [MaxLength(100)]
        public string AddCity { get; set; }
    }
}
