using ds.Contexts;
using ds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ds.Services
{
    public class EtudiantServiceImpl:IEtudiantService
    {
        SampleContext db = new SampleContext();

        public IEnumerable<Etudiant> Findll()
        {
            return db.Etudiants.ToList();
        }

        public void Add(Etudiant etudiant)
        {
            db.Etudiants.Add(etudiant);
            db.SaveChanges();
        }

        public IEnumerable<Etudiant> GetEtudiantsByFiliere(int id)
        {
            return db.Etudiants.Where(p => p.Filiere.Id == id);
        }

        public Etudiant GetEtudiantByCne(string cne)
        {
            Etudiant etudiant = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http:localhost:50155");
            HttpResponseMessage message = client.GetAsync("api/Filiere/GetEtudiantByCne").Result;
            etudiant = message.Content.ReadAsAsync(Etudiant).Result;
            return etudiant;
        }
    }
}