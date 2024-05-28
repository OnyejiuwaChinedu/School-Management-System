using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolManagementSystem.Domain.Entities;

namespace School_Management_System.Areas.Models
{
    public class CoursesListViewModel
    {
        public IEnumerable<Courses> Courses { get; set; }
    }

    public class CoursesActionViewModel
    {
        public int Id { get; set; }
        public string Course_Name { get; set; }
        public string Course_Description { get; set; }
        public string School_Year { get; set; }
    }
}