using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.EditModels
{
    public class EditSubjectsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Courses Course_Id { get; set; }
    }
}
