using ex5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex5.Controllers
{
    public class ServiceController : Controller
    {
        private IService s1, s2;

        public ServiceController(IService s1, IService s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }

        // GET: Service
        public ActionResult Index()
        {
            ViewData["message"] = s1.GetValeurInstance() + " " + s2.GetValeurInstance();
            return View();
        }
    }
}