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
    public class ChangeSellingItemInformationServiceTest : PointOfSaleServiceTest
    {

        private const string EXISTING_CATEGORY = "Bar";
        private const string INEXISTING_CATEGORY = "Festas";
        private const string EXISTING_ITEM = "Whiskey";
        private const string INEXISTING_ITEM = "Sagres";
        private const int PRICE_EURO = 2;
        private const int PRICE_CENTS = 50;
        private Image ITEM_IMAGE = Properties.ResourceTests.image;

        private const int NEW_EURO = 3;
        private const int NEW_CENTS = 70;
        private Image NEW_IMAGE = Properties.ResourceTests.image2;

        [TestInitialize]
        public override void Populate()
        {
            AddCategory(EXISTING_CATEGORY);
            AddSellingItem(EXISTING_CATEGORY, EXISTING_ITEM, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE);
        }

        [TestMethod]
        public void ChangeSellingItemInformationSuccessDifferentNewName()
        {
            ChangeSellingItemInformationService service;
            service = new ChangeSellingItemInformationService(EXISTING_ITEM, EXISTING_CATEGORY, INEXISTING_ITEM, NEW_EURO, NEW_CENTS, NEW_IMAGE);
            service.Execute();
            Assert.IsNull(GetSellingItem(EXISTING_ITEM));
            Assert.IsNotNull(GetSellingItem(INEXISTING_ITEM));
            Assert.AreEqual(GetSellingItem(INEXISTING_ITEM).Name, INEXISTING_ITEM);
            Assert.AreEqual(GetSellingItem(INEXISTING_ITEM).Price, new Euro(NEW_EURO, NEW_CENTS));
            Assert.AreEqual(GetSellingItem(INEXISTING_ITEM).Image, NEW_IMAGE);
        }

        [TestMethod]
        public void ChangeSellingItemInformationSuccessSameNewName()
        {
            ChangeSellingItemInformationService service;
            service = new ChangeSellingItemInformationService(EXISTING_ITEM, EXISTING_CATEGORY, EXISTING_ITEM, NEW_EURO, NEW_CENTS, NEW_IMAGE);
            service.Execute();
            Assert.IsNotNull(GetSellingItem(EXISTING_ITEM));
            Assert.AreEqual(GetSellingItem(EXISTING_ITEM).Name, EXISTING_ITEM);
            Assert.AreEqual(GetSellingItem(EXISTING_ITEM).Price, new Euro(NEW_EURO, NEW_CENTS));
            Assert.AreEqual(GetSellingItem(EXISTING_ITEM).Image, NEW_IMAGE);
        }

        [TestMethod]
        [ExpectedException(typeof(SellingItemDoesntExistException),
            "Change info in a inexistent item", AllowDerivedTypes = false)]
        public void ChangeSellingItemInformationFailInexistentItem()
        {
            ChangeSellingItemInformationService service;
            service = new ChangeSellingItemInformationService(INEXISTING_ITEM, EXISTING_CATEGORY, INEXISTING_ITEM, NEW_EURO, NEW_CENTS, ITEM_IMAGE);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null item name allowed", AllowDerivedTypes = false)]
        public void ChangeSellingItemInformationFailItemNameNull()
        {
            ChangeSellingItemInformationService service;
            service = new ChangeSellingItemInformationService(null, EXISTING_CATEGORY, INEXISTING_ITEM, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null category allowed", AllowDerivedTypes = false)]
        public void ChangeSellingItemInformationCategoryNull()
        {
            ChangeSellingItemInformationService service;
            service = new ChangeSellingItemInformationService(INEXISTING_ITEM, null, INEXISTING_ITEM, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null item new name allowed", AllowDerivedTypes = false)]
        public void ChangeSellingItemInformationItemNewNameNull()
        {
            ChangeSellingItemInformationService service;
            service = new ChangeSellingItemInformationService(EXISTING_ITEM, EXISTING_CATEGORY, null, PRICE_EURO, PRICE_CENTS, ITEM_IMAGE);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null item image allowed", AllowDerivedTypes = false)]
        public void ChangeSellingItemInformationItemNewImageNull()
        {
            ChangeSellingItemInformationService service;
            service = new ChangeSellingItemInformationService(EXISTING_ITEM, EXISTING_CATEGORY, EXISTING_ITEM, PRICE_EURO, PRICE_CENTS, null);
            service.Execute();
        }

    }
}
