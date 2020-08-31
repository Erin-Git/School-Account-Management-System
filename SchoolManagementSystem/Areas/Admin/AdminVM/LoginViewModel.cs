using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.AdminVM
{
    public class LoginViewModel
    {
        public Int64 logserialnoVM { get; set; }
        public String usernameVM { get; set; }
        public String pswrdVM { get; set; }
        public String crntpswrdVM { get; set; }
        public bool firstloginsttsVM { get; set; }
        public int roleidVM { get; set; }
        public bool activesttsVM { get; set; }
        public Int64 distinguishidVM { get; set; }
    }
}
