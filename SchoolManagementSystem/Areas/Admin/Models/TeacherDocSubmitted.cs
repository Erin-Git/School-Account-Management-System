using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.Models
{
    public class TeacherDocSubmitted
    {
        [Key]
        public Int64 SL { get; set; }
        public Int64 TeacherId { get; set; }
        public Boolean SSCMarksheet { get; set; }
        public Boolean SSCCertificate { get; set; }
        public Boolean HSCMarksheet { get; set; }
        public Boolean HSCCertificate { get; set; }
        public Boolean HonsMarksheet { get; set; }
        public Boolean HonsCertificate { get; set; }
    }
}
