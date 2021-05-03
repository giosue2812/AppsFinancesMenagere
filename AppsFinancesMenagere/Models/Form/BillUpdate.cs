using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form
{
    /// <summary>
    /// Class to describe a Billform
    /// </summary>
    public class BillUpdate
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        [DataType("current_date")]
        public DateTime Deadline { get; set; }
        [MaxLength(1000)]
        public string Note { get; set; }
    }
}
