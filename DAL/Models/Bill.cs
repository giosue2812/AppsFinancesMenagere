using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    /// <summary>
    /// Class to describe a Bill
    /// </summary>
    public class Bill:IEntity<int>
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? Postponement { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Note { get; set; }
        public int IdOrganization { get; set; }
    }
}
