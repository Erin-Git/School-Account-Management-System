using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.ApplicationDb;
using SchoolManagementSystem.Areas.Accounts.Models;
using SchoolManagementSystem.Areas.Accounts.ViewModels;
using SchoolManagementSystem.Areas.Admin.Models;
using SchoolManagementSystem.Utilities;
using X.PagedList;

namespace SchoolManagementSystem.Areas.Accounts.Controllers
{
    [Area("Accounts")]
    public class AccountsController : Controller
    {
        private readonly DataBaseContext _context;
        public AccountsController(DataBaseContext _Context)
        {
            _context = _Context;
        }


        //set fee
        public IActionResult SetFee()
        {
            var i = _context.Class.ToList();
            i.Insert(0, new Class { ClassId = 0, ClassName = "Select the class" });
            ViewBag.Class = i;
            return View();
        }
        [HttpPost]
        public IActionResult SetFee(AccMngViewModel amvm)
        {
            var i = _context.Class.ToList();
            i.Insert(0, new Class { ClassId = 0, ClassName = "Select the class" });
            ViewBag.Class = i;
            if (amvm.classidVM == 0)
            {
                ViewBag.msg1 = "Please Choose a Class";
                return View();
            }

            AccountsManagement am = new AccountsManagement();
            am.FeeAmount = amvm.feeamountVM;
            am.ClassId = amvm.classidVM;
            var v = _context.AccountsManagement.Where(q => q.ClassId == amvm.classidVM).FirstOrDefault();
            if (v != null)
            {
                ViewBag.msg2 = "Fee is already set for this class!";
                return View();
            }
            _context.AccountsManagement.Add(am);
            _context.SaveChanges();
            ModelState.Clear();

            return View();
        }



        //fee list
        public IActionResult FeeList(int? page)
        {
            Int64 Count = 1;
            var pagenumber = page ?? 1;
            var v1 = _context.AccountsManagement.ToList();
            var v2 = _context.Class.ToList();
            var q = from vf in v1
                    join vc in v2 on vf.ClassId equals vc.ClassId
                    select new
                    {
                        pk = vf.AccountsManagementId,                       
                        feeamnt = vf.FeeAmount,
                        clsnm = vc.ClassName
                    };

            var amvmlist = new List<AccMngViewModel>();
            foreach (var item in q)
            {
                AccMngViewModel amvm = new AccMngViewModel();                
                amvm.serialnoVM = Count;
                Count++;
                amvm.feeamountVM = item.feeamnt;
                amvm.ClassName = item.clsnm;
                amvm.PrimaryKey = item.pk;
                amvmlist.Add(amvm);
            }
            var pg = amvmlist.ToPagedList(pagenumber, 5);
            return View(pg);
        }

        //update fee list
        public IActionResult UpdateFeeList(Int64 ufl)
        {
            //var i = _context.Class.ToList();
            //i.Insert(0, new Class { ClassId = 0, ClassName = "Select the class" });
            //ViewBag.Class = i;
            var v = _context.AccountsManagement.Where(q => q.AccountsManagementId == ufl).FirstOrDefault();
            AccMngViewModel amvm = new AccMngViewModel();
            amvm.classidVM = v.ClassId;
            amvm.feeamountVM = v.FeeAmount;
            amvm.PrimaryKey = v.AccountsManagementId;
            return View(amvm);
        }

        [HttpPost]
        public IActionResult UpdateFeeList(AccMngViewModel updt)
        {
            //var i = _context.Class.ToList();
            //i.Insert(0, new Class { ClassId = 0, ClassName = "Select the class" });
            //ViewBag.Class = i;
            //if (updt.classidVM == 0)
            //{
            //    ViewBag.msg = "Please Select a Class";
            //    return View();
            //}
            AccountsManagement am = new AccountsManagement();
            am.ClassId = updt.classidVM;
            am.FeeAmount = updt.feeamountVM;
            am.AccountsManagementId = updt.PrimaryKey;
            _context.AccountsManagement.Update(am);
            _context.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("FeeList");
        }



