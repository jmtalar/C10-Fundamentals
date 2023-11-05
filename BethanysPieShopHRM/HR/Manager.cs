using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Manager : Employee
    {
        public Manager(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
            
        }

        public void AttendManagementMeeting()
        {
            NumberofHoursWorked += 10;
        }
    }
}
