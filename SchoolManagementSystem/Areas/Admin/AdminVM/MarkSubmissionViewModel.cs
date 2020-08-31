using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.AdminVM
{
    public class MarkSubmissionViewModel
    {
        public Int64 msserialnoVM { get; set; }
        public int markdisidVM { get; set; }
        public double marksVM { get; set; }
        public Int64 stdntidVM { get; set; }
        public int sbjctidVM { get; set; }
        public int clsidVM { get; set; }
        public string msgradeVM { get; set; }
        public string secnameVM { get; set; }
        public Int64 tcridVM { get; set; }
        public DateTime msdateVM { get; set; }

    }
}
