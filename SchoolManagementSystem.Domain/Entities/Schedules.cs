using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    public class Schedules
    {
        public int Id { get; set; }
        public Student Student_Id { get; set; }
        public Courses Course_Id { get; set; }
        public Staff Staff_Id { get; set; }
        public DateTime Time_Start { get; set; }
        public DateTime End_Date { get; set; }

    }
}
