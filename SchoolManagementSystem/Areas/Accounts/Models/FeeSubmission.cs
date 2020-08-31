using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.Models
{
    public class FeeSubmission
    {
        [Key]
        public Int64 FeeSubmissionId { get; set; }
        [Required]
        public Int64 StudentId { get; set; }
        [Required]
        public Int64 ClassId { get; set; }
        public double FeeAmount { get; set; }
        public double ExtraFeeAmount { get; set; }
        public double DueAmount { get; set; }
        public double TotalFee { get; set; }
        public String Month { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}
