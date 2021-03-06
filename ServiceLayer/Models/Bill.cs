
using System;

namespace ServiceLayer.Models
{
    /// <summary>
    /// Class to describe a Bill
    /// </summary>
    public class Bill
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
