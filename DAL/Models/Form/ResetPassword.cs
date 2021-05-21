using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Form
{
    /// <summary>
    /// Class to describe a ResetPasword
    /// </summary>
    public class ResetPassword:IEntity<int>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
