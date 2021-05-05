using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Views
{
    /// <summary>
    /// Class to describe VOrganization
    /// </summary>
    public class VOrganisation
    {
        public int Id { get; set; }
        public string OrName { get; set; }
        public string TypeOrganization { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public string NameContact { get; set; }
    }
}
