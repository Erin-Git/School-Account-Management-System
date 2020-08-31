using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.Models
{
    public class AdmissionFee
    {
        [Key]
        public Int64 AdmissionFeeId { get; set; }
        public Int64 ClassId { get; set; }
        public Int64 Amount { get; set; }
    }
}
