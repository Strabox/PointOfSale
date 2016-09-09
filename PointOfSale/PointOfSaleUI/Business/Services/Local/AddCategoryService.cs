using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class AddCategoryService : PointOfSaleService
    {

        private string newCategory;

        public AddCategoryService(string newCategory)
        {
            this.newCategory = newCategory;
        }

        protected sealed override void AccessControl()
        {
            PointOfSaleRoot root = PointOfSaleRoot.GetInstance();
            User user = root.LoggedInUser;
            if(root.LoggedInUser == null || (user.Role != UserRole.ADMIN))
            {
                throw new NoAuthorizationException();
            }
        }

        protected sealed override void Dispatch()
        {
            if(newCategory == null)
            {
                throw new ArgumentNullException();
            }
            SellingItems items = PointOfSaleRoot.GetInstance().CurrentProducts;
            items.AddCategory(newCategory);
        }
    }
}
