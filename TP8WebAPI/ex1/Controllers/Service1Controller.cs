using ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ex2Client.Controllers
{
    public class Service1Controller : ApiController
    {

        private List<Etudiant> etudiants = new List<Etudiant>();

        [Route("api/Service1/etudiant/all")]
        public IEnumerable<Etudiant> GetEtudiant()
        {
            return etudiants;
        }

        [Route("api/Service1/etudiant/id")]
        public IHttpActionResult GetEtudiant(int id)
        {
            if (id < etudiants.Count)
            {
                Etudiant etudiant = etudiants[id];
                if (etudiant == null)
                {
                    return NotFound();
                }
                return Ok(etudiant);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/Service1/etudiant/add")]
        public IHttpActionResult PostEtudiant(Etudiant etudiant)
        {
            etudiants.Add(etudiant);
            return Ok(etudiant);
        }

    }
}
