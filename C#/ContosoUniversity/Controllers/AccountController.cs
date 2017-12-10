using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;

using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Security;

namespace ContosoUniversity.Controllers

{
    public class AccountController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Department
        public ActionResult Index()
        {
            return View("Index");
        }

    }
}
