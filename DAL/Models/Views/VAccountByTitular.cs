using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Views
{
    public class VAccountByTitular
    {
        public int IdTitular { get; set; }
        public string Account { get; set; }
        public decimal Balance { get; set; }
        public string Note { get; set; }
    }
}
