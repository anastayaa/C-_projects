using dsapi.Contexts;
using dsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dsapi.Controllers
{
    public class FiliereController : ApiController
    {
        SampleContext db = new SampleContext();

        [Route("api/Filiere/GetEtudiantByCne")]
        public IHttpActionResult GetEtudiantByCne(int cne)
        {
            Etudiant etudiant = db.Etudiants.Find(cne);
            if (etudiant == null)
            {
                return NotFound();
            }
            return Ok(etudiant);
        }
    }
}
