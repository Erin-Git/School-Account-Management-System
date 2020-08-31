using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.AdminVM
{
    public class TeacherQViewModel
    {
        public Int64 tcrqserialnoVM { get; set; }
        public Int64 tcridVM { get; set; }
        public int tcrqsscyearVM { get; set; }
        public int tcrqhscyearVM { get; set; }
        public int tcrqhonsyearVM { get; set; }
        public double tcrqsscgradeVM { get; set; }
        public double tcrqhscgradeVM { get; set; }
        public double tcrqhonsgradeVM { get; set; }
        public String tcrqsscinsVM { get; set; }
        public String tcrqhscinsVM { get; set; }
        public String tcrqhonsinsVM { get; set; }
    }
}