        //set extra fee
        public IActionResult SetExtraFee()
        {
            var vexf = _context.Class.ToList();
            vexf.Insert(0, new Class { ClassId = 0, ClassName = "Select Class" });
            ViewBag.vwvexf = vexf;
            ModelState.Clear();
            return View();
        }
        [HttpPost]
        public IActionResult SetExtraFee(ExtraFeeViewModel efvm)
        {
            var vexf = _context.Class.ToList();
            vexf.Insert(0, new Class { ClassId = 0, ClassName = "Select Class" });
            ViewBag.vwvexf = vexf;
            if (efvm.classidVM == 0)
            {
                ViewBag.msg1 = "Please choose a class";
                return View();
            }
            ExtraFee ef = new ExtraFee();
            ef.ExtraFeeId = 0;
            ef.ExtraFeeTitle = efvm.extrafeetitleVM;
            ef.ExtraFeeAmount = efvm.extrafeeamountVM;
            ef.ClassId = efvm.classidVM;
            var v = _context.ExtraFee.Where(q => q.ClassId == efvm.classidVM && q.ExtraFeeTitle == efvm.extrafeetitleVM).FirstOrDefault();
            if (v != null)
            {
                ViewBag.msg2 = "Extra Fee is already set for this class!";
                return View();
            }
            _context.ExtraFee.Add(ef);
            _context.SaveChanges();
            ModelState.Clear();
            return View();
        }


        //extra fe list 
        public IActionResult ExtraFeeList(int? page)
        {
            Int64 Count = 1;
            var pagenumber = page ?? 1;
            var v1 = _context.ExtraFee.ToList();
            var v2 = _context.Class.ToList();
            var q = from vef in v1
                    join vc in v2 on vef.ClassId equals vc.ClassId
                    select new
                    {
                        pk = vef.ExtraFeeId,
                        clsname = vc.ClassName,
                        exft = vef.ExtraFeeTitle,
                        exfa = vef.ExtraFeeAmount
                    };
            var efvmlist = new List<ExtraFeeViewModel>();
            foreach (var item in q)
            {
                ExtraFeeViewModel efvm = new ExtraFeeViewModel();
                efvm.serialnoVM = Count;
                Count++;
                efvm.PrimaryKey = item.pk;
                efvm.extrafeetitleVM = item.exft;
                efvm.extrafeeamountVM = item.exfa;
                efvm.classnameVM = item.clsname;
                efvmlist.Add(efvm);
            }
            var pg = efvmlist.ToPagedList(pagenumber, 3);
            return View(pg);
        }


        //update extra fee list
        public IActionResult UpdateExtraFeeList(Int64 uefl)
        {
            //var vexf = _context.Class.ToList();
            //vexf.Insert(0, new Class { ClassId = 0, ClassName = "Select Class" });
            //ViewBag.vwvexf = vexf;
            
            var v = _context.ExtraFee.Where(q => q.ExtraFeeId == uefl).FirstOrDefault();
            ExtraFeeViewModel efvm = new ExtraFeeViewModel();
            efvm.classidVM = v.ClassId;
            efvm.extrafeetitleVM = v.ExtraFeeTitle;
            efvm.extrafeeamountVM = v.ExtraFeeAmount;
            efvm.PrimaryKey = v.ExtraFeeId;
            return View(efvm);
        }

        [HttpPost]
        public IActionResult UpdateExtraFeeList(ExtraFeeViewModel updt)
        {
            //var vexf = _context.Class.ToList();
            //vexf.Insert(0, new Class { ClassId = 0, ClassName = "Select Class" });
            //ViewBag.vwvexf = vexf;
            //if (updt.classidVM == 0)
            //{
            //    ViewBag.msg = "Please Select a Class";
            //    return View();
            //}

            ExtraFee ef = new ExtraFee();
            ef.ExtraFeeId = updt.PrimaryKey;
            ef.ClassId = updt.classidVM;
            ef.ExtraFeeTitle = updt.extrafeetitleVM;
            ef.ExtraFeeAmount = updt.extrafeeamountVM;
            _context.ExtraFee.Update(ef);
            _context.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("ExtraFeeList");
        }



        //fee submission 
        
