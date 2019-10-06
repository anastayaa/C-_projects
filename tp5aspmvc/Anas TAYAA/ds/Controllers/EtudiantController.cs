using ds.Models;
using ds.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ds.Controllers
{
    public class EtudiantController : Controller
    {
        private IEtudiantService etudiantService;
        private IFiliereService filiereService;

        public EtudiantController()
        {

        }
        public EtudiantController(IEtudiantService etudiantService, IFiliereService filiereService)
        {
            this.etudiantService = etudiantService;
            this.filiereService = filiereService;
        }

        // GET: Etudiant
        public ActionResult Index()
        {
            return View(etudiantService.Findll());
        }

        public ActionResult Create()
        {
            ViewBag.FiliereId = new SelectList(filiereService.Findll(), "Id", "Nom");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cne,Nom,Prenom,FiliereId")] Etudiant etudiant)
        {
            if (ModelState.IsValid)
            {
                etudiantService.Add(etudiant);
                return RedirectToAction("Index");
            }

            ViewBag.FiliereId = new SelectList(filiereService.Findll(), "Id", "Nom", etudiant.FiliereId);
            return View(etudiant);
        }

    }
}