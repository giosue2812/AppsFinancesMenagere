using System;

namespace ServiceLayer.Models.Form.Bills
{
    /// <summary>
    /// Class to describe a Bill form
    /// </summary>
    public class BillForm
    {
        public decimal Balance { get; set; }
        public DateTime Deadline { get; set; }
        public string Note { get; set; }
        public int IdOrganization { get; set; }
    }
}
