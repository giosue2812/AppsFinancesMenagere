using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    /// <summary>
    /// Class to describe a SensibleData
    /// </summary>
    public class SensibleData:IEntity<int>
    {
        public int Id { get; set; }
        public string AddStreet { get; set; }
        public string AddPostalCode { get; set; }
        public string AddCountry { get; set; }
        public string AddNumber { get; set; }
        public string AddCity { get; set; }
    }
}
