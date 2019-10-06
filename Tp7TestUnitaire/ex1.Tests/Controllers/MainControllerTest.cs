using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ex1.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ex1.Tests.Controllers
{
    [TestClass]
    public class MainControllerTest
    {
        MainController main = new MainController();

        [TestMethod]
        public void Somme()
        {
            int somme = main.Somme(10, 10);
            Assert.AreEqual(20, somme);
        }

        [TestMethod]
        public void SommeCollection()
        {
            List<int> l1 = new List<int> { 1, 2, 3 };
            List<int> l2 = new List<int> { 1, 2, 3 };
            List<int> somList = main.SommeCollection(l1, l2);
            CollectionAssert.AllItemsAreInstancesOfType(somList, typeof(int));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Error")]
        public void devide()
        {
            int result = main.devide(1, 0);
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void GetView0()
        {
            ViewResult view = main.GetView(0) as ViewResult;
            Assert.AreEqual("view0", view.ViewName);
        }

        [TestMethod]
        public void GetViewOthers()
        {
            ViewResult view = main.GetView(1) as ViewResult;
            Assert.AreEqual("view1", view.ViewName);
        }

        [TestMethod]
        public void action2()
        {
            ViewResult view = main.action2() as ViewResult;
            Assert.AreEqual("DURANT", view.ViewData["Name"]);
        }

        [TestMethod]
        public void DetailsForRedirect()
        {
            var result = main.Details(-1) as RedirectToRouteResult;
            Assert.AreEqual("action2", result.RouteValues["Action"]);
            Assert.AreEqual("MainController", result.RouteValues["Controller"]);
        }

        [TestMethod]
        public void DetailsForResultView()
        {
            ViewResult view = main.Details(2) as ViewResult;
            Assert.AreEqual("Details", view.ViewName);
        }
    }
}
