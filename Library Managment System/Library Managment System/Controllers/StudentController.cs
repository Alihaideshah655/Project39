using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_Managment_System.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult AddStudent()
        {

            return View();
        }
        public ActionResult ListStudents()
        {

            return View();
        }
    }
}