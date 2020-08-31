using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Accounts.Models
{
    public class AccountsManagement
    {
        [Key]
        public Int64 AccountsManagementId { get; set; }
        [Required]
        public double FeeAmount { get; set; }
        [Required]
        public Int64 ClassId { get; set; }

    }
}
