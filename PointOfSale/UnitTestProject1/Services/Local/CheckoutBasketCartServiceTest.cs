using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Services.Local;
using PointsOfSaleTests.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTests.Services.Local
{
    [TestClass]
    public class CheckoutBasketCartServiceTest : PointOfSaleServiceTest
    {
        private const string EXISTING_CATEGORY = "Bar";
        private const string EXISTING_PRODUCT_1 = "Beer";
        private const string EXISTING_PRODUCT_2 = "Whiskey";

        private const int PRODUCT_EURO = 3;
        private const int PRODUCT_CENTS = 90;
        private Image PRODUCT_IMAGE = Properties.ResourceTests.image;

        [TestInitialize]
        public override void Populate()
        {
            AddCategory(EXISTING_CATEGORY);
            AddSellingItem(EXISTING_CATEGORY, EXISTING_PRODUCT_1, PRODUCT_EURO, PRODUCT_CENTS, PRODUCT_IMAGE);
            AddSellingItem(EXISTING_CATEGORY, EXISTING_PRODUCT_2, PRODUCT_EURO, PRODUCT_CENTS, PRODUCT_IMAGE);
            AddProductToBasket(EXISTING_PRODUCT_1, PRODUCT_EURO, PRODUCT_CENTS);
            AddProductToBasket(EXISTING_PRODUCT_1, PRODUCT_EURO, PRODUCT_CENTS);
            AddProductToBasket(EXISTING_PRODUCT_2, PRODUCT_EURO, PRODUCT_CENTS);
        }

        [TestMethod]
        public void CheckoutBasketCartServiceSuccess()
        {
            Assert.IsFalse(IsBasketEmpty());
            CheckoutBasketCartService service = new CheckoutBasketCartService();
            service.Execute();
            Assert.IsTrue(IsBasketEmpty());
            Assert.AreEqual(GetStatisticProductQuantity(EXISTING_PRODUCT_1), 2);
            Assert.AreEqual(GetStatisticProductQuantity(EXISTING_PRODUCT_2), 1);
            Assert.AreEqual(GetStatisticTotalValue(), new Euro(PRODUCT_EURO, PRODUCT_CENTS) * 3);
        }

    }
}
