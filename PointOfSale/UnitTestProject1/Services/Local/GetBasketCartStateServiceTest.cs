using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Services.Local;
using PointsOfSaleTests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTests.Services.Local
{
    [TestClass]
    public class GetBasketCartStateServiceTest : PointOfSaleServiceTest
    {
        private const string PRODUCT_NAME = "Beer";
        private const int PRODUCT_EURO = 3;
        private const int PRODUCT_CENTS = 50;

        [TestMethod]
        public void GetBasketCartStateServiceSuccessEmpty()
        {
            AddProductToBasket(PRODUCT_NAME, PRODUCT_EURO, PRODUCT_CENTS);
            AddProductToBasket(PRODUCT_NAME, PRODUCT_EURO, PRODUCT_CENTS);
            GetBasketCartStateService service = new GetBasketCartStateService();
            service.Execute();
            Assert.IsFalse(service.BasketIsEmpty());
        }

        [TestMethod]
        public void GetBasketCartStateServiceSuccessNotEmpty()
        {
            GetBasketCartStateService service = new GetBasketCartStateService();
            service.Execute();
            Assert.IsTrue(service.BasketIsEmpty());
        }

    }
}
