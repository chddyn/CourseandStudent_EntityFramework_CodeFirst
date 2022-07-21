using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CourseandStudentt.Models.Classes;

namespace CourseandStudentt.Controllers
{
    public class HomeController : Controller
    {
     
        public ActionResult Index()
        {

            Context c = new Context();

            var degerler = c.Students.ToList();

            return View(degerler);
        }

    }
}