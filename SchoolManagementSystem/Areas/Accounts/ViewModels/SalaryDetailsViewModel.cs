using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.ViewModels
{
    public class SalaryDetailsViewModel
    {
        public Int64 serialnoVM { get; set; }
        public Int64 teacheridVM { get; set; }
        public String teachernameVM { get; set; }
        public double salaryVM { get; set; }
        public String designameVM { get; set; }
        public Int64 desigidVM { get; set; }
        public DateTime dateVM { get; set; }
        public string dtVM { get; set; }

        public bool PaymentStatus { get; set; }

    }
}
