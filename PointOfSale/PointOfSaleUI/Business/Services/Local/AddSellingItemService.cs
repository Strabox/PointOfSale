using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Add an item to a category/selling items
    /// </summary>
    public class AddSellingItemService : PointOfSaleService
    {

        private string itemName;

        private int priceEuro;

        private int priceCents;

        private Image itemImage;

        private string category;


        public AddSellingItemService(string itemName,int priceEuro,
            int priceCents,Image itemImage,string category)
        {
            this.itemName = itemName;
            this.priceEuro = priceEuro;
            this.priceCents = priceCents;
            this.itemImage = itemImage;
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
            if(itemName == null || itemImage == null || category == null)
            {
                throw new ArgumentNullException();
            }
            SellingItems items = PointOfSaleRoot.GetInstance().CurrentProducts;
            SellableProduct item = new SellableProduct(itemName, new Euro(priceEuro, priceCents), itemImage);
            items.AddItemToCategory(category, item);
        }
    }
}
