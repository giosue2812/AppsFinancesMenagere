﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models.Form.Account
{
    public class AccountForm
    {
        public string Account { get; set; }
        public decimal Balance { get; set; }
        public string Note { get; set; }
        public int IdTitular { get; set; }
    }
}
