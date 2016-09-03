using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Remove a selling category from the selling items.
    /// </summary>
    public class RemoveSellingCategoryService : PointOfSaleService
    {

        private string category;

        public RemoveSellingCategoryService(string category)
        {
            this.category = category;
        }

        protected override void Dispatch()
        {
            SellingItems items = DomainRoot.SellingItems;
            items.RemoveCategory(category);
        }
    }
}
