using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.ApplicationDb;
using SchoolManagementSystem.Areas.Admin.AdminVM;
using SchoolManagementSystem.Areas.Admin.Models;

namespace SchoolManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataBaseContext _context;
        public HomeController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddUser()
        {
            return View();
        }
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel rl)
        {
            if (ModelState.IsValid)
            {
                Role role = new Role
                {
                    RoleId = rl.roleidVM,
                    RoleType = rl.roletypeVM
                };
                 _context.Role.Add(role);
               await _context.SaveChangesAsync();

               return RedirectToAction("RoleList");
            }
            else
            {
                return NotFound();
            }
            
           
        }
        public IActionResult RoleList()
        {
            var r = _context.Role.ToList();
            List<RoleViewModel> rl = new List<RoleViewModel>();
            foreach (var item in r)
            {
                RoleViewModel rlvm = new RoleViewModel();
                rlvm.roleidVM = item.RoleId;
                 rlvm.roletypeVM = item.RoleType;
                rl.Add(rlvm); 
            }

            return View(rl);
        }
        public IActionResult UpdateRole(int u)
        {
            Role i = _context.Role.Where(q => q.RoleId == u).FirstOrDefault();
            RoleViewModel l = new RoleViewModel() {

                roleidVM=i.RoleId,
                roletypeVM=i.RoleType
            };
            return View(l);
        }
        [HttpPost]
        public IActionResult UpdateRole(RoleViewModel u)
        {
            Role l = new Role() {
            RoleId = u.roleidVM,
            RoleType = u.roletypeVM};
            _context.Role.Update(l);
            _context.SaveChanges();


            return RedirectToAction("RoleList");
        }

        public IActionResult AddClass()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddClass(ClassViewModel c)
        {
            Class cs = new Class()
            {
                ClassId=c.clsidVM,
                ClassName=c.clsnameVM

            };
            _context.Class.Add(cs);
            _context.SaveChanges();
            return View();
        }
        public IActionResult ClassList()
        {
            var r = _context.Class.ToList();
            List<ClassViewModel> rl = new List<ClassViewModel>();
            foreach (var item in r)
            {
                ClassViewModel rlvm = new ClassViewModel() {
                    clsidVM=item.ClassId,
                    clsnameVM=item.ClassName
                };
                rl.Add(rlvm);
            }

            return View(rl);
        }
        public IActionResult UpdateClass(int u)
        {
            Class i = _context.Class.Where(q => q.ClassId == u).FirstOrDefault();
            ClassViewModel l = new ClassViewModel()
            {

                clsidVM = i.ClassId,
                clsnameVM = i.ClassName
            };
            return View(l);
        }
        [HttpPost]
        public IActionResult UpdateClass(ClassViewModel u)
        {
            Class l = new Class() {
                ClassId = u.clsidVM,
               ClassName = u.clsnameVM};
            _context.Class.Update(l);
            _context.SaveChanges();


            return RedirectToAction("ClassList");
        }
        public IActionResult AddSection()
        {
            //Get the List of class
            var i = _context.Class.ToList();
            //insert a new element in position 0
            i.Insert(0, new Class { ClassId = 0, ClassName = "Select" });
            ViewBag.Class = i;
            return View();

        }
        [HttpPost]
        public async Task< IActionResult> AddSection(SectionViewModel sb)
        {
            //Get the List of class
            var i = _context.Class.ToList();
            //insert a new element in position 0
            i.Insert(0, new Class { ClassId = 0, ClassName = "Select" });
            ViewBag.Class = i;

            var sec = _context.Section.Where(st => st.ClassId == sb.clsidVM && st.SectionName==sb.secnameVM).FirstOrDefault();

            if(sec==null)
            {
                Section s = new Section()
                {
                    ClassId=sb.clsidVM,
                    SectionCapacity=sb.seccapacityVM,
                    SectionName=sb.secnameVM,
                    SectionSL=sb.secserialnoVM,
                    SectionYear=DateTime.Now.Year
                };
                await _context.Section.AddAsync(s);
                await _context.SaveChangesAsync();
                ViewBag.SMS = "Congratualation !!!You have successfully registered the section"+ s.SectionName+" for this class";
            }
            else
            {
                ViewBag.SMS = "OPS !!! You have already registered the section for this class";
            }


           

            ModelState.Clear();
            return View();

        }

        public IActionResult AddSubject()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSubject(SubjectViewModel sb)
        {
            Subject s = new Subject() {
                SubjectId=0,
                SubjectTitle=sb.sbjcttitleVM
            };
            await _context.Subject.AddAsync(s);
            await _context.SaveChangesAsync();
            ModelState.Clear();
            return View();
        }
        public IActionResult SubjectList()
        {
            List<Subject> s = _context.Subject.ToList();
            List<SubjectViewModel> sv = new List<SubjectViewModel>();
            foreach (var item in s)
            {
                SubjectViewModel vm = new SubjectViewModel()
                {
                    sbjctidVM = item.SubjectId,
                    sbjcttitleVM = item.SubjectTitle
                };
                sv.Add(vm);
               
            }
            return View(sv);
        }
        public async Task< IActionResult> UpdateSubject(Int64 id)
        {
            Subject s = await _context.Subject.FindAsync(id);
            SubjectViewModel vm = new SubjectViewModel()
            {
                sbjctidVM = s.SubjectId,
                sbjcttitleVM = s.SubjectTitle
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSubject(SubjectViewModel sb)
        {
            Subject s = new Subject()
            {
                SubjectId = sb.sbjctidVM,
                SubjectTitle = sb.sbjcttitleVM
            };
             _context.Subject.Update(s);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("SubjectList");
        }
        public IActionResult SubjectAssignedToTeacher()
        {
            var Subject = _context.Subject.ToList();
            var Teacher = _context.Teacher.ToList();
           // var Subject = _context.Subject.ToList();

            return View();
        }



    }
}