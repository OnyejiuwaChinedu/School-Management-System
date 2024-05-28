using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolManagementSystem.Domain.Entities;

namespace School_Management_System.Areas.Models
{
    public class SchedulesListViewModel
    {
        public IEnumerable<Schedules> Schedules { get; set; }
    }
    public class SchedulesActionViewModel
    {
        public int Id { get; set; }
        public string Student_Id { get; set; }
        public string Course_Id { get; set; }
        public string Staff_Id { get; set; }
        public DateTime Time_Start { get; set; }
        public DateTime End_Date { get; set; }
    }
}