using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class Student
    {
        [Key]
        public Int64 StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentBG { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StudentDOB { get; set; }

      
        public string StudentGender { get; set; }
        public string StudentNationality { get; set; }
        public string StudentPAddress { get; set; }
        public string StudentCAddress { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public Int64 Year { get; set; }
        public string StudentPhoto { get; set; }
        public Int64 StudentClass { get; set; }
        public GuardianInfo Guardian { get; set; }

    }
}
