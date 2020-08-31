using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.AdminVM
{
    public class TeacherViewModel
    {
        public Int64 TcridVM { get; set; }
        public string TcrnameVM { get; set; }
        public string TcrdesigVM { get; set; }
        public DateTime TcrdobVM { get; set; }
        public string TcrbgVM { get; set; }
        public string TcrgenderVM { get; set; }
        public DateTime TcrjdVM { get; set; }
        public string TcrnationVM { get; set; }
        public String TcrpaddrssVM { get; set; }
        public String TcrcaddrssVM { get; set; }
        public String TcrphotoVM { get; set; }
        public Int64 TcrphoneVM { get; set; }
        public string TcremailVM { get; set; }
        public Int64 DesigIdVM { get; set; }


        ///Document Submission 
        public Int64 DocSLVM { get; set; }
        public Boolean TcrdocsubsscmarkVM { get; set; }
        public Boolean TcrdocsubssccrtfctVM { get; set; }
        public Boolean TcrdocsubhscmarkVM { get; set; }
        public Boolean TcrdocsubhsccrtfctVM { get; set; }
        public Boolean TcrdocsubhonsmarkVM { get; set; }
        public Boolean TcrdocsubhonscrtfctVM { get; set; }

        /// Teacher Qualification
         public Int64 QlSLVM { get; set; }
        public Int64 TcrqsscyearVM { get; set; }
        public Int64 TcrqhscyearVM { get; set; }
        public Int64 TcrqhonsyearVM { get; set; }
        public double TcrqsscgradeVM { get; set; }
        public double TcrqhscgradeVM { get; set; }
        public double TcrqhonsgradeVM { get; set; }
        public String TcrqsscinsVM { get; set; }
        public String TcrqhscinsVM { get; set; }
        public String TcrqhonsinsVM { get; set; }


    }
}
