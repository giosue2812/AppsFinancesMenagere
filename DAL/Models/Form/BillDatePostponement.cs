using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Form
{
    public class BillDatePostponement:IEntity<int>
    {
        public int Id { get; set; }
        public DateTime DatePostponement { get; set; }
    }
}