        public IActionResult EnterStdntInfo()
        {
            var c = _context.Class.ToList();
            c.Insert(0, new Class { ClassId = 0, ClassName = "Select Class" });
            ViewBag.vc = c;
            return View();
        }

        [HttpPost]
        public IActionResult EnterStdntInfo(FeeSubViewModel fsvm)
        {         
            var c = _context.Class.ToList();
            c.Insert(0, new Class { ClassId = 0, ClassName = "Select Class" });
            ViewBag.vc = c;
            if (fsvm.classidVM == 0)
            {
                ViewBag.msg1 = "Please choose a class";
                return View();
            }
            var s = _context.Student.Where(q => q.StudentId == fsvm.studentidVM && q.StudentClass == fsvm.classidVM).FirstOrDefault();
            if (s == null)
            {
                ViewBag.msg2 = "Enter valid student ID";
                return View();
            }



            //first time paying fee
            var fs1 = _context.FeeSubmission.Where(q => q.StudentId == fsvm.studentidVM && q.ClassId == fsvm.classidVM).FirstOrDefault();

            if (fs1 == null)
            {
                return RedirectToAction("ShowFeeDetailsNew", new { sid1 = fsvm.studentidVM, cid1 = fsvm.classidVM,date1=fsvm.dateVM });
            }
            
            //has due

            var fs2 = _context.FeeSubmission.Where(q => q.DueAmount == 0 && q.StudentId == fsvm.studentidVM && q.ClassId == fsvm.classidVM && q.Date.Month==fsvm.dateVM.Month && q.Date.Year==fsvm.dateVM.Year).LastOrDefault();
            
                if (fs2 != null)
                {
                    ViewBag.msg3 = "Paid";
                    return View();
                }

            var fs3 = _context.FeeSubmission.Where(q => q.DueAmount != 0 && q.StudentId == fsvm.studentidVM && q.ClassId == fsvm.classidVM && q.Date.Month == fsvm.dateVM.Month && q.Date.Year == fsvm.dateVM.Year).LastOrDefault();
            if(fs3!=null)
            {
                return RedirectToAction("DueForSameMonth", new { sid3 = fsvm.studentidVM, cid3 = fsvm.classidVM , date3 = fsvm.dateVM }); //only due, not next month fee
            }

            var fs4 = _context.FeeSubmission.Where(q => /*q.DueAmount != 0 &&*/ q.StudentId == fsvm.studentidVM && q.ClassId == fsvm.classidVM && q.Date.Month != fsvm.dateVM.Month /*&& q.Date.Year == fsvm.dateVM.Year*/).LastOrDefault();
            if(fs4!=null)
            {
                return RedirectToAction("ShowFeeDetails", new { sid2 = fsvm.studentidVM, cid2 = fsvm.classidVM , date2 = fsvm.dateVM });
            }
            
            return View();
        }

        //first time paying fee method
        public IActionResult ShowFeeDetailsNew(Int64 sid1, Int64 cid1,DateTime date1)
        {
            var ef1 = _context.ExtraFee.Where(q => q.ClassId == cid1).ToList();
            ef1.Insert(0,new ExtraFee { ExtraFeeAmount = 0, ExtraFeeTitle = "Select Extra Fee" });
            ViewBag.v = ef1;

            var s = _context.Student.ToList();
            var c = _context.Class.ToList();
            var am = _context.AccountsManagement.ToList();
            var ef2 = _context.ExtraFee.ToList();           
            var query = (from vs in s
                         join vc in c on vs.StudentClass equals vc.ClassId
                         join vam in am on vs.StudentClass equals vam.ClassId
                         join vef in ef2 on vs.StudentClass equals vef.ClassId
                         where sid1 == vs.StudentId && cid1 == vc.ClassId
                         select new
                         {
                             name = vs.StudentName,
                             id = vs.StudentId,
                             cls = vc.ClassName,
                             clsid = vc.ClassId,
                             fee = vam.FeeAmount,                               
                         }).FirstOrDefault();
            FeeSubViewModel fsvm = new FeeSubViewModel();
            fsvm.studentidVM = query.id;
            fsvm.studentnameVM = query.name;
            fsvm.classnameVM = query.cls;
            fsvm.classidVM = query.clsid;
            fsvm.feeamountVM = query.fee;        
            fsvm.totalfeeVM = query.fee;
            fsvm.ShouldtotalfeeVM = query.fee;
            fsvm.dateVM = date1;
            return View(fsvm);
        }

