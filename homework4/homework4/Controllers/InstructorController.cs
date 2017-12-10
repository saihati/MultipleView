using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using homework4.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using homework4.DAL;
using homework4.Models;
using System.Data.Entity.Infrastructure;
namespace homework4.Controllers
{
    public class InstructorController : Controller
    {


        private SchoolContext db = new SchoolContext();
        //     public ActionResult Index()
        //   {
        //     return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ViewResult Index()
        {
            return View(db.Instructors.ToList());
        }
    }
}