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
    public class SubjectsController : Controller
    {
        // GET: Admin/Subjects
        private readonly ISubjectsRepository repository;
        public int PageSize = 10;

        public SubjectsController(ISubjectsRepository subjectsRepository)
        {
            this.repository = subjectsRepository;
        }
        public ActionResult Index()
        {
            SubjectsListViewModel model = new SubjectsListViewModel();

            model.Subjects = repository.GetAllSubjects();

            return View(model);
            
        }
        [HttpPost]
        public JsonResult AddSubjects(SubjectsViewModel model)
        {
            Subjects subjects = new Subjects();

            subjects.Id = model.Id;
            subjects.Name = model.Name;
            subjects.Course_Id = model.Course_Id;


            repository.SaveSubjects(subjects);

            return Json(new
            {
                message = "Successfully added ",
                success = "true"
            });
        }
        [HttpPost]
        public JsonResult Deleted(int ID)
        {

            var subjects = repository.GetSubjectsById(ID);

            repository.DeleteSubjects(subjects);

            return Json(new
            {
                message = "Deleted Succesfully ",
                success = "true"
            });
        }

        //new edited
        [HttpPost]
        public JsonResult Edited(EditSubjectsModel model)
        {
            var subjects = repository.GetSubjectsById(model.Id);

            subjects.Id = model.Id;
            subjects.Name = model.Name;
            subjects.Course_Id = model.Course_Id;

            repository.UpdateSubjects(subjects);

            return Json(new
            {
                message = "Updated Succesfully ",
                success = "true"
            });
        }

        public ActionResult Details(int id)
        {
            var subjects = repository.GetSubjectsById(id);
            return View(subjects);
        }
    }
}