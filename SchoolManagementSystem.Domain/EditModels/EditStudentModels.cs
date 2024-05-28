﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.EditModels
{
    public class EditStudentModels
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }
        public int Phone { get; set; }

        public string Email { get; set; }

        //[DataType(DataType.Date)]
        public string Password { get; set; }
    }
}
