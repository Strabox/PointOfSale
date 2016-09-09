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
    ///     Remove a selling category from the selling items.
    /// </summary>
    public class RemoveSellingCategoryService : PointOfSaleService
    {

        private string category;

        public RemoveSellingCategoryService(string category)
        {
            this.category = category;
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
            if(category == null)
            {
                throw new ArgumentNullException();
            }
            SellingItems items = PointOfSaleRoot.GetInstance().CurrentProducts;
            items.RemoveCategory(category);
        }
    }
}
