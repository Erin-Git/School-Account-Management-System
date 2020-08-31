using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class Section
    {
        [Key]
        public Int64 SectionSL { get; set; }
        public string SectionName { get; set; }
        public Int64 SectionCapacity { get; set; }
        public Int64 SectionYear { get; set; }
        public Int64 ClassId { get; set; }
    }
}
