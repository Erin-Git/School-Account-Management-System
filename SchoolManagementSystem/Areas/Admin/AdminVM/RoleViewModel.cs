using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.AdminVM
{
    public class RoleViewModel
    {
        [Key]
        public int roleidVM { get; set; }
        [Required]
        [Display(Name ="Enter Role [Ex:Student,Teacher]")]
        public String roletypeVM { get; set; }
    }
}
