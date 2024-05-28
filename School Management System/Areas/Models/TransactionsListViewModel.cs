using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolManagementSystem.Domain.Entities;

namespace School_Management_System.Areas.Models
{
    public class TransactionsListViewModel
    {
        public IEnumerable<Transactions> Transactions { get; set; }
    }

    public class TransactionsActionViewModel
    {
        public int Id { get; set; }
        public string Transaction_Name { get; set; }
        public Student Student_Id { get; set; }
        public DateTime Transaction_Date { get; set; }
    }
}