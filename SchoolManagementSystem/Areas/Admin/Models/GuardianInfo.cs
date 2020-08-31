using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    
    public class GuardianInfo
    {
        [Key]
        public Int64 SL { get; set; }
        public string GNameF { get; set; }
        public string GNameM { get; set; }

        public Int64 GPhoneF { get; set; }
        public Int64 GPhoneM { get; set; }

        public string GEmailF { get; set; }
        public string GEmailM { get; set; }

        public String GOccupationF { get; set; }
        public String GOccupationM { get; set; }

        public String GDesignationF { get; set; }
        public String GDesignationM { get; set; }

        public String GOrganisationM { get; set; }
        public String GOrganisationF { get; set; }


     
        public Int64 StudentID { get; set; }

        
        


    }
}
