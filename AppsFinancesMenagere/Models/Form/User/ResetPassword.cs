﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form.User
{
    public class ResetPassword
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}