using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.Models
{
    public class TeacherSalary
    {
        [Key]
        public Int64 SerialNo { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public Int64 DesigId { get; set; }
      
    }
}
