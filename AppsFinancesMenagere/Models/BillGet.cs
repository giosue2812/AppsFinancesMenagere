using AppsFinancesMenagere.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models
{
    /// <summary>
    /// Class to describe a Bill for a GetAll and Get
    /// </summary>
    public class BillGet:IEntity<int>
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime Deadline { get; set; }
        public string? Note { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? Postponement { get; set; }
        public int? IdOrganization { get; set; }
    }
}
