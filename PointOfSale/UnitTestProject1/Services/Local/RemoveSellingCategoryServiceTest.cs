using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Exceptions;
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
    public class RemoveSellingCategoryServiceTest : PointOfSaleServiceTest
    {

        private const string EXISTING_CATEGORY = "Bar";
        private const string INEXISTING_CATEGORY = "Party";

        [TestInitialize]
        public override void Populate()
        {
            AddCategory(EXISTING_CATEGORY);
        }

        [TestMethod]
        public void RemoveSellingCategoryServiceSuccess()
        {
            RemoveSellingCategoryService service = new RemoveSellingCategoryService(EXISTING_CATEGORY);
            service.Execute();
            Assert.IsFalse(SellingCategoryExists(EXISTING_CATEGORY));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null category allowed", AllowDerivedTypes = false)]
        public void RemoveSellingCategoryServiceFailNullCategory()
        {
            RemoveSellingCategoryService service = new RemoveSellingCategoryService(null);
            service.Execute();
        }

    }
}
