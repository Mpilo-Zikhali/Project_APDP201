using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical_Centre.proj.Controllers
{
    public class MedicalCentreController : Controller
    {
        // GET: MedicalCentre
        public ActionResult Index()
        {
            return View();
        }
    }
}