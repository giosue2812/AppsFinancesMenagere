using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Views
{
    /// <summary>
    /// Class to describe a VSensibleDataByOrganization
    /// </summary>
    public class VSensibleDataByOrganization:IEntity<int>
    {
        public int IdOrganization { get; set; }
        public int Id { get; set; }
        public string AddCountry { get; set; }
        public string AddNumber { get; set; }
        public string AddStreet { get; set; }
        public string AddPostalCode { get; set; }
    }
}
