using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class StudentAttendance
    {
        [Key]
        public Int64 SL { get; set; }
        public Int64 Student_ID { get; set; }
        public Int64 Class_ID { get; set; }
        public Int64 Subject_ID { get; set; }
        public string Section_Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public Int64 Remark { get; set; }
        public string Percentage { get; set; }
    }
}
