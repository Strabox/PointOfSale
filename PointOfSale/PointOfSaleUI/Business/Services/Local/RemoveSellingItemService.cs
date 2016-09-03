using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Remove a item from a category/selling items.
    ///     Exceptions: CategoryDoenstExistException
    /// </summary>
    public class RemoveSellingItemService : PointOfSaleService
    {

        private string category;

        private string item;


        public RemoveSellingItemService(string category,string item)
        {
            this.category = category;
            this.item = item;
        }

        protected override void Dispatch()
        {
            SellingItems items = DomainRoot.SellingItems;
            items.RemoveItemFromCategory(category, item);
        }
    }
}
