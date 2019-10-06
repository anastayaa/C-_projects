using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex2.IOC;

namespace ex2.Tests.IOC
{
    /// <summary>
    /// Description résumée pour ServiceTest
    /// </summary>
    [TestClass]
    public class ServiceTest
    {

        [TestMethod]
        public void claculeTestStub()
        {
            Stub stub = new Stub();
            IService2 service2 = new Service2Impl(stub);
            var result = service2.clacule(1, 3);
            Assert.AreEqual(result, 30);
        }

        [TestMethod]
        public void claculeTestMock()
        {
            Mock mock = new Mock();
            IService2 service2 = new Service2Impl(mock);
            var result = service2.clacule(1, 3);
            Assert.IsTrue(mock.isCalled);
        }
    }
}
