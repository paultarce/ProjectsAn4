using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtelierAuto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

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

        public ActionResult ManipulareComenzi()
        {

            ViewBag.Message = "Ce doriti sa faceti?";

            return View();
        }
        
        public ActionResult AfisareComandaPlasata()
        {

            ViewBag.Message = "Comanda plasata:";
            return View();
        }
    }
}