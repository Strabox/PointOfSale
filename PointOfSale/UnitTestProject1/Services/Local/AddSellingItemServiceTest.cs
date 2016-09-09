using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
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
    public class AddSellingItemServiceTest : PointOfSaleServiceTest
    {

        private const string EXISTING_CATEGORY = "Bar";
        private const string INEXISTING_CATEGORY = "Gelados";
        private const string EXISTING_ITEM_NAME = "Whiskey";
        private const string INEXISTENT_ITEM_NAME = "Bebidas";
        private const int PRICE_EURO = 2;
        private const int PRICE_CENTS = 20;
        private Image ITEM_IMAGE = Properties.ResourceTests.image;


        [TestInitialize]
        public override void Populate()
        {
            AddCategory(EXISTING_CATEGORY);
            AddSellingItem(EXISTING_CATEGORY, EXISTING_ITEM_NAME, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE);
        }

        [TestMethod]
        public void AddSellingItemServiceSuccess()
        {
            AddSellingItemService service = new AddSellingItemService(INEXISTENT_ITEM_NAME, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE, EXISTING_CATEGORY);
            service.Execute();
            Assert.IsNotNull(GetSellingItem(INEXISTENT_ITEM_NAME));
            Assert.AreEqual(GetSellingItem(INEXISTENT_ITEM_NAME).Name, INEXISTENT_ITEM_NAME);
            Assert.AreEqual(GetSellingItem(INEXISTENT_ITEM_NAME).Price, new Euro(PRICE_EURO,PRICE_CENTS));
            Assert.AreEqual(GetSellingItem(INEXISTENT_ITEM_NAME).Image, ITEM_IMAGE);
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryDoesntExistException),
            "Category shouldnt exist", AllowDerivedTypes = false)]
        public void AddSellingItemServiceFailCategoryInexistent()
        {
            AddSellingItemService service = new AddSellingItemService(EXISTING_ITEM_NAME, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE, INEXISTING_CATEGORY);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(SellingItemAlreadyExistException),
            "Item should exist", AllowDerivedTypes = false)]
        public void AddSellingItemServiceFailItemExist()
        {
            AddSellingItemService service = new AddSellingItemService(EXISTING_ITEM_NAME, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE, EXISTING_CATEGORY);
            service.Execute();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null item name allowed", AllowDerivedTypes = false)]
        public void AddSellingItemServiceFailItemNull()
        {
            AddSellingItemService service = new AddSellingItemService(null, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE, INEXISTING_CATEGORY);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null image allowed", AllowDerivedTypes = false)]
        public void AddSellingItemServiceFailItemImageNull()
        {
            AddSellingItemService service = new AddSellingItemService(INEXISTENT_ITEM_NAME, PRICE_EURO, PRICE_CENTS, null, INEXISTING_CATEGORY);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null category allowed", AllowDerivedTypes = false)]
        public void AddSellingItemServiceFailCategoryNull()
        {
            AddSellingItemService service = new AddSellingItemService(INEXISTENT_ITEM_NAME, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE, null);
            service.Execute();
        }


    }
}
