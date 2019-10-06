using ex1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex1.Controllers
{
    public class EtudiantController : Controller
    {
        private DBEtudiantContext dBEtudiantContext = new DBEtudiantContext();

        // GET: Etudiant
        public ActionResult Page1()
        {
            ViewBag.etudiants = new SelectList(dBEtudiantContext.Etudiants, "cne", "nom");
            return View();
        }

        public ActionResult Page2(int? cne)
        {
            if (cne != null)
            {
                ViewBag.cne = cne;
                return View();
            }
            return RedirectToAction("Page1");
        }
    }
}