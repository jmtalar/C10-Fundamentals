﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class StoreManager : Employee
    {
        public StoreManager(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }
    }
}
