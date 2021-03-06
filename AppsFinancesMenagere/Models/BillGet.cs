using System;


namespace AppsFinancesMenagere.Models
{
    /// <summary>
    /// Class to describe a Bill for a GetAll and Get
    /// </summary>
    public class BillGet
    {
        public string OrName { get; set; }
        public string Organization { get; set; }
        public decimal Balance { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? Postponement { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Note { get; set; }
        public int IdOrganization { get; set; }
        public int Id { get; set; }
    }
}
