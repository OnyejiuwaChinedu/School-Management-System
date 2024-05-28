using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Abstract
{
    public interface ICoursesRepository
    {
        IEnumerable<Courses> GetAllCourses();
        IEnumerable<Courses> SearchCourse(string searchTerm);
        void SaveCourses(Courses course);
        void UpdateCourses(Courses course);
        void DeleteCourses(Courses course);
        Courses GetCoursesById(int Id);
        void Dispose();
    }
}
