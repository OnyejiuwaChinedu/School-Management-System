using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Abstract;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Concrete
{
    public class EFSubjectsRepository : ISubjectsRepository 
    {
        private readonly EFDbContext context = new EFDbContext();

        public void DeleteSubjects(Subjects subjects)
        {
            context.Entry(subjects).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<Subjects> GetAllSubjects()
        {
            { return context.Subjects; }
        }

        public Subjects GetSubjectsById(int Id)
        {
            return context.Subjects.Find(Id);
        }

        public void SaveSubjects(Subjects subjects)
        {

            context.Subjects.Add(subjects);

            context.SaveChanges();
        }

        public IEnumerable<Subjects> SearchSubject(string searchTerm)
        {
            var Subjects = context.Subjects.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                Subjects = Subjects.Where(a => a.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            return Subjects.ToList();
        }

        public void UpdateSubjects(Subjects subjects)
        {
            context.Entry(subjects).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }
    }
}
