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
    public class ClearStatisticDataServiceTest : PointOfSaleServiceTest
    {

        private const string EXISTING_PRODUCT_1 = "Beer";
        private const string EXISTING_PRODUCT_2 = "Whiskey";

        [TestInitialize]
        public override void Populate()
        {
            AddStatisticProduct(EXISTING_PRODUCT_1,4);
            AddStatisticProduct(EXISTING_PRODUCT_1,9);
        }

        [TestMethod]
        public void ClearStatisticDataServiceSuccess()
        {
            ClearStatisticDataService service = new ClearStatisticDataService();
            service.Execute();
            Assert.AreEqual(GetStatisticProductQuantity(EXISTING_PRODUCT_1), 0);
            Assert.AreEqual(GetStatisticProductQuantity(EXISTING_PRODUCT_2), 0);
            Assert.AreEqual(GetStatisticTotalValue(), new Euro(0, 0));
        }

    }
}
