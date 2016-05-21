using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsandoKnockout.Controllers
{
    public class FunciController : Controller
    {
        // GET: Funci
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Create()
        {
            return View("Create");
        }
    }
}