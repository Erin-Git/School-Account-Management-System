using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Areas.Accounts.Models;
using SchoolManagementSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.ApplicationDb
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }
        public DbSet<Role> Role { get; set; }
        public DbSet<GuardianInfo> GuardianInfo { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherDocSubmitted> TeacherDocSubmitted { get; set; }
        public DbSet<TeacherQualification> TeacherQualification { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<AccountsManagement> AccountsManagement { get; set; }
        public DbSet<ExtraFee> ExtraFee { get; set; }
        public DbSet<TeacherSalary> TeacherSalary { get; set; }
        public DbSet<FeeSubmission> FeeSubmission { get; set; }
        public DbSet<TeacherDesignation> TeacherDesignation { get; set; }
        public DbSet<SalaryDetails> SalaryDetails { get; set; }
        
    }
}
