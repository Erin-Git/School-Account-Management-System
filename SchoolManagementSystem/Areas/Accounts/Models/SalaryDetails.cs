using SchoolManagementSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.Models
{
    public class SalaryDetails
    {
        [Key]
        public Int64 SalaryDetailsId { get; set; }
        [Required]
        
        public String TeacherName { get; set; }
        [Required]
        public Int64 DesigId { get; set; }
        public String DesigName { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public Int64 TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
