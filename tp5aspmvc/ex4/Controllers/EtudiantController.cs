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
        SampleContext sampleContext = new SampleContext();

        // GET: Etudiant
        public ActionResult Index()
        {
            var filieres = sampleContext.Filieres.ToList();
            var etudiants=sampleContext.Etudiants.ToList();
            foreach(Filiere filiere in filieres)
            {
                foreach(Etudiant etudiant in etudiants)
                {
                    if (etudiant.FiliereId == filiere.Id)
                    {
                        etudiant.Filiere = filiere;
                    }
                }
            }
            return View(etudiants);
        }
    }
}