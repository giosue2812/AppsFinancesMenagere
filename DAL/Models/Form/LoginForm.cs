using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Form
{
    /// <summary>
    /// Class to describe a login form
    /// </summary>
    public class LoginForm
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
