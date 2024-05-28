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
    public class CoursesController : Controller
    {
        // GET: Admin/Courses
        private readonly ICoursesRepository repository;
        public int PageSize = 10;
        Courses Courses = new Courses();

        public CoursesController(ICoursesRepository coursesRepository)
        {
            this.repository = coursesRepository;
        }
        public ActionResult Index()
        {

            CoursesListViewModel model = new CoursesListViewModel();

            model.Courses = repository.GetAllCourses();

            return View(model);
           
        }
        [HttpPost]
        public JsonResult AddCourses(CoursesViewModel model)
        {
            Courses courses = new Courses();

            //courses.Id = model.Id;
            courses.Course_Name = model.Course_Name;
            courses.Course_Description = model.Course_Description;
            courses.School_Year = model.School_Year;

            repository.SaveCourses(courses);

            return Json(new
            {
                message = "Successfully added ",
                success = "true"
            });
        }

        [HttpPost]
        public JsonResult Deleted(int ID)
        {

            var courses = repository.GetCoursesById(ID);

            repository.DeleteCourses(courses);

            return Json(new
            {
                message = "Deleted Succesfully ",
                success = "true"
            });
        }
        //new edit
        [HttpPost]
        public JsonResult Edited(EditCoursesModel model)
        {
            JsonResult json = new JsonResult();

            var result = false;
            if (model.Id > 0) // tyring to edit model
            {
                var courses = repository.GetCoursesById(model.Id);

                //courses.C = model.AccomodationPackageID;

                courses.Id = model.Id;
                courses.Course_Name = model.Course_Name;
                courses.Course_Description = model.Course_Description;
                courses.School_Year = model.School_Year;


                repository.UpdateCourses(courses);
            }
            else // create the record
            {
                Courses courses = new Courses();
                courses.Id = model.Id;
                courses.Course_Name = model.Course_Name;
                courses.Course_Description = model.Course_Description;
                courses.School_Year = model.School_Year;

                repository.SaveCourses(courses);

            }

            if (result)
            {

                json.Data = new { Success = true };
            }
            else
            {

                json.Data = new { Success = false, Message = "Unable to perform action on  Courses" };
            }

            return json;
        }
        ////new edited
        //[HttpPost]
        //public JsonResult Edited(EditCoursesModel model)
        //{
        //    var courses = repository.GetCoursesById(model.Id);

        //    courses.Id = model.Id;
        //    courses.Course_Name = model.Course_Name;
        //    courses.Course_Description = model.Course_Description;
        //    courses.School_Year = model.School_Year;

        //    repository.UpdateCourses(courses);

        //    return Json(new
        //    {
        //        message = "Updated Succesfully ",
        //        success = "true"
        //    });
        //}

        public ActionResult Details(int id)
        {
            var courses = repository.GetCoursesById(id);
            return View(courses);
        }



    
    }
}