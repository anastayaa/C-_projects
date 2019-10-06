using ex1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex2.Controllers
{
    public class EtudiantController : Controller
    {
        private SampleContext sampleContext = new SampleContext();

        public ActionResult Page1()
        {
            ViewBag.filieres = new SelectList(sampleContext.Filieres, "id", "nom");
            return View();
        }

        public JsonResult GetEtudiantByFiliere(int id)
        {
            sampleContext.Configuration.ProxyCreationEnabled = false;
            return Json(sampleContext.Etudiants.Where(p => p.Filiere.Id == id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Page2(int?id, int? cne)
        {
            if (id!=null && cne != null)
            {
                ViewBag.id = id;
                ViewBag.cne = cne;
                return View();
            }
            return RedirectToAction("Page1");
        }
    }
}