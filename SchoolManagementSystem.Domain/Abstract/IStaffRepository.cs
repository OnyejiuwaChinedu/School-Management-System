using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Abstract
{
    public interface IStaffRepository
    {
        IEnumerable<Staff> GetAllStaffs();
        IEnumerable<Staff> SearchStaff(string searchTerm);
        void SaveStaff(Staff staff);
        void UpdateStaff(Staff staff);
        void DeleteStaff(Staff staff);
        Staff GetStaffById(int Id);
        void Dispose();
    }
}
