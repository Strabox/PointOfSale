using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
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

        protected sealed override void AccessControl()
        {
            PointOfSaleRoot root = PointOfSaleRoot.GetInstance();
            User user = root.LoggedInUser;
            if (root.LoggedInUser == null || (user.Role != UserRole.ADMIN))
            {
                throw new NoAuthorizationException();
            }
        }

        protected sealed override void Dispatch()
        {
            if(category == null || item == null)
            {
                throw new ArgumentNullException();
            }
            SellingItems items = PointOfSaleRoot.GetInstance().CurrentProducts;
            items.RemoveItemFromCategory(category, item);
        }
    }
}
