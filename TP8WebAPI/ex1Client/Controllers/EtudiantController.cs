using ex2Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ex1Client.Controllers
{
    public class EtudiantController : Controller
    {
        // GET: Etudiant
        public JsonResult Index()
        {
            IEnumerable<Etudiant> etudiants;
            HttpClient client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri("http://localhost:55639");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage message = client.GetAsync("api/Etudiant/").Result;
            etudiants = message.Content.ReadAsAsync<IEnumerable<Etudiant>>().Result;
            return Json(etudiants, JsonRequestBehavior.AllowGet);
        }
    }
}