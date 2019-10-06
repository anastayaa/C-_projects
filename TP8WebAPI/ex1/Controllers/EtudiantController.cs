using ex1.Contexts;
using ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ex2Client.Controllers
{
    public class EtudiantController : ApiController
    {
        SampleContext db = new SampleContext();

        [Route("api/Etudiant")]
        public IEnumerable<Etudiant> GetEtudiants()
        {
            return db.Etudiants.ToList();
        }

        [Route("api/Etudiant/cne")]
        public IHttpActionResult GetEtudiantByCne(string cne)
        {
            Etudiant etudiant = db.Etudiants.Find(cne);
            return Ok(etudiant);
        }

        [Route("api/Etudiant/add")]
        public HttpResponseMessage PostEtudiant(Etudiant etudiant)
        {
            db.Etudiants.Add(etudiant);
            db.SaveChanges();
            return Request.CreateErrorResponse(HttpStatusCode.OK, etudiant.ToString());
        }

        [Route("api/Etudiant/put")]
        public HttpResponseMessage PutEtudiant(String cne, Etudiant etudiant)
        {
            Etudiant e = db.Etudiants.Find(cne);
            if (e == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "erreur");
            }
            return Request.CreateResponse(HttpStatusCode.OK, etudiant);
        }

        [Route("api/Etudiant/delete")]
        public IHttpActionResult DeleteEtudiant(string cne)
        {
            db.Etudiants.Remove(db.Etudiants.Find(cne));
            db.SaveChanges();
            return Ok(cne);
        }
    }
}
