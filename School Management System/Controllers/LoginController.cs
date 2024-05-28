
using System.Web.Mvc;
using School_Management_System.Models;

namespace School_Management_System.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateLogin()
        {
           

            return View();
        }
        [HttpPost]
        public ActionResult CreateLogin(User u)
        {

            

            return View();
        }
        public ActionResult CreateLogin1()
        {


            return View();
        }
        [HttpPost]
        public ActionResult CreateLogin1(User user)
        {



            return View();
        }
    }
}