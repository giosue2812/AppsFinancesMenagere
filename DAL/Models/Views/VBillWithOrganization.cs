using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Views
{
    public class VBillWithOrganization:IEntity<int>
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
