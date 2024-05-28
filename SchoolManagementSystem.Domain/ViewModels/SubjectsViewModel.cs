using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.ViewModels
{
    public class SubjectsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Courses Course_Id { get; set; }
    }
}
