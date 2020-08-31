using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class Subject
    {
        [Key]
        public Int64 SubjectId { get; set; }
        public string SubjectTitle { get; set; }
    }
}
