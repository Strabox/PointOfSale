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
    public class RemoveSellingItemServiceTest : PointOfSaleServiceTest
    {
        private const string EXISTING_CATEGORY = "Bar";
        private const string INEXISTING_CATEGORY = "Party";

        private const string EXISTING_ITEM = "Beer";
        private const int ITEM_PRICE_EURO = 1;
        private const int ITEM_PRICE_CENTS = 80;
        private Image ITEM_IMAGE = Properties.ResourceTests.image;

        [TestInitialize]
        public override void Populate()
        {
            AddCategory(EXISTING_CATEGORY);
            AddSellingItem(EXISTING_CATEGORY, EXISTING_ITEM, ITEM_PRICE_EURO, ITEM_PRICE_CENTS, ITEM_IMAGE);
        }

        [TestMethod]
        public void RemoveSellingItemServiceSuccess()
        {
            RemoveSellingItemService service = new RemoveSellingItemService(EXISTING_CATEGORY, EXISTING_ITEM);
            service.Execute();
            Assert.IsNull(GetSellingItem(EXISTING_ITEM));
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryDoesntExistException),
            "Category doesnt exist", AllowDerivedTypes = false)]
        public void RemoveSellingItemServiceFailInexistingCategory()
        {
            RemoveSellingItemService service = new RemoveSellingItemService(INEXISTING_CATEGORY, EXISTING_ITEM);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Category null allowed", AllowDerivedTypes = false)]
        public void RemoveSellingItemServiceFailCategoryNull()
        {
            RemoveSellingItemService service = new RemoveSellingItemService(null, EXISTING_ITEM);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Item null allowed", AllowDerivedTypes = false)]
        public void RemoveSellingItemServiceFailItemNull()
        {
            RemoveSellingItemService service = new RemoveSellingItemService(EXISTING_CATEGORY, null);
            service.Execute();
        }

    }
}
