using ex7.Context;
using ex7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex7.Controllers
{
    public class EtudiantController : Controller
    {
        private SampleContext db=new SampleContext();
        // GET: Etudiant
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Create()
        {
            String cne = Request.Form["Cne"];
            String nom = Request.Form["Nom"];
            Etudiant etudiant = new Etudiant();
            Filiere filiere = db.Filieres.Find(1);
            etudiant.Cne = cne;
            etudiant.Nom = nom;
            etudiant.Filiere = filiere;
            db.Etudiants.Add(etudiant);
            db.SaveChanges();
            return PartialView("_Form", etudiant);
        }
    }
}