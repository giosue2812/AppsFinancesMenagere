using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form.Bills
{
    /// <summary>
    /// Class to describe a Billform
    /// </summary>
    public class BillForm
    {
        public decimal Balance { get; set; }
        [DataType("current_date")]
        public DateTime Deadline { get; set; }
        [MaxLength(1000)]
        public string Note { get; set; }
        public int IdOrganization { get; set; }
    }
}
    