using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BibliotecaWeb;

namespace ResidentialWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Bem-Vindo ao Sistema Residential Life!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
