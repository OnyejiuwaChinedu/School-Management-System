using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Abstract
{
    public interface ISubjectsRepository
    {
        IEnumerable<Subjects> GetAllSubjects();
        IEnumerable<Subjects> SearchSubject(string searchTerm);
        void SaveSubjects(Subjects subjects);
        void UpdateSubjects(Subjects subjects);
        void DeleteSubjects(Subjects subjects);
        Subjects GetSubjectsById(int Id);
        void Dispose();
    }
}
