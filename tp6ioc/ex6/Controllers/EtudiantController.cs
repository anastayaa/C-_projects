using ex6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex6.Controllers
{
    public class EtudiantController : Controller
    {
        IEtudiantService etudiantService;

        public EtudiantController()
        {

        }

        public EtudiantController(IEtudiantService etudiantService)
        {
            this.etudiantService = etudiantService;
        }

        // GET: Etudiant
        public JsonResult Index()
        {
            return Json(etudiantService.findAll(), JsonRequestBehavior.AllowGet);
        }
    }
}