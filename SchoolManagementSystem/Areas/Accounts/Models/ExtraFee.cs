using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.Models
{
    public class ExtraFee
    {
        [Key]
        public Int64 ExtraFeeId { get; set; }
        [Required]
        public double ExtraFeeAmount { get; set; }
        [Required]
        public String ExtraFeeTitle { get; set; }
        [Required]
        public Int64 ClassId { get; set; }

    }
}