        //has due method
        public IActionResult ShowFeeDetails(Int64 sid2, Int64 cid2, DateTime date2)
        {
            var ef1 = _context.ExtraFee.Where(q => q.ClassId == cid2).ToList();
            ef1.Insert(0, new ExtraFee { ExtraFeeAmount = 0, ExtraFeeTitle = "Select Extra Fee" });
            ViewBag.v = ef1;

            var s = _context.Student.ToList();
            var c = _context.Class.ToList();
            var am = _context.AccountsManagement.ToList();
            var ef = _context.ExtraFee.ToList();
            var fs = _context.FeeSubmission.ToList();
            var g = _context.FeeSubmission.Where(a => a.StudentId == sid2 && a.ClassId == cid2).LastOrDefault();
            var h = Convert.ToInt32(g.Date.Month);  //last month from database
            var j = Convert.ToInt32(date2.Month);  //input month
            var k = j - h;
            ViewBag.showdate =g.Date.ToLongDateString();
            var query = (from vs in s
                         join vc in c on vs.StudentClass equals vc.ClassId
                         join vam in am on vs.StudentClass equals vam.ClassId
                         join vef in ef on vs.StudentClass equals vef.ClassId
                         join vfs in fs on vs.StudentId equals vfs.StudentId
                         where sid2 == vs.StudentId && cid2 == vc.ClassId
                         select new
                         {
                             name = vs.StudentName,
                             id = vs.StudentId,
                             cls = vc.ClassName,
                             clsid = vc.ClassId,
                             fee = vam.FeeAmount,
                             due = vfs.DueAmount,
                             total = vam.FeeAmount + vfs.DueAmount
                         }).LastOrDefault();
          
            FeeSubViewModel fsvm = new FeeSubViewModel();
            fsvm.studentidVM = query.id;
            fsvm.studentnameVM = query.name;
            fsvm.classnameVM = query.cls;
            fsvm.classidVM = query.clsid;
            fsvm.dueamountVM = query.due;
            fsvm.amountofmonth = k;
            var e = h + 1;
            fsvm.lastmonth =  new DateTimeFormatInfo().GetMonthName(e);
            fsvm.currentmonth =  new DateTimeFormatInfo().GetMonthName(j);

            if (k > 1)
            {
                fsvm.feeamountVM = query.fee * k;
                fsvm.totalfeeVM = query.due + fsvm.feeamountVM;
                fsvm.ShouldtotalfeeVM = query.due + fsvm.feeamountVM;
            }
            else if(k==1)
            {
                fsvm.feeamountVM = query.fee;
                fsvm.totalfeeVM = query.total;
                fsvm.ShouldtotalfeeVM = query.total;
            }
            else if(k<0)
            {
                fsvm.feeamountVM = query.fee *(j+(12-h));
                fsvm.totalfeeVM = query.due + fsvm.feeamountVM;
                fsvm.ShouldtotalfeeVM = query.due + fsvm.feeamountVM;
                fsvm.amountofmonth = j + (12 - h);

            }
            fsvm.dateVM =date2;
            
            return View(fsvm);
        }
        

