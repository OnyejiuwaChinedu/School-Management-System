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
    public class TransactionsController : Controller
    {
        // GET: Admin/Transactions
        private readonly ITransactionsRepository repository;
        public int PageSize = 10;

        public TransactionsController(ITransactionsRepository transactionsRepository)
        {
            this.repository = transactionsRepository;
        }
        public ActionResult Index()
        {
            TransactionsListViewModel model = new TransactionsListViewModel();

            model.Transactions = repository.GetAllTransactions();

            return View(model);
        }
        [HttpPost]
        public JsonResult AddTransactions(TransactionsViewModel model)
        {
            Transactions transactions = new Transactions();

            transactions.Id = model.Id;
            transactions.Transaction_Name = model.Transaction_Name;
            transactions.Student_Id = model.Student_Id;
            transactions.Transaction_Date = model.Transaction_Date;         

        repository.SaveTransactions(transactions);

            return Json(new
            {
                message = "Successfully added ",
                success = "true"
            });
        }

        [HttpPost]
        public JsonResult Deleted(int ID)
        {

            var transactions = repository.GetTransactionsById(ID);

            repository.DeleteTransactions(transactions);

            return Json(new
            {
                message = "Deleted Succesfully ",
                success = "true"
            });
        }

        //new edited
        [HttpPost]
        public JsonResult Edited(EditTransactionsModel model)
        {
            var transactions = repository.GetTransactionsById(model.Id);

            transactions.Id = model.Id;
            transactions.Transaction_Name = model.Transaction_Name;
            transactions.Student_Id = model.Student_Id;
            transactions.Transaction_Date = model.Transaction_Date;

            repository.UpdateTransactions(transactions);

            return Json(new
            {
                message = "Updated Succesfully ",
                success = "true"
            });
        }

        public ActionResult Details(int id)
        {
            var transactions = repository.GetTransactionsById(id);
            return View(transactions);
        }
    }
}