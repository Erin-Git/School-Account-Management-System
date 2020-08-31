using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.ApplicationDb;
using SchoolManagementSystem.Areas.Admin.AdminVM;
using SchoolManagementSystem.Areas.Admin.Models;
using SchoolManagementSystem.Password;


namespace SchoolManagementSystem.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AdmissionOfficerController : Controller
    {
        private readonly DataBaseContext _context;
        public AdmissionOfficerController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult AddStudent()
        {  
            //Get the List of class
            var i = _context.Class.ToList();
            //insert a new element in position 0
            i.Insert(0,new Class { ClassId=0, ClassName="Select"});
            ViewBag.Class = i;
            


            return View();
        }
        [HttpPost]
        public async Task<IActionResult >AddStudent(StudentViewModel std)
        {
            //GEt the List of class
            var i = _context.Class.ToList();
            //Insert a new element in position 0
            i.Insert(0, new Class { ClassId = 0, ClassName = "Select" });
            ViewBag.Class = i;
            // Create a student and save to the database
            Student st = new Student()
            {
                StudentId = std.stdntidVM,
                StudentName = std.stdntnameVM,
                StudentCAddress=std.stdntcaddrssVM,
                StudentPAddress = std.stdntpaddrssVM,
                StudentNationality =std.stdntnationVM,
                StudentDOB=std.dobVM,
                StudentGender=std.stdntgenderVM,
                DateOfAdmission=DateTime.Now.Date,
                StudentClass=std.stdntclsVM,
                StudentPhoto=std.stdntphotoVM,
                Year=DateTime.Now.Year 
            };
            _context.Student.Add(st);
            await _context.SaveChangesAsync();
            //Get the id of saved student
            
            var StudentId = st.StudentId;
            //Create guradian info for that student and save  it
            GuardianInfo gi = new GuardianInfo() {
                SL = 0,
                StudentID=StudentId,
                GNameF=std.gnameFVM,
                GNameM=std.gnameMVM,
                GPhoneF=std.gphoneFVM,
                GPhoneM=std.gphoneMVM,
                GEmailF=std.gemailFVM,
                GEmailM=std.gemailMVM,
                GOccupationF=std.goccupationFVM,
                GOccupationM=std.goccupationMVM,
                GOrganisationF=std.gorganisationFVM,
                GOrganisationM=std.gorganisationMVM,
                GDesignationF=std.gdesignationFVM,
                GDesignationM=std.gdesignationsMVM


            };
            _context.GuardianInfo.Add(gi);
            await  _context.SaveChangesAsync();
             // Create random password 
            PasswordCreator ps = new PasswordCreator();
            //Insert the login information for student login and save
            Login lg = new Login() {
                SL = 0,
                Username = StudentId.ToString(),
                Password = ps.RandomPassword(),
                FirstLoginStatus = true,
                ActiveStatus = true,
                RoleId = 1,
                DistinguishId=StudentId,
            };
             lg.CurrentPassword = lg.Password;
            _context.Login.Add(lg);
            await _context.SaveChangesAsync();

            //Clear the modelstate
            ModelState.Clear();

            
            return View();
        }
        //Add new teacher
        public IActionResult NewTeacher()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewTeacher(TeacherViewModel tr)
        {

            Teacher tchr = new Teacher (){
                TeacherId=0,
                TeacherName=tr.TcrnameVM,
                TeacherBG=tr.TcrbgVM,
                TeacherEmail=tr.TcremailVM,
                TeacherCAddress=tr.TcrcaddrssVM,
                TeacherPAddress=tr.TcrpaddrssVM,
                TeacherDOB=tr.TcrdobVM,
                TeacherGender=tr.TcrgenderVM,
                TeacherNationality=tr.TcrnationVM,
                TeacherPhoneNo=tr.TcrphoneVM,
                TeacherJD=DateTime.Now.Date,
                TeacherPhoto=tr.TcrphotoVM,
                TeacherDesignation=tr.TcrdesigVM

            };
            _context.Teacher.Add(tchr);
           await _context.SaveChangesAsync();
            ///Get the id of teacher 
            var TeacherId = tchr.TeacherId;
            //Teacher email
            var TeacherEmail = tchr.TeacherEmail;
            // Create random password 
            PasswordCreator ps = new PasswordCreator();
            //Create login
            Login lg = new Login()
            {
                SL = 0,
                Username = TeacherEmail,
                Password = ps.RandomPassword(),
                FirstLoginStatus = false,
                ActiveStatus = true,
                RoleId = 2,
                DistinguishId = TeacherId 

            };
            lg.CurrentPassword = lg.Password;
            _context.Login.Add(lg);
            await _context.SaveChangesAsync();

            ///Save the Document Information to the Database

            TeacherDocSubmitted doc = new TeacherDocSubmitted() {
                TeacherId= TeacherId,
                SL=0,
                SSCCertificate=tr.TcrdocsubhsccrtfctVM,
                SSCMarksheet=tr.TcrdocsubsscmarkVM,
                HSCCertificate=tr.TcrdocsubhsccrtfctVM,
                HSCMarksheet=tr.TcrdocsubhscmarkVM,
                HonsCertificate=tr.TcrdocsubhonscrtfctVM,
                HonsMarksheet=tr.TcrdocsubhonsmarkVM    
            };

            await _context.TeacherDocSubmitted.AddAsync(doc);
            await _context.SaveChangesAsync();

            TeacherQualification tq = new TeacherQualification()
            {
                SL=0,
                TeacherId= TeacherId,
                SSCYear=tr.TcrqsscyearVM,
                SSCGrade=tr.TcrqsscgradeVM,
                SSCInstitute=tr.TcrqsscinsVM,
                HSCYear = tr.TcrqhscyearVM,
                HSCGrade = tr.TcrqhscgradeVM,
                HSCInstitute = tr.TcrqhscinsVM,
                HonsYear = tr.TcrqhonsyearVM,
                HonsGrade = tr.TcrqhonsgradeVM,
                HonsInstitute = tr.TcrqhonsinsVM
            };
            await _context.TeacherQualification.AddAsync(tq);
            await _context.SaveChangesAsync();


            
            ///Clear the model state

            ModelState.Clear();

            return View();
        }
        public async Task<IActionResult> TeacherList()

        {
            Int64 Count = 1;
            List<Teacher> tcr =  await  _context.Teacher.ToListAsync();

            List<TeacherViewModel> tv = new List<TeacherViewModel>();

            foreach (var item in tcr)
            {

                TeacherViewModel t = new TeacherViewModel()
                {
                    TcridVM = item.TeacherId,
                    TcrnameVM=item.TeacherName,
                    TcrdesigVM=item.TeacherDesignation,
                    TcrdobVM=item.TeacherDOB,
                    TcrbgVM=item.TeacherBG,
                    TcrgenderVM=item.TeacherGender,
                    TcrjdVM=item.TeacherJD,
                    TcrnationVM=item.TeacherNationality,
                    TcrcaddrssVM=item.TeacherCAddress,
                    TcrpaddrssVM =item.TeacherPAddress,
                    TcrphotoVM=item.TeacherPhoto,
                    TcrphoneVM=item.TeacherPhoneNo,
                    TcremailVM=item.TeacherEmail,
                };
                //Assinging the counter value  of a element 
                t.TcridVM = Count;
                Count++;
                
                //Add the Teacher to  the list
                tv.Add(t);

            }
            //Pass the List to the View
            return View(tv);
        }
        public async Task<IActionResult> TeacherDetails(Int32 id)
        {

            var tcr = await _context.Teacher.Where(s => s.TeacherId == id).ToListAsync();
            if(tcr.Count!=0)
            {
                var doc = await _context.TeacherDocSubmitted.Where(s => s.TeacherId == id).ToListAsync();
                if (doc.Count != 0)
                {
                    var ql = await _context.TeacherQualification.Where(s => s.TeacherId == id).ToListAsync();
                    if (ql.Count != 0)
                    {

                        var query =( from t in tcr
                                    join d in doc on t.TeacherId equals d.TeacherId
                                    join q in ql on t.TeacherId equals q.TeacherId
                                    where t.TeacherId == id
                                    select new
                                    {
                                        //Teacher Information
                                        Tcrid= t.TeacherId,
                                        Tcrname = t.TeacherName,
                                        Tcrdesig = t.TeacherDesignation,
                                        Tcrdob = t.TeacherDOB,
                                        Tcrbg = t.TeacherBG,
                                        Tcrgender = t.TeacherGender,
                                        Tcrjd = t.TeacherJD,
                                        Tcrnation = t.TeacherNationality,
                                        Tcrcaddrss = t.TeacherCAddress,
                                        Tcrpaddrss = t.TeacherPAddress,
                                        Tcrphoto = t.TeacherPhoto,
                                        Tcrphone = t.TeacherPhoneNo,
                                        Tcremail = t.TeacherEmail,

                                        //Teacher Document Submission
                                         Tcrdocsubsscmark=d.SSCMarksheet,
                                         Tcrdocsubssccrtfct=d.SSCCertificate,
                                         Tcrdocsubhscmark=d.HSCMarksheet,
                                         Tcrdocsubhsccrtfct=d.HSCCertificate,
                                         Tcrdocsubhonsmark=d.HonsMarksheet,
                                         Tcrdocsubhonscrtfct=d.HonsCertificate,

                                         //Teacher Qualifiaction


                                      Tcrqsscyear=q.SSCYear,
                                      Tcrqhscyear=q.HSCYear,
                                      Tcrqhonsyear=q.HonsYear,
                                      Tcrqsscgrade=q.SSCGrade,
                                      Tcrqhscgrade=q.HSCGrade,
                                      Tcrqhonsgrade=q.HonsGrade,
                                      Tcrqsscins=q.SSCInstitute,
                                      Tcrqhscins=q.HonsInstitute,
                                      Tcrqhonsins=q.HonsInstitute,


    }).FirstOrDefault();






                        TeacherViewModel tr = new TeacherViewModel()
                        {
                            TcridVM = query.Tcrid,
                            TcrnameVM = query.Tcrname,
                            TcrdesigVM = query.Tcrdesig,
                            TcrdobVM = query.Tcrdob,
                            TcrbgVM = query.Tcrbg,
                            TcrgenderVM = query.Tcrgender,
                            TcrjdVM = query.Tcrjd,
                            TcrnationVM = query.Tcrnation,
                            TcrcaddrssVM = query.Tcrcaddrss,
                            TcrpaddrssVM = query.Tcrpaddrss,
                            TcrphotoVM = query.Tcrphoto,
                            TcrphoneVM = query.Tcrphone,
                            TcremailVM = query.Tcremail,
                            //Teacher Document Submission 
                           TcrdocsubsscmarkVM = query.Tcrdocsubsscmark,
                           TcrdocsubssccrtfctVM=query.Tcrdocsubssccrtfct,
                           TcrdocsubhscmarkVM=query.Tcrdocsubhscmark,
                           TcrdocsubhsccrtfctVM=query.Tcrdocsubhsccrtfct,
                           TcrdocsubhonsmarkVM=query.Tcrdocsubhonsmark,
                           TcrdocsubhonscrtfctVM=query.Tcrdocsubhonscrtfct,

                            //Teacher Qualifiaction Submission 
                            TcrqsscyearVM =query.Tcrqsscyear,
                            TcrqhscyearVM = query.Tcrqhscyear,
                            TcrqhonsyearVM = query.Tcrqhonsyear,
                            TcrqsscgradeVM = query.Tcrqsscgrade,
                            TcrqhscgradeVM = query.Tcrqhscgrade,
                            TcrqhonsgradeVM = query.Tcrqhonsgrade,
                            TcrqsscinsVM = query.Tcrqsscins,
                            TcrqhscinsVM = query.Tcrqhscins,
                            TcrqhonsinsVM = query.Tcrqhonsins,

                        };
                        return View(tr);
                    }
                    else
                    {
                        return NotFound();
                    }

                }
                else
                {
                    return NotFound();
                } 
            }
            else
            {
                return NotFound();
            }


           
        }
        public async Task<IActionResult> UpdateTeacher(Int64 id)
        {
            var tcr = await _context.Teacher.Where(s => s.TeacherId == id).ToListAsync();
            if (tcr.Count != 0)
            {
                var doc = await _context.TeacherDocSubmitted.Where(s => s.TeacherId == id).ToListAsync();
                if (doc.Count != 0)
                {
                    var ql = await _context.TeacherQualification.Where(s => s.TeacherId == id).ToListAsync();
                    if (ql.Count != 0)
                    {

                        var query = (from t in tcr
                                     join d in doc on t.TeacherId equals d.TeacherId
                                     join q in ql on t.TeacherId equals q.TeacherId
                                     where t.TeacherId == id
                                     select new
                                     {
                                         //Teacher Information
                                         Tcrid = t.TeacherId,
                                         Tcrname = t.TeacherName,
                                         Tcrdesig = t.TeacherDesignation,
                                         Tcrdob = t.TeacherDOB,
                                         Tcrbg = t.TeacherBG,
                                         Tcrgender = t.TeacherGender,
                                         Tcrjd = t.TeacherJD,
                                         Tcrnation = t.TeacherNationality,
                                         Tcrcaddrss = t.TeacherCAddress,
                                         Tcrpaddrss = t.TeacherPAddress,
                                         Tcrphoto = t.TeacherPhoto,
                                         Tcrphone = t.TeacherPhoneNo,
                                         Tcremail = t.TeacherEmail,

                                         //Teacher Document Submission
                                         Tcrdocsubsscmark = d.SSCMarksheet,
                                         Tcrdocsubssccrtfct = d.SSCCertificate,
                                         Tcrdocsubhscmark = d.HSCMarksheet,
                                         Tcrdocsubhsccrtfct = d.HSCCertificate,
                                         Tcrdocsubhonsmark = d.HonsMarksheet,
                                         Tcrdocsubhonscrtfct = d.HonsCertificate,
                                         TcrDocSL = d.SL,

                                         //Teacher Qualifiaction


                                         Tcrqsscyear = q.SSCYear,
                                         Tcrqhscyear = q.HSCYear,
                                         Tcrqhonsyear = q.HonsYear,
                                         Tcrqsscgrade = q.SSCGrade,
                                         Tcrqhscgrade = q.HSCGrade,
                                         Tcrqhonsgrade = q.HonsGrade,
                                         Tcrqsscins = q.SSCInstitute,
                                         Tcrqhscins = q.HonsInstitute,
                                         Tcrqhonsins = q.HonsInstitute,
                                         TcrQSL = q.SL


                                     }).FirstOrDefault();

                        
                        TeacherViewModel tr = new TeacherViewModel()
                        {
                            TcridVM = query.Tcrid,
                            TcrnameVM = query.Tcrname,
                            TcrdesigVM = query.Tcrdesig,
                            TcrdobVM = query.Tcrdob,
                            TcrbgVM = query.Tcrbg,
                            TcrgenderVM = query.Tcrgender,
                            TcrjdVM = query.Tcrjd,
                            TcrnationVM = query.Tcrnation,
                            TcrcaddrssVM = query.Tcrcaddrss,
                            TcrpaddrssVM = query.Tcrpaddrss,
                            TcrphotoVM = query.Tcrphoto,
                            TcrphoneVM = query.Tcrphone,
                            TcremailVM = query.Tcremail,
                            //Teacher Document Submission 
                            TcrdocsubsscmarkVM = query.Tcrdocsubsscmark,
                            TcrdocsubssccrtfctVM = query.Tcrdocsubssccrtfct,
                            TcrdocsubhscmarkVM = query.Tcrdocsubhscmark,
                            TcrdocsubhsccrtfctVM = query.Tcrdocsubhsccrtfct,
                            TcrdocsubhonsmarkVM = query.Tcrdocsubhonsmark,
                            TcrdocsubhonscrtfctVM = query.Tcrdocsubhonscrtfct,
                            DocSLVM = query.TcrDocSL,

                            //Teacher Qualifiaction Submission 
                            TcrqsscyearVM = query.Tcrqsscyear,
                            TcrqhscyearVM = query.Tcrqhscyear,
                            TcrqhonsyearVM = query.Tcrqhonsyear,
                            TcrqsscgradeVM = query.Tcrqsscgrade,
                            TcrqhscgradeVM = query.Tcrqhscgrade,
                            TcrqhonsgradeVM = query.Tcrqhonsgrade,
                            TcrqsscinsVM = query.Tcrqsscins,
                            TcrqhscinsVM = query.Tcrqhscins,
                            TcrqhonsinsVM = query.Tcrqhonsins,
                            QlSLVM = query.TcrQSL,

                        };
                        return View(tr);
                    }
                    else
                    {
                        return NotFound();
                    }

                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task< IActionResult> UpdateTeacher(TeacherViewModel tr)

        {
            Teacher tchr = new Teacher()
            {
                TeacherId = tr.TcridVM,
                TeacherName = tr.TcrnameVM,
                TeacherBG = tr.TcrbgVM,
                TeacherEmail = tr.TcremailVM,
                TeacherCAddress = tr.TcrcaddrssVM,
                TeacherPAddress = tr.TcrpaddrssVM,
                TeacherDOB = tr.TcrdobVM,
                TeacherGender = tr.TcrgenderVM,
                TeacherNationality = tr.TcrnationVM,
                TeacherPhoneNo = tr.TcrphoneVM,
                TeacherJD = tr.TcrjdVM,
                TeacherPhoto = tr.TcrphotoVM,
                TeacherDesignation = tr.TcrdesigVM

            };
             _context.Teacher.Update(tchr);
            await _context.SaveChangesAsync();
            
            
            ///Save the Document Information to the Database

            TeacherDocSubmitted doc = new TeacherDocSubmitted()
            {
                TeacherId = tr.TcridVM,
                SL = tr.DocSLVM,
                SSCCertificate = tr.TcrdocsubhsccrtfctVM,
                SSCMarksheet = tr.TcrdocsubsscmarkVM,
                HSCCertificate = tr.TcrdocsubhsccrtfctVM,
                HSCMarksheet = tr.TcrdocsubhscmarkVM,
                HonsCertificate = tr.TcrdocsubhonscrtfctVM,
                HonsMarksheet = tr.TcrdocsubhonsmarkVM
            };

             _context.TeacherDocSubmitted.Update(doc);
            await _context.SaveChangesAsync();

            TeacherQualification tq = new TeacherQualification()
            {
                SL = tr.QlSLVM,
                TeacherId = tr.TcridVM,
                SSCYear = tr.TcrqsscyearVM,
                SSCGrade = tr.TcrqsscgradeVM,
                SSCInstitute = tr.TcrqsscinsVM,
                HSCYear = tr.TcrqhscyearVM,
                HSCGrade = tr.TcrqhscgradeVM,
                HSCInstitute = tr.TcrqhscinsVM,
                HonsYear = tr.TcrqhonsyearVM,
                HonsGrade = tr.TcrqhonsgradeVM,
                HonsInstitute = tr.TcrqhonsinsVM
            };
             _context.TeacherQualification.Update(tq);
            await _context.SaveChangesAsync();



            ///Clear the model state

            ModelState.Clear();

            return View();

        }
        public IActionResult StudentList()

        {
            Int64 Count = 1;
            List<Student> st = _context.Student.ToList();
            List<StudentViewModel> sv = new List<StudentViewModel>();
            foreach (var item in st)
            {

                StudentViewModel s = new StudentViewModel()
                {
                    
                    stdntidVM=item.StudentId,
                    stdntnameVM=item.StudentName,
                    stdntclsVM = item.StudentClass,
                    stdntgenderVM = item.StudentGender,
                    stdntphotoVM = item.StudentPhoto,
                    stdntcaddrssVM = item.StudentCAddress,
                    stdntpaddrssVM = item.StudentPAddress,
                    stdntdoaVM = item.DateOfAdmission,
                    stdntnationVM = item.StudentNationality,
                    stdntyearVM = item.Year,
                    dobVM = item.StudentDOB,
                    
                };
                //Assinging the counter value  of a element 
                s.Serial = Count;
                Count++;
                //Add the Student to  the list
               sv.Add(s);

            }
            //Pass the List to the View
             return View(sv);
        }
        public async Task<IActionResult> UpdateStudent(Int64 id)
        {
           
            //GEt the List of class
            var i = _context.Class.ToList();
            
            ViewBag.Class = i;
            //Get the specific student 
            var std =  await _context.Student.Where(s => s.StudentId == id).ToListAsync();


            
            var grd = await _context.GuardianInfo.Where(a => a.StudentID == id).ToListAsync();

            var query = (from st in std
                         join g in grd on st.StudentId equals g.StudentID
                         where st.StudentId == g.StudentID
                         select new
                         {
                             stdntid = st.StudentId,
                             stdntname = st.StudentName,
                             stdntcls = st.StudentClass,
                             stdntgender = st.StudentGender,
                             stdntphoto = st.StudentPhoto,
                             stdntcaddrss = st.StudentCAddress,
                             stdntpaddrss = st.StudentPAddress,
                             stdntdoa = st.DateOfAdmission,
                             stdntnation = st.StudentNationality,
                             stdntyear = st.Year,
                             dob = st.StudentDOB,
                             stdntbg = st.StudentBG,

                             //Guardian Info

                             GNameMA = g.GNameF,
                             GNameMO = g.GNameM,
                             GPhoneFA = g.GPhoneF,
                             GPhoneMO = g.GPhoneM,
                             GEmailMO = g.GEmailM,
                             GEmailFA = g.GEmailF,
                             GOccupationFA = g.GOccupationF,
                             GOccupationMO = g.GOccupationM,
                             GOrganisationFA = g.GOrganisationF,
                             GOrganisationMO = g.GOrganisationM,
                             GDesignationFA = g.GDesignationF,
                             GDesignationMO = g.GDesignationM
                         }).FirstOrDefault();
      
                StudentViewModel svm = new StudentViewModel()
                {
                    stdntnameVM = query.stdntname,
                    stdntidVM = query.stdntid,
                    stdntclsVM = query.stdntcls,
                    stdntgenderVM = query.stdntgender,
                    stdntphotoVM = query.stdntphoto,
                    stdntcaddrssVM = query.stdntcaddrss,
                    stdntpaddrssVM = query.stdntpaddrss,
                    stdntdoaVM = query.stdntdoa,
                    stdntnationVM = query.stdntnation,
                    stdntyearVM = query.stdntyear,
                    dobVM = query.dob,
                    ///Guardian info
                    gnameFVM=query.GNameMA,
                    gnameMVM= query.GNameMA,
                    gphoneFVM= query.GPhoneFA,
                    gphoneMVM= query.GPhoneMO,
                    gemailFVM= query.GEmailFA,
                    gemailMVM = query.GEmailMO,
                    goccupationFVM = query.GOccupationFA,
                    goccupationMVM = query.GOccupationMO,
                    gorganisationFVM = query.GOrganisationFA,
                    gorganisationMVM = query.GOrganisationMO,
                    gdesignationFVM = query.GDesignationFA,
                    gdesignationsMVM = query.GDesignationMO





                   
                };

         

            return View(svm);
        }
        //Update the student 
        [HttpPost]
        public async Task<IActionResult> UpdateStudent(StudentViewModel std)
        {
            //GEt the List of class
            var i = _context.Class.ToList();

            ViewBag.Class = i;

            // Create a student and save to the database
            Student st = new Student()
            {
                StudentId = std.stdntidVM,
                StudentName = std.stdntnameVM,
                StudentCAddress = std.stdntcaddrssVM,
                StudentPAddress = std.stdntpaddrssVM,
                StudentNationality = std.stdntnationVM,
                StudentDOB = std.dobVM,
                StudentGender = std.stdntgenderVM,
                DateOfAdmission=std.stdntdoaVM,
                StudentClass = std.stdntclsVM,
                StudentPhoto = std.stdntphotoVM,
                Year =std.stdntyearVM,
            };
            _context.Student.Update(st);
            await _context.SaveChangesAsync();
          

           
            //Create guradian info for that student and save  it
            GuardianInfo gi = new GuardianInfo()
            {
                SL=std.Serial,
                StudentID = std.stdntidVM,
                GNameF = std.gnameFVM,
                GNameM = std.gnameMVM,
                GPhoneF = std.gphoneFVM,
                GPhoneM = std.gphoneMVM,
                GEmailF = std.gemailFVM,
                GEmailM = std.gemailMVM,
                GOccupationF = std.goccupationFVM,
                GOccupationM = std.goccupationMVM,
                GOrganisationF = std.gorganisationFVM,
                GOrganisationM = std.gorganisationMVM,
                GDesignationF = std.gdesignationFVM,
                GDesignationM = std.gdesignationsMVM


            };
            _context.GuardianInfo.Update(gi);
            await _context.SaveChangesAsync();



            return RedirectToAction("StudentList","AdmissionOfficer");
        }


        public IActionResult Details(Int64 id)
        {
           
           

            var std = _context.Student.Where(s => s.StudentId == id).ToList();

            if(std.Count!=0)
            {
                var grd = _context.GuardianInfo.Where(a => a.StudentID == id).ToList();
                if( grd.Count!=0)
                {

                    var query = (from st in std
                                 join g in grd on st.StudentId equals g.StudentID
                                 where st.StudentId == g.StudentID
                                 select new
                                 {
                                     stdntid = st.StudentId,
                                     stdntname = st.StudentName,
                                     stdntcls = st.StudentClass,
                                     stdntgender = st.StudentGender,
                                     stdntphoto = st.StudentPhoto,
                                     stdntcaddrss = st.StudentCAddress,
                                     stdntpaddrss = st.StudentPAddress,
                                     stdntdoa = st.DateOfAdmission,
                                     stdntnation = st.StudentNationality,
                                     stdntyear = st.Year,
                                     dob = st.StudentDOB,
                                     stdntbg = st.StudentBG,

                                     //Guardian Info

                                     GNameMA = g.GNameF,
                                     GNameMO = g.GNameM,
                                     GPhoneFA = g.GPhoneF,
                                     GPhoneMO = g.GPhoneM,
                                     GEmailMO = g.GEmailM,
                                     GEmailFA = g.GEmailF,
                                     GOccupationFA = g.GOccupationF,
                                     GOccupationMO = g.GOccupationM,
                                     GOrganisationFA = g.GOrganisationF,
                                     GOrganisationMO = g.GOrganisationM,
                                     GDesignationFA = g.GDesignationF,
                                     GDesignationMO = g.GDesignationM
                                 }).FirstOrDefault();

                    StudentViewModel svm = new StudentViewModel()
                    {
                        stdntnameVM = query.stdntname,
                        stdntidVM = query.stdntid,
                        stdntclsVM = query.stdntcls,
                        stdntgenderVM = query.stdntgender,
                        stdntphotoVM = query.stdntphoto,
                        stdntcaddrssVM = query.stdntcaddrss,
                        stdntpaddrssVM = query.stdntpaddrss,
                        stdntdoaVM = query.stdntdoa,
                        stdntnationVM = query.stdntnation,
                        stdntyearVM = query.stdntyear,
                        dobVM = query.dob,
                        ///Guardian info
                        gnameFVM = query.GNameMA,
                        gnameMVM = query.GNameMA,
                        gphoneFVM = query.GPhoneFA,
                        gphoneMVM = query.GPhoneMO,
                        gemailFVM = query.GEmailFA,
                        gemailMVM = query.GEmailMO,
                        goccupationFVM = query.GOccupationFA,
                        goccupationMVM = query.GOccupationMO,
                        gorganisationFVM = query.GOrganisationFA,
                        gorganisationMVM = query.GOrganisationMO,
                        gdesignationFVM = query.GDesignationFA,
                        gdesignationsMVM = query.GDesignationMO

                    };

                    return View(svm);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }

           

        }
    }
}