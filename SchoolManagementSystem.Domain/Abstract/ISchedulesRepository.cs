using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Abstract
{
    public interface ISchedulesRepository
    {
        IEnumerable<Schedules> GetAllSchedules();
        IEnumerable<Schedules> SearchSchedules(string searchTerm);
        void SaveSchedules(Schedules schedules);
        void UpdateSchedules(Schedules schedules);
        void DeleteSchedules(Schedules schedules);
        Schedules GetSchedulesById(int Id);
        void Dispose();
    }
}
