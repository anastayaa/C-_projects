using ds.Models;
using ds.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ds.Controllers
{
    public class FiliereController : Controller
    {
        private IEtudiantService etudiantService;
        private IFiliereService filiereService;

        public FiliereController()
        {

        }
        public FiliereController(IEtudiantService etudiantService, IFiliereService filiereService)
        {
            this.etudiantService = etudiantService;
            this.filiereService = filiereService;
        }

        // GET: Filiere
        public ActionResult Index()
        {
            ViewBag.FiliereId = new SelectList(filiereService.Findll(), "Id", "Nom");
            return View();
        }

        public JsonResult GetEtudiantByFiliere(int id)
        {
            return Json(etudiantService.GetEtudiantsByFiliere(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEtudiantById(String cne)
        {
            if (cne != null)
            {
                Etudiant etudiant = etudiantService.GetEtudiantByCne(cne);
                return View(etudiant);
            }
            return RedirectToAction("Page1");
        }
    }
}