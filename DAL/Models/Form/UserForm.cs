using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Form
{
    /// <summary>
    /// Class to describe a User Form
    /// </summary>
    public class UserForm:IEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public DateTime BirthDate { get; set; }
        public string UPassword { get; set; }
        public int IdSensibleData { get; set; }
    }
}
