using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Domain;
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
    public class GetBasketTotalPriceServiceTest : PointOfSaleServiceTest
    {
        private const string PRODUCT_NAME_1 = "Beer";
        private const int PRODUCT_EURO_1 = 2;
        private const int PRODUCT_CENTS_1 = 80;
        private const string PRODUCT_NAME_2 = "Whiskey";
        private const int PRODUCT_EURO_2 = 1;
        private const int PRODUCT_CENTS_2 = 81;

        [TestMethod]
        public void GetBasketTotalPriceServiceNonEmpty()
        {
            AddProductToBasket(PRODUCT_NAME_1, PRODUCT_EURO_1, PRODUCT_CENTS_1);
            AddProductToBasket(PRODUCT_NAME_1, PRODUCT_EURO_1, PRODUCT_CENTS_1);
            AddProductToBasket(PRODUCT_NAME_2, PRODUCT_EURO_2, PRODUCT_CENTS_2);
            AddProductToBasket(PRODUCT_NAME_2, PRODUCT_EURO_2, PRODUCT_CENTS_2);
            GetBasketTotalPriceService service = new GetBasketTotalPriceService();
            service.Execute();
            Assert.AreEqual(service.GetTotalPrice(), new Euro(9, 22));
        }

        [TestMethod]
        public void GetBasketTotalPriceServiceEmpty()
        {
            GetBasketTotalPriceService service = new GetBasketTotalPriceService();
            service.Execute();
            Assert.AreEqual(service.GetTotalPrice(), new Euro(0, 0));
        }

    }
}
