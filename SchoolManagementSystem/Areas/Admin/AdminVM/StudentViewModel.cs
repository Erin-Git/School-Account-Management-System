using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Areas.Admin.AdminVM
{
    public class StudentViewModel
    {
        public Int64 stdntidVM { get; set; }
        public Int64 Serial { get; set; }
       
        [Display(Name ="Enter Student's Name")]
        public String stdntnameVM { get; set; }
        public Int64 stdntclsVM { get; set; }
       /// [Required]
        [Display(Name = "Enter Student's Birthday")]
        public DateTime dobVM { get; set; }
       
       /// [Required]
        [Display(Name = "Select Student's Gender")]
        public string stdntgenderVM { get; set; }
       /// [Required]
        [Display(Name = "Enter Student's Nationality")]
        public string stdntnationVM { get; set; }
        [Display(Name = "Enter Student's Permanent Address")]
        public String stdntpaddrssVM { get; set; }
       /// [Required]
        [Display(Name = "Enter Student's Permanent Address")]
        public String stdntcaddrssVM { get; set; }
       
        [Display(Name = "Provide Student's Photo")]
        public String stdntphotoVM { get; set; }
        public String stdntbgVM { get; set; }
        public DateTime stdntdoaVM { get; set; }
        public Int64 stdntyearVM { get; set; }


        ///Guardian Father
        
        public Int64 gserialnoFVM { get; set; }
       
        public string gnameFVM { get; set; }
       /// [Required]
        public Int64 gphoneFVM { get; set; }
        public string gemailFVM { get; set; }
        public String gdesignationFVM { get; set; }
        public String gorganisationFVM { get; set; }
      ///  [Required]
        public String goccupationFVM { get; set; }

        ///Guardian Mother

        public Int64 gserialnoMVM { get; set; }
      ///  [Required]
        public string gnameMVM { get; set; }
        public Int64 gphoneMVM { get; set; }
        public string gemailMVM { get; set; }
        public String gorganisationMVM { get; set; }
        public String gdesignationsMVM { get; set; }
      ///  [Required]
        public String goccupationMVM { get; set; }





    }
}
