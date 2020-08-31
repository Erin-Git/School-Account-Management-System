using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class TeacherDesignation
    {
        [Key]
        public Int64 SerialNo { get; set; }
        public String DesigName { get; set; }
        public Int64 DesigId { get; set; }


    }
}
