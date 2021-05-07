using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Form.Bills
{
    /// <summary>
    /// Class to describe a BillDatePostponement
    /// </summary>
    public class BillDatePostponement
    {
        public int Id { get; set; }
        public DateTime DatePostponement { get; set; }
    }
}
