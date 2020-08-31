using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class MarkDistribution
    {
        public Int64 Mark_Dis_ID { get; set; }
        public string Mark_Dis_Title { get; set; }
        public Int64 Class_ID { get; set; }
    }
}