        public IActionResult DueForSameMonth(Int64 sid3,Int64 cid3,DateTime date3)
        {
            var ef1 = _context.ExtraFee.Where(q => q.ClassId == cid3).ToList();
            ef1.Insert(0, new ExtraFee { ExtraFeeAmount = 0, ExtraFeeTitle = "Select Extra Fee" });
            ViewBag.v = ef1;

            var g = _context.FeeSubmission.Where(a => a.StudentId == sid3 && a.ClassId == cid3).LastOrDefault();
            var j = Convert.ToInt32(date3.Month);
            ViewBag.showdate = g.Date.ToLongDateString();

            var s = _context.Student.ToList();
            var c = _context.Class.ToList();
            var am = _context.AccountsManagement.ToList();
            var ef = _context.ExtraFee.ToList();
            var fs = _context.FeeSubmission.ToList();
            var query = (from vs in s
                         join vc in c on vs.StudentClass equals vc.ClassId
                         join vam in am on vs.StudentClass equals vam.ClassId
                         join vef in ef on vs.StudentClass equals vef.ClassId
                         join vfs in fs on vs.StudentId equals vfs.StudentId
                         where sid3 == vs.StudentId && cid3 == vc.ClassId
                         select new
                         {
                             name = vs.StudentName,
                             id = vs.StudentId,
                             cls = vc.ClassName,
                             clsid = vc.ClassId,
                             due = vfs.DueAmount,
                             total =  vfs.DueAmount
                         }).LastOrDefault();
            FeeSubViewModel fsvm = new FeeSubViewModel();
            fsvm.studentidVM = query.id;
            fsvm.studentnameVM = query.name;
            fsvm.classnameVM = query.cls;
            fsvm.classidVM = query.clsid;
            fsvm.dueamountVM = query.due;
            fsvm.totalfeeVM = query.total;
            fsvm.dateVM = date3;
            fsvm.ShouldtotalfeeVM = query.total;
            return View(fsvm);          
        }
        

        [HttpPost]
        public IActionResult SubmitFee(FeeSubViewModel fsvm)
        {
            var v = _context.FeeSubmission.Where(q => q.StudentId == fsvm.studentidVM).LastOrDefault();
            FeeSubmission fs = new FeeSubmission();
            fs.ClassId = fsvm.classidVM;
            fs.StudentId = fsvm.studentidVM;
            if (fsvm.totalfeeVM == 0)
            {
                ViewBag.msg4 = "You haven't entered any amount!";
                return View();
            }
            if (v != null)
            {
                var f = Math.Abs(fsvm.ShouldtotalfeeVM - fsvm.totalfeeVM);
                if (f == 0)
                {
                    fs.DueAmount = 0;
                }
                else
                {
                    fs.DueAmount = f;
                }
            }
            else
            {
                var f = Math.Abs(fsvm.ShouldtotalfeeVM - fsvm.totalfeeVM);
                if (f == 0)
                {
                    fs.DueAmount = 0;
                }
                else
                {
                    fs.DueAmount = f;
                }
            }

            fs.TotalFee = fsvm.totalfeeVM;
            fs.FeeAmount = fsvm.feeamountVM;
            fs.Date = fsvm.dateVM;
            fs.ExtraFeeAmount = fsvm.extrafeeamountVM;
            _context.FeeSubmission.Add(fs);
            _context.SaveChanges();
           
            ModelState.Clear();
            var d = _context.Class.Where(q => q.ClassId == fs.ClassId).FirstOrDefault();
            var dq = _context.Student.Where(q => q.StudentId == fs.StudentId).FirstOrDefault();
            var de = _context.AccountsManagement.Where(q => q.ClassId == fs.ClassId).FirstOrDefault();
            //var ex = _context.ExtraFee.Where(q => q.ClassId == fs.ClassId).FirstOrDefault();
            var fsn = _context.FeeSubmission.Where(q => q.StudentId == fs.StudentId && q.ClassId == fs.ClassId).LastOrDefault();


            FeeSubViewModel fsvm1 = new FeeSubViewModel();
            fsvm1.studentidVM = fsn.StudentId;
            fsvm1.classidVM = fsn.ClassId;
            fsvm1.dt = fsn.Date.ToLongDateString();
            fsvm1.studentnameVM = dq.StudentName;
            fsvm1.classnameVM = d.ClassName;
            fsvm1.feeamountVM = de.FeeAmount;
            fsvm1.extrafeeamountVM =fsn.ExtraFeeAmount;
            fsvm1.dueamountVM = fsn.DueAmount;
            fsvm1.totalfeeVM = fsn.TotalFee;
            fsvm1.amountofmonth = fsvm.amountofmonth;
            fsvm1.lastmonth = fsvm.lastmonth;
            fsvm1.currentmonth = fsvm.currentmonth;
         
            fsvm1.inwords = NumToText.ToText(Convert.ToInt32(fsvm1.totalfeeVM));

            return RedirectToAction("InvoiceOption",new RouteValueDictionary(fsvm1));
        }

