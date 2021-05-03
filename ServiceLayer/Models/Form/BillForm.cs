using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Form
{
    /// <summary>
    /// Class to describe a Bill form
    /// </summary>
    public class BillForm
    {
        public decimal Balance { get; set; }
        public DateTime Deadline { get; set; }
        public string Note { get; set; }
        //public int IdOrganization { get; set; }
    }
}
