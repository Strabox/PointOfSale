using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTests.Unit
{
    [TestClass]
    public class EuroTest
    {

        public void CreationSuccess_1()
        {
            Euro euro = new Euro(0, 0);
            Assert.AreEqual(euro.IntegerPart, 0);
            Assert.AreEqual(euro.DecimalPart, 0);
        }

        public void CreationSuccess_2()
        {
            Euro euro = new Euro(0, 99);
            Assert.AreEqual(euro.IntegerPart, 0);
            Assert.AreEqual(euro.DecimalPart, 99);
        }

        public void CreationSuccess_3()
        {
            Euro euro = new Euro(1, 0);
            Assert.AreEqual(euro.IntegerPart, 1);
            Assert.AreEqual(euro.DecimalPart, 0);
        }

        /* ======================== Setters ======================= */

        [TestMethod]
        [ExpectedException(typeof(InvalidParameterMoneyException),
            "Negative euros were allowed",AllowDerivedTypes = false)]
        public void SetIntegerPartNegativeTest()
        {
            Euro euro = new Euro(-1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidParameterMoneyException),
            "Negative euros were allowed", AllowDerivedTypes = false)]
        public void SetDecimalPartNegativeTest_1()
        {
            Euro euro = new Euro(0, -10);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidParameterMoneyException),
            "More than 100 cents were allowed", AllowDerivedTypes = false)]
        public void SetDecimalPartMoreThan100Test_2()
        {
            Euro euro = new Euro(0, 100);
        }

        /* ========================= Add Test ========================== */

        [TestMethod]
        public void AddSuccessTest_1()
        {
            Euro euro = new Euro(0, 10);
            euro.Add(new Euro(1, 0));
            Assert.AreEqual(euro.IntegerPart, 1);
            Assert.AreEqual(euro.DecimalPart, 10);
        }

        [TestMethod]
        public void AddSuccessTest_2()
        {
            Euro euro = new Euro(3, 10);
            euro.Add(new Euro(4, 99));
            Assert.AreEqual(euro.IntegerPart, 8);
            Assert.AreEqual(euro.DecimalPart, 9);
        }

        /* ===================== Subtraction Test ======================= */

        [TestMethod]
        public void SubtractionSuccessTest_1()
        {
            Euro euro = new Euro(1, 10);
            euro.Subtract(new Euro(0, 10));
            Assert.AreEqual(euro.IntegerPart, 1);
            Assert.AreEqual(euro.DecimalPart, 0);
        }

        [TestMethod]
        public void SubtractionSuccessTest_2()
        {
            Euro euro = new Euro(1, 10);
            euro.Subtract(new Euro(1, 10));
            Assert.AreEqual(euro.IntegerPart, 0);
            Assert.AreEqual(euro.DecimalPart, 0);
        }

        [TestMethod]
        public void SubtractionSuccessTest_3()
        {
            Euro euro = new Euro(7, 40);
            euro.Subtract(new Euro(2, 60));
            Assert.AreEqual(euro.IntegerPart, 4);
            Assert.AreEqual(euro.DecimalPart, 80);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeEuroResultException),
            "Negative result allowed", AllowDerivedTypes = false)]
        public void SubtractionFailureTest_1()
        {
            Euro euro = new Euro(7, 40);
            euro.Subtract(new Euro(10, 60));
        }
        [TestMethod]
        [ExpectedException(typeof(NegativeEuroResultException),
            "Negative result allowed", AllowDerivedTypes = false)]
        public void SubtractionFailureTest_2()
        {
            Euro euro = new Euro(8, 40);
            euro.Subtract(new Euro(8, 41));
        }

        /* ======================= Multiply Test ======================== */

        [TestMethod]
        public void MultiplySuccessTest_1()
        {
            Euro euro = new Euro(0, 10);
            euro.Multiply(2);
            Assert.AreEqual(euro.IntegerPart, 0);
            Assert.AreEqual(euro.DecimalPart, 20);
        }

        [TestMethod]
        public void MultiplySuccessTest_2()
        {
            Euro euro = new Euro(1, 10);
            euro.Multiply(6);
            Assert.AreEqual(euro.IntegerPart, 6);
            Assert.AreEqual(euro.DecimalPart, 60);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Negative multiplier were allowed", AllowDerivedTypes = false)]
        public void MultiplyTestNegativeMultiplier()
        {
            Euro euro = new Euro(1, 10);
            euro.Multiply(-3);
        }

        /* ======================= ToString Test ======================== */

        [TestMethod]
        public void ToStringTest_1()
        {
            Euro euro = new Euro(1, 50);
            Assert.AreEqual(euro.ToString(), "1,50 " + Euro.GetSymbol());
        }

        [TestMethod]
        public void ToStringTest_2()
        {
            Euro euro = new Euro(0, 0);
            Assert.AreEqual(euro.ToString(), "0,0 " + Euro.GetSymbol());
        }

        [TestMethod]
        public void ToStringTest_3()
        {
            Euro euro = new Euro(0, 99);
            Assert.AreEqual(euro.ToString(), "0,99 " + Euro.GetSymbol());
        }

    }
}
