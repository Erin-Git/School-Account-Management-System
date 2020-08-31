using System;

using System.ComponentModel.DataAnnotations;


namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public String RoleType { get; set; }
    }
}
