using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.ViewModels
{
    public class ExtraFeeViewModel
    {
        public Int64 PrimaryKey { get; set; }
        public Int64 serialnoVM { get; set; }
        public double extrafeeamountVM { get; set; }
        public String extrafeetitleVM { get; set; }
        public Int64 classidVM { get; set; }
        public String classnameVM { get; set; }

    }
}
