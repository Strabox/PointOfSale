using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Services.Local;
using PointsOfSaleTests.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSaleUI.Business.Exceptions;
using PointOfSaleUI.Business.Domain;

namespace PointOfSaleTests.Services.Local
{
    [TestClass]
    public class AddProductToBasketServiceTest : PointOfSaleServiceTest
    {

        private const string EXISTING_CATEGORY = "Bar";
        private const string EXISTING_PRODUCT = "Beer";
        private const string NON_EXISTENT_PRODUCT = "Whiskey";

        private const int PRODUCT_EURO = 2;
        private const int PRODUCT_CENTS = 79;
        private Image PRODUCT_IMAGE = Properties.ResourceTests.image;

        [TestInitialize]
        public override void Populate()
        {
            AddCategory(EXISTING_CATEGORY);
            AddSellingItem(EXISTING_CATEGORY, EXISTING_PRODUCT, PRODUCT_EURO, PRODUCT_CENTS, PRODUCT_IMAGE);
        }

        [TestMethod]
        public void AddProductToBasketServiceSuccess1()
        {
            AddProductToBasketService service = new AddProductToBasketService(EXISTING_PRODUCT);
            service.Execute();
            SellableProduct product = GetBasketProduct(EXISTING_PRODUCT);
            Assert.IsNotNull(product);
            Assert.AreEqual(product.Name, EXISTING_PRODUCT);
            Assert.AreEqual(product.Price, new Euro(PRODUCT_EURO,PRODUCT_CENTS));
            Assert.AreEqual(GetBasketProductQuantity(EXISTING_PRODUCT), 1);
            Assert.AreEqual(GetBasketTotalPrice(), new Euro(PRODUCT_EURO, PRODUCT_CENTS));
        }

        [TestMethod]
        public void AddProductToBasketServiceSuccess2()
        {
            AddProductToBasketService service = new AddProductToBasketService(EXISTING_PRODUCT);
            service.Execute();
            service.Execute();
            Assert.AreEqual(GetBasketProductQuantity(EXISTING_PRODUCT), 2);
            Assert.AreEqual(GetBasketTotalPrice(), new Euro(PRODUCT_EURO, PRODUCT_CENTS) * 2);
        }

        [TestMethod]
        [ExpectedException(typeof(SellingItemDoesntExistException),
            "Non-existent product added to basket", AllowDerivedTypes = false)]
        public void AddProductToBasketServiceFailAddNonExistentProduct()
        {
            AddProductToBasketService service = new AddProductToBasketService(NON_EXISTENT_PRODUCT);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null item name allowed", AllowDerivedTypes = false)]
        public void AddProductToBasketServiceFailNullItem()
        {
            AddProductToBasketService service = new AddProductToBasketService(null);
            service.Execute();
        }

    }
}
