using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Abstract
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        //IEnumerable<Student> GetAllStudents { get; }
        IEnumerable<Student> SearchStudents(string searchTerm);
        void SaveStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        Student GetStudentById(int Id);
        void Dispose();
    }
}
