using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Exceptions;
using PointOfSaleUI.Business.Services.Local;
using PointsOfSaleTests.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleTests.Services.Local
{
    [TestClass]
    public class AddCategoryServiceTest : PointOfSaleServiceTest
    {

        private const string INEXISTENT_CATEGORY = "Hot Beverages";
        private const string EXISTING_CATEGORY = "Cold Beverages";

        [TestInitialize]
        public override void Populate()
        {
            AddCategory(EXISTING_CATEGORY);
        }

        [TestMethod]
        public void AddCategoryServiceSuccess()
        {
            AddCategoryService service = new AddCategoryService(INEXISTENT_CATEGORY);
            service.Execute();
            Assert.IsTrue(SellingCategoryExists(INEXISTENT_CATEGORY));
        }

        [TestMethod]
        [ExpectedException(typeof(CategoryAlreadyExistException),
            "Category already exists", AllowDerivedTypes = false)]
        public void AddCategoryServiceFailExistinCategory()
        {
            AddCategoryService service = new AddCategoryService(EXISTING_CATEGORY);
            service.Execute();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Null category allowed", AllowDerivedTypes = false)]
        public void AddCategoryServiceFailNewCategoryNull()
        {
            AddCategoryService service = new AddCategoryService(null);
            service.Execute();
        }
    }
}
