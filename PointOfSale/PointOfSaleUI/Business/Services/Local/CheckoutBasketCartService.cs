using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using PointOfSaleUI.Business.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Service that checkout the cart service when the client pays for the products content
    /// </summary>
    public class CheckoutBasketCartService : PointOfSaleService
    {
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
            BasketCart basket = PointOfSaleRoot.GetInstance().BasketCart;
            SellingStatistic statisticData = PointOfSaleRoot.GetInstance().SellingStatistic;

            List<KeyValuePair<SellableProduct, int>> basketItems = basket.GetAllItems();
            foreach(KeyValuePair<SellableProduct,int> entry in basketItems)
            {
                statisticData.AddProduct(entry.Key, entry.Value);
            }

            PersistenceManager.PersistObjectToBinaryFile(PersistenceManager.PERSISTENT_DATA_FILE, statisticData);

            basket.ClearBasketCart();   //Clear basket cart
        }
    }
}
