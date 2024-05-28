using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Abstract;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Concrete
{
    public class EFCoursesRepository : ICoursesRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        
        public EFCoursesRepository(EFDbContext dbContext)
        {
            context = dbContext;
        }

        public void DeleteCourses(Courses course)
        {
            context.Entry(course).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }

        IEnumerable<Courses> ICoursesRepository.GetAllCourses()
        {         
             return context.Courses; 
        }

        public Courses GetCoursesById(int Id)
        {
            return context.Courses.Find(Id);
        }

        public void SaveCourses(Courses course)
        {
            context.Courses.Add(course);

            context.SaveChanges();
        }

        public IEnumerable<Courses> SearchCourse(string searchTerm)
        {
            var Courses = context.Courses.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                Courses = Courses.Where(a => a.Course_Name.ToLower().Contains(searchTerm.ToLower()));
            }

            return Courses.ToList();
        }

        public void UpdateCourses(Courses course)
        {
            context.Entry(course).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