        public IActionResult InvoiceOption(FeeSubViewModel fsvm)
        {          
            return View(fsvm);
        }
        [HttpPost]
        public IActionResult PrintInvoice(FeeSubViewModel fs)
        {
           
            return View(fs);
        }
        public IActionResult Search()
        {
            var i = _context.Class.ToList();
            i.Insert(0, new Class { ClassId = 0, ClassName = "Select the class" });
            ViewBag.Class = i;
            return View();
        }

      
        public async Task< IActionResult> SearchResult(FeeSubViewModel cid,Int64 cid2)
        {
            if(cid2!=0)
            {
                cid.classidVM = cid2;
            }
            var i = _context.Class.ToList();
            i.Insert(0, new Class { ClassId = 0, ClassName = "Select the class" });
            ViewBag.Class = i;

            var v = await _context.FeeSubmission.AsNoTracking().Where(q => q.ClassId == cid.classidVM).ToListAsync();
            if (v == null)
            {
                return View();
            }
            var s = await _context.Student.AsNoTracking().Where(q => q.StudentClass == cid.classidVM).ToListAsync();
            var c = await _context.Class.AsNoTracking().Where(q => q.ClassId == cid.classidVM).ToListAsync();
            var query = from vq in v
                        join sq in s on vq.ClassId equals sq.StudentClass
                        join cq in c on vq.ClassId equals cq.ClassId
                        select new
                        {
                            ClassName = cq.ClassName,
                            StudentName = sq.StudentName,
                            StudentId = sq.StudentId,
                            Fee = vq.TotalFee,
                            Due = vq.DueAmount
                        };

            var srchlist = new List<FeeSubViewModel>();
            int count = 1;
            foreach (var item in query)
            {
                FeeSubViewModel fsvm = new FeeSubViewModel();
                fsvm.serialnoVM = count;
                fsvm.classnameVM = item.ClassName;
                fsvm.studentidVM = item.StudentId;
                fsvm.studentnameVM = item.StudentName;
                fsvm.totalfeeVM = item.Fee;
                fsvm.dueamountVM = item.Due;
                srchlist.Add(fsvm);
                count++;
            }
            
            return View(srchlist);
        }





        //set teacher's salary
        public IActionResult SetSalary()
        {
            var vss = _context.TeacherDesignation.ToList();
            vss.Insert(0,new TeacherDesignation { DesigId = 0, DesigName="Select a designation"});
            ViewBag.ss = vss;
            return View();
        }

        [HttpPost]
        public IActionResult SetSalary(TeacherSalaryViewModel tsvm)
        {
            var vss = _context.TeacherDesignation.ToList();
            vss.Insert(0, new TeacherDesignation { DesigId = 0, DesigName = "Select a designation" });
            ViewBag.ss = vss;
            if(tsvm.desigidVM==0)
            {
                ViewBag.msg1 = "Please choose a designation";
                return View();
            }

            var v = _context.TeacherSalary.Where(q => q.DesigId == tsvm.desigidVM).FirstOrDefault();
            if(v!=null)
            {
                ViewBag.msg2 = "Salary is already set for this designation";
                return View();
            }
            TeacherSalary ts = new TeacherSalary();

            ts.SerialNo = 0;
            ts.Salary = tsvm.salaryVM;
            ts.DesigId = tsvm.desigidVM;         
            _context.TeacherSalary.Add(ts);
            _context.SaveChanges();
            ModelState.Clear();
            return View();
        }


