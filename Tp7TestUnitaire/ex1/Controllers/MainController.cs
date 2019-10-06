using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex1.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public int Somme(int a, int b)
        {
            return a + b;
        }

        public List<int> SommeCollection(List<int> l1, List<int> l2)
        {
            List<int> somList = new List<int>();
            if (l1.Count == l2.Count)
            {
                for (int i = 0; i < l1.Count; i++)
                {
                    somList.Add(l1[i] + l2[i]);
                }
                return somList;
            }
            return null;
        }

        public int devide(int a, int b)
        {
            return a / b;
        }

        public ActionResult GetView(int id)
        {
            if (id == 0)
            {
                return View("view0");
            }
            else
            {
                return View("view1");
            }
        }

        public ActionResult action2()
        {
            ViewData["Name"] = "DURANT";
            return View();
        }

        public ActionResult Details(int id)
        {
            if (id < 1)
            {
                return RedirectToAction("action2", "MainController");
            }
            return View("Details");
        }
    }
}