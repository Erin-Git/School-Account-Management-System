using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.AdminVM
{
    public class ClassViewModel
    {  
        public int clsidVM { get; set; }
        [Required]
        [Display(Name = "Enter Class [Ex:One,Two]")]
        public string clsnameVM { get; set; }
    }
}
