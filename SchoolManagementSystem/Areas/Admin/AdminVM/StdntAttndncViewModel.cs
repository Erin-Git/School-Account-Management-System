using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.AdminVM
{
    public class StdntAttndncViewModel
    {
        public Int64 stdntattserialnoVM { get; set; }
        public Int64 stdntidVM { get; set; }
        public int clsidVM { get; set; }
        public string secnameVM { get; set; }
        public DateTime stdntattdateVM { get; set; }
        public string stdntattremarkVM { get; set; }
        public int sbjctidVM { get; set; }
        public double stdntattprcntVM { get; set; }

    }
}
