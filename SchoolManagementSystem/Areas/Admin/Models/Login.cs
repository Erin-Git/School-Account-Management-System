using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class Login
    {
        [Key]
        public Int64 SL { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String CurrentPassword { get; set; }
        public Boolean FirstLoginStatus { get; set; }
        public int RoleId { get; set; }
        public Boolean ActiveStatus  { get; set; }
        public Int64 DistinguishId  { get; set; }
        
    }
}
