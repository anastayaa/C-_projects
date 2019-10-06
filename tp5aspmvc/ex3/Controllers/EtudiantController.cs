using ex7.Context;
using ex7.Models;
using System.Linq;
using System.Web.Mvc;

namespace ex7.Controllers
{
    public class EtudiantController : Controller
    {
        private SampleContext sampleContext = new SampleContext();

        // GET: Etudiant
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEtudiant(string cne)
        {
            return Json(sampleContext.Etudiants.Where(e => e.Cne == cne), JsonRequestBehavior.AllowGet);
        }
    }
}