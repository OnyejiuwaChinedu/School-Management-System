using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}

