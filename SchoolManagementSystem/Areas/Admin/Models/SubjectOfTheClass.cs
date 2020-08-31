using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class SubjectOfTheClass
    {

        [Key]
        public Int64 SL { get; set; }
        public Int64 Class_ID { get; set; }
        public Int64 Subject_ID { get; set; }
        public Int64 Year { get; set; }
    }
}
