using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using School_Management_System.Models;
using SchoolManagementSystem.Domain.Entities;

namespace School_Management_System.Areas.Models
{
    public class StudentListViewModels
    {
        public IEnumerable<Student> Students { get; set; }

        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
    public class StudentActionModel
    {

        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }
        public int Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}