using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    /// <summary>
    /// Class to describe a Sensible data
    /// </summary>
    public class SensibleData
    {
        public int Id { get; set; }
        public string AddStreet { get; set; }
        public string AddPostalCode { get; set; }
        public string AddCountry { get; set; }
        public string AddNumber { get; set; }
    }
}
