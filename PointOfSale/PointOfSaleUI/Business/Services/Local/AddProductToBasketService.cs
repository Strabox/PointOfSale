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
    ///     Service add a product to the basket cart
    /// </summary>
    public class AddProductToBasketService : PointOfSaleService
    {

        private string productName;

        private int quantity;

        public AddProductToBasketService(string productName, int quantity)
        {
            this.productName = productName;
            this.quantity = quantity;
        }

        protected sealed override void AccessControl()
        {
            PointOfSaleRoot root = PointOfSaleRoot.GetInstance();
            User user = root.LoggedInUser;
            if (root.LoggedInUser == null)
            {
                throw new NoAuthorizationException();
            }
        }

        protected sealed override void Dispatch()
        {
            if(productName == null)
            {
                throw new ArgumentNullException();
            }
            BasketCart basket = PointOfSaleRoot.GetInstance().BasketCart;
            SellingItems products = PointOfSaleRoot.GetInstance().CurrentProducts;
            SellableProduct product = products.GetItem(productName);
            for(int i = 0; i < quantity; i++)
            {
                basket.AddItemToBasket(new SellableProduct(product.Name, new Euro(product.Price.IntegerPart, product.Price.DecimalPart)));
            }
        }
    }
}
