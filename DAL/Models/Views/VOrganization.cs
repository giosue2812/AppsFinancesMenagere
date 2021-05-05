using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Views
{
    /// <summary>
    /// Class to describe a View Organization
    /// </summary>
    public class VOrganization:IEntity<int>
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