        //salary list
        public IActionResult SalaryList(int? page)
        {
            Int64 Count = 1;
            var pagenumber = page ?? 1;
            var v1 = _context.TeacherSalary.ToList();
            var v2 = _context.TeacherDesignation.ToList();
            var q = from vts in v1
                    join vtd in v2 on vts.DesigId equals vtd.DesigId
                    select new
                    {
                        pk =vts.SerialNo,
                        dsgnm = vtd.DesigName,
                        tcrsal = vts.Salary
                    };
            
            var tsvmlist = new List<TeacherSalaryViewModel>();
            foreach (var item in q)
            {
                TeacherSalaryViewModel tsvm = new TeacherSalaryViewModel();
                tsvm.serialnoVM = Count;
                Count++;

                tsvm.PrimaryKey = item.pk;
                tsvm.designameVM=item.dsgnm;
                tsvm.salaryVM = item.tcrsal;
                tsvmlist.Add(tsvm);
            }
            var pg = tsvmlist.ToPagedList(pagenumber, 2);
            return View(pg);
        }



       

        //update teacher salary
        public IActionResult UpdateTeacherSalary(Int64 uts)
        {
            //var v = _context.TeacherDesignation.ToList();
            //v.Insert(0, new TeacherDesignation { DesigId = 0, DesigName = "Select a Designation" });
            //ViewBag.td = v;

            var v1 = _context.TeacherSalary.Where(q => q.SerialNo == uts).FirstOrDefault();
            TeacherSalaryViewModel tsvm = new TeacherSalaryViewModel();
            tsvm.PrimaryKey = v1.SerialNo;
            tsvm.desigidVM = v1.DesigId;
           
            tsvm.salaryVM = v1.Salary;
            
            return View(tsvm);
        }

        [HttpPost]
        public IActionResult UpdateTeacherSalary(TeacherSalaryViewModel updt)
        {
            //var v = _context.TeacherDesignation.ToList();
            //v.Insert(0, new TeacherDesignation { DesigId = 0, DesigName = "Select a Designation" });
            //ViewBag.td = v;
            //if(updt.desigidVM==0)
            //{
            //    ViewBag.msg = "Please Select a Designation";
            //    return View();
            //}

            TeacherSalary ts = new TeacherSalary();
            ts.SerialNo = updt.PrimaryKey;
            ts.DesigId = updt.desigidVM;
            ts.Salary = updt.salaryVM;

            _context.TeacherSalary.Update(ts);
            _context.SaveChanges();
            return RedirectToAction("SalaryList");
        }


        //teacher's salary details
        public IActionResult SalaryDetails()
        {
            Int64 Count = 1;
            var v1 = _context.TeacherSalary.ToList();
            var v2 = _context.Teacher.ToList();
            var v3 = _context.TeacherDesignation.ToList();
            var q = from vts in v1
                    join vt in v2 on vts.DesigId equals vt.DesigId
                    join vtd in v3 on vts.DesigId equals vtd.DesigId
                    orderby vt.TeacherName ascending
                    select new
                    {
                        pk = vts.SerialNo,
                        tcrnm = vt.TeacherName,
                        dsgnm = vtd.DesigName,
                        tcrsal = vts.Salary
                    };

            var tsvmlist = new List<TeacherSalaryViewModel>();
            foreach (var item in q)
            {
                TeacherSalaryViewModel tsvm = new TeacherSalaryViewModel();
                tsvm.serialnoVM = Count;
                Count++;

                tsvm.salaryVM = item.tcrsal;
                tsvm.designameVM = item.dsgnm;
                tsvm.tcrnameVM = item.tcrnm;
                tsvm.PrimaryKey = item.pk;
                tsvmlist.Add(tsvm);
            }
            return View(tsvmlist);
        }

        public IActionResult EnterTcrInfo()
        {
            var t = _context.Teacher.ToList();
            t.Insert(0, new Teacher { TeacherId = 0, TeacherName = "Select Teacher" });
            ViewBag.vt = t;
            return View();
        }
        [HttpPost]
        public IActionResult EnterTcrInfo(SalaryDetailsViewModel sdvm)
        {
            var t = _context.Teacher.ToList();
            t.Insert(0, new Teacher { TeacherId = 0, TeacherName = "Select Teacher" });
            ViewBag.vt = t;
            if(sdvm.teacheridVM==0)
            {
                ViewBag.msg1 = "Please select a teacher";
                return View();
            }
            var v = _context.SalaryDetails.Where(q => q.TeacherId == sdvm.teacheridVM && sdvm.dateVM.Month==q.Date.Month && sdvm.dateVM.Year == q.Date.Year).FirstOrDefault();
            if (v != null)
            {
                ViewBag.msg2 = "Salary is already paid for this teacher";
                return View();
            }
            return RedirectToAction("ShowSalaryDetails",new { tid=sdvm.teacheridVM,date=sdvm.dateVM});
        }
        
