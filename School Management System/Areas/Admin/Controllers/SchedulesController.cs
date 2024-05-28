using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School_Management_System.Areas.Models;
using SchoolManagementSystem.Domain.Abstract;
using SchoolManagementSystem.Domain.EditModels;
using SchoolManagementSystem.Domain.Entities;
using SchoolManagementSystem.Domain.ViewModels;

namespace School_Management_System.Areas.Admin.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly ISchedulesRepository repository;
        public int PageSize = 10;

        public SchedulesController(ISchedulesRepository schedulesRepository)
        {
            this.repository = schedulesRepository;
        }
        // GET: Admin/Schedules
        public ActionResult Index()
        {
            SchedulesListViewModel model = new SchedulesListViewModel();

            model.Schedules = repository.GetAllSchedules();

            return View(model);          
        }

        [HttpPost]
        public JsonResult AddSchedules(SchedulesViewModel model)
        {
            Schedules schedules = new Schedules();


        //       public int Id { get; set; }
        //public Student Student_Id { get; set; }
        //public Courses Course_Id { get; set; }
        //public Staff Staff_Id { get; set; }
        //public DateTime Time_Start { get; set; }
        //public DateTime End_Date { get; set; }
            schedules.Id = model.Id;           
            schedules.Student_Id = model.Student_Id;
            schedules.Course_Id = model.Course_Id;
            schedules.Staff_Id = model.Staff_Id;
            schedules.Time_Start = model.Time_Start;
            schedules.End_Date = model.End_Date;

            repository.SaveSchedules(schedules);

            return Json(new
            {
                message = "Successfully added ",
                success = "true"
            });
        }

        [HttpPost]
        public JsonResult Deleted(int ID)
        {

            var schedules = repository.GetSchedulesById(ID);

            repository.DeleteSchedules(schedules);

            return Json(new
            {
                message = "Deleted Succesfully ",
                success = "true"
            });
        }

        //new edited
        [HttpPost]
        public JsonResult Edited(EditSchedulesModel model)
        {
            var schedules = repository.GetSchedulesById(model.Id);

            schedules.Id = model.Id;
            schedules.Student_Id = model.Student_Id;
            schedules.Course_Id = model.Course_Id;
            schedules.Staff_Id = model.Staff_Id;
            schedules.Time_Start = model.Time_Start;
            schedules.End_Date = model.End_Date;

            repository.UpdateSchedules(schedules);

            return Json(new
            {
                message = "Updated Succesfully ",
                success = "true"
            });
        }

        public ActionResult Details(int id)
        {
            var schedules = repository.GetSchedulesById(id);
            return View(schedules);
        }
    }
}