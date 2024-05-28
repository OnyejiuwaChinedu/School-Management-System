using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Abstract;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Concrete
{
    public class EFSchedulesRepository : ISchedulesRepository
    {

        private readonly EFDbContext context = new EFDbContext();

        public void DeleteSchedules(Schedules schedules)
        {
            context.Entry(schedules).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<Schedules> GetAllSchedules()
        {

            return context.Schedules;
            
        }

        public Schedules GetSchedulesById(int Id)
        {
            return context.Schedules.Find(Id);
        }

        public void SaveSchedules(Schedules schedules)
        {
            context.Schedules.Add(schedules);

            context.SaveChanges();
        }

        public IEnumerable<Schedules> SearchSchedules(string searchTerm)
        {
            var Schedules = context.Schedules.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                Schedules = Schedules.Where(a => a.Id.ToString().Contains(searchTerm.ToLower()));
            }

            return Schedules.ToList();
        }

        public void UpdateSchedules(Schedules schedules)
        {
            context.Entry(schedules).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }
    }
}
