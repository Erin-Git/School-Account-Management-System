using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class MarkSubmission
    {
        public Int64 Mark_Dis_ID { get; set; }
        public Int64 Marks { get; set; }
        public Int64 Student_ID { get; set; }
        public Int64 Subject_ID { get; set; }
        public Int64 Class_ID { get; set; }
        public Int64 Grade { get; set; }
        public string Section_Name { get; set; }
        public Int64 Teacher_ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}
