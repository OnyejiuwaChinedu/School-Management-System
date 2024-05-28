using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolManagementSystem.Domain.Entities;

namespace School_Management_System.Areas.Models
{
    public class SubjectsListViewModel
    {
        public IEnumerable<Subjects> Subjects { get; set; }
    }
    public class SubjectsActionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Courses Course_Id { get; set; }
    }
}