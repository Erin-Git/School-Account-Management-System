using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.ViewModels
{
    public class FeeSubViewModel
    {
        public Int64 serialnoVM { get; set; }
        public Int64 studentidVM { get; set; }
        public String studentnameVM { get; set; }  // extra
        public Int64 classidVM { get; set; }
        public String classnameVM { get; set; }    // extra
        public Int64 secnameVM { get; set; }     // extra
        public double feeamountVM { get; set; }
        public double extrafeetitleVM { get; set; }
        public double extrafeeamountVM { get; set; }
        public double dueamountVM { get; set; }
        public double totalfeeVM { get; set; }
        public double ShouldtotalfeeVM { get; set; }
        public String monthVM { get; set; }
        public DateTime dateVM { get; set; }
        public String dt{ get; set; }
        public String inwords{ get; set; }
        public int amountofmonth{ get; set; }
        public string lastmonth{ get; set; }
        public string currentmonth{ get; set; }



    }
}
