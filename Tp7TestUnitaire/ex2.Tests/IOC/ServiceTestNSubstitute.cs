using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex2.IOC;
using NSubstitute;

namespace ex2.Tests.IOC
{
    [TestClass]
    public class ServiceTestNSubstitute
    {
        IService1 _stub;

        public ServiceTestNSubstitute()
        {
            _stub = Substitute.For<IService1>();
        }

        [TestMethod]
        public void claculeTestStub()
        {
            _stub.GetDonne(1).Returns(10);
            IService2 service2 = new Service2Impl(_stub);
            var result = service2.clacule(1, 3);
            Assert.AreEqual(result, 30);
        }

        [TestMethod]
        public void claculeTestMock()
        {
            _stub.GetDonne(1).Returns(10);
            IService2 service2 = new Service2Impl(_stub);
            var result = service2.clacule(1, 3);
            _stub.Received().GetDonne(1);
        }
    }
}
