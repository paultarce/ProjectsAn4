using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtelierAuto.Controllers
{
    public class PlasareComandaControler : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        // GET: PlasareComandaControler
        [HttpPost]
        public ActionResult PlasareComanda()
        {
            return RedirectToAction("AfisareComandaPlasata","User");
        }
    }
}