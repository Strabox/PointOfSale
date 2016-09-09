using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Services.Local;
using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;

namespace PointsOfSaleTests.Services.Local
{
    [TestClass]
    public class DoChangeServiceTest : PointOfSaleServiceTest
    {

        [TestMethod]
        public void DochangeServiceSuccess_1()
        {
            DoChangeService service = new DoChangeService(new Euro(2,50), new Euro(1, 50));
            service.Execute();
            Assert.AreEqual(service.GetChange(),new Euro(1,0));
        }

        [TestMethod]
        public void DochangeServiceSuccess_2()
        {
            DoChangeService service = new DoChangeService(new Euro(2, 50), new Euro(2, 50));
            service.Execute();
            Assert.AreEqual(service.GetChange(), new Euro(0, 0));
        }

        [TestMethod]
        public void DochangeServiceSuccess_3()
        {
            DoChangeService service = new DoChangeService(new Euro(0, 0), new Euro(0, 0));
            service.Execute();
            Assert.AreEqual(service.GetChange(), new Euro(0, 0));
        }

        [TestMethod]
        public void DochangeServiceSuccess_4()
        {
            DoChangeService service = new DoChangeService(new Euro(2, 50), new Euro(0, 60));
            service.Execute();
            Assert.AreEqual(service.GetChange(), new Euro(1, 90));
        }

        [TestMethod]
        public void DochangeServiceSuccess_5()
        {
            DoChangeService service = new DoChangeService(new Euro(2, 50), new Euro(0, 50));
            service.Execute();
            Assert.AreEqual(service.GetChange(), new Euro(2, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(InsuficcientPaymentException),
            "Change succeeded with price > payment", AllowDerivedTypes = false)]
        public void FailPriceGreaterThanPayment()
        {
            DoChangeService service = new DoChangeService(new Euro(2, 50), new Euro(4, 50));
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Negative payment was allowed", AllowDerivedTypes = false)]
        public void FailNullPayment()
        {
            DoChangeService service = new DoChangeService(null,new Euro(1, 50));
            service.Execute();
        }

        [ExpectedException(typeof(ArgumentNullException),
            "Negative price was allowed", AllowDerivedTypes = false)]
        [TestMethod]
        public void FailNullPrice()
        {
            DoChangeService service = new DoChangeService(new Euro(1, 50), null);
            service.Execute();
        }
    }
}
