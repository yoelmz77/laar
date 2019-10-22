using LAAR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAAR.Controllers
{
    public class HomeController : Controller
    {
        LAARDBContext db = new LAARDBContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Data Base created";

            db.NoteTable.ToList();
            db.AssesmentTable.ToList();
            db.CompetencyCheckTable.ToList();

            return View();
        }
    }
}
