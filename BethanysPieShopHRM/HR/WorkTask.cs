﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    public struct WorkTask
    {
        public string description;
        public int hours;

        public void PerformWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} hours.");
        }
    }
}