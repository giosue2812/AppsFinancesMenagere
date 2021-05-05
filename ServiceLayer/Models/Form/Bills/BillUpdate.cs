using System;

namespace ServiceLayer.Models.Form.Bills
{
    /// <summary>
    /// Class to describe a Bill Update
    /// </summary>
    public class BillUpdate
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime Deadline { get; set; }
        public string Note { get; set; }
        public int IdOrganization { get; set; }
    }
}
