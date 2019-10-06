using ex7.Context;
using ex7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ex7.Controllers
{
    public class EtudiantController : Controller
    {
        SampleContext sampleContext = new SampleContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chart()
        {
            var filieres = sampleContext.Filieres.ToList();
            var etudiants = sampleContext.Etudiants.ToList();
            List<String> xv = new List<String>();
            List<int> yv = new List<int>();
            foreach (Filiere filiere in filieres)
            {
                foreach (Etudiant etudiant in etudiants)
                {
                    if (etudiant.FiliereId == filiere.Id)
                    {
                        filiere.Etudiants.Add(etudiant);
                    }
                }
                xv.Add(filiere.Nom);
                yv.Add(filiere.Etudiants.Count());
            }
            new Chart(width: 800, height: 200).AddTitle("Nombre des etudiants par filiere")
                .AddSeries(chartType: "Column", xValue: xv, yValues: yv).Write("png");
            return null;
        }
    }
}