        public IActionResult ShowSalaryDetails(Int64 tid,DateTime date)
        {
           
            var t = _context.Teacher.ToList();
            var td = _context.TeacherDesignation.ToList();
            var ts = _context.TeacherSalary.ToList();
            var query = (from qt in t
                         join qtd in td on qt.DesigId equals qtd.DesigId
                         join qts in ts on qt.DesigId equals qts.DesigId
                         where qt.TeacherId==tid 
                         select new
                         {
                             tcrid=tid,
                             tcrname=qt.TeacherName,
                             tcrdsgid=qtd.DesigId,
                             tcrdsg=qtd.DesigName,
                             sal=qts.Salary,
                             dt =date
                         }).FirstOrDefault();
            SalaryDetailsViewModel sdvm = new SalaryDetailsViewModel();
            sdvm.teacheridVM = query.tcrid;
            sdvm.teachernameVM = query.tcrname;
            sdvm.desigidVM = query.tcrdsgid;
            sdvm.designameVM = query.tcrdsg;
            sdvm.salaryVM = query.sal;
            sdvm.dateVM = query.dt;
            return View(sdvm);
        }

        [HttpPost]
        public IActionResult GiveSalary(SalaryDetailsViewModel sdvm)
        { 
            SalaryDetails sd = new SalaryDetails();
            sd.SalaryDetailsId = 0;
            sd.TeacherId = sdvm.teacheridVM;
            sd.TeacherName = sdvm.teachernameVM;
            sd.DesigId = sdvm.desigidVM;
            sd.DesigName = sdvm.designameVM;
            sd.Salary = sdvm.salaryVM;
            sd.Date = sdvm.dateVM;
            sd.Status = true;
            _context.SalaryDetails.Add(sd);
            _context.SaveChanges();
            return RedirectToAction("EnterTcrInfo");
        }

        //public async Task<IActionResult> SearchTeacherSalary()
        //{
        //    return View();
        //}



        //public async Task<IActionResult> SalaryResult()
        //{
        //    var t1 =await _context.Teacher.AsNoTracking().ToListAsync();
        //    var t2 =await _context.TeacherSalary.AsNoTracking().ToListAsync();
        //    var t3 = await _context.SalaryDetails.Include(s=>s.Teacher).AsNoTracking().ToListAsync();

        //    var query = from vt1 in t1
        //                join vt2 in t2 on vt1.DesigId equals vt2.DesigId
        //                join vt3 in t3 on vt1.TeacherId equals vt3.TeacherId
        //                where vt1.DesigId == vt3.DesigId
        //                select new
        //                {
        //                    TeacherName =vt1.TeacherName,
        //                    TeacherId=vt1.TeacherId,
        //                    Designation=vt1.TeacherDesignation,
        //                    Salary=vt2.Salary,
        //                    Status=vt3.Status,
        //                    Date=vt3.Date
        //                };
        //    var sslist =new List<SalaryDetailsViewModel>();
        //    foreach (var item in query)
        //    {
        //        SalaryDetailsViewModel sdvm = new SalaryDetailsViewModel();

        //        sdvm.teacheridVM = item.TeacherId;
        //        sdvm.teachernameVM = item.TeacherName;
        //        sdvm.designameVM = item.Designation;
        //        sdvm.salaryVM = item.Salary;
        //        sdvm.dateVM = item.Date;
                //if(item.Status!=true)
                //{
                //    ViewBag.notpaid = "Not Paid";
                //}
                //else
                //{
                //    ViewBag.paid = "Paid";
                //}
        //        sdvm.PaymentStatus = item.Status;
               
               
        //        sslist.Add(sdvm);
        //    }
        //    return View(sslist);
        //}
    }
}
