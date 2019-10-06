using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ex6.Contexts;
using ex6.Models;

namespace ex6.Services
{
    public class IEtudiantServiceImpl : IEtudiantService
    {
        private SampleContext db = new SampleContext();

        public IEnumerable<Etudiant> findAll()
        {
            return db.Etudiants.ToList();
        }

        public Etudiant GetEtudiantByCne(string cne)
        {
            Etudiant etudiant = db.Etudiants.Find(cne);
            return etudiant;
        }

        public void Save(Etudiant etudiant)
        {
            db.Etudiants.Add(etudiant);
            db.SaveChanges();
        }
    }
}