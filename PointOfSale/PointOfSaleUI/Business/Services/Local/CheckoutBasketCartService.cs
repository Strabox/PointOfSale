using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Service that checkout the cart service when the client pays for the content
    /// </summary>
    public class CheckoutBasketCartService : PointOfSaleService
    {

        protected override void Dispatch()
        {
            BasketCart basket = DomainRoot.BasketCart;
            SellingStatistic statisticData = DomainRoot.SellingStatistic;

            List<KeyValuePair<SellableItem, int>> basketItems = basket.GetAllItems();
            foreach(KeyValuePair<SellableItem,int> entry in basketItems)
            {
                statisticData.AddItem(entry.Key, entry.Value);
            }

            PersistenceManager.PersistObjectToBinaryFile(PersistenceManager.PERSISTENT_DATA_FILE, statisticData);

            basket.ClearBasketCart();   //Clear basket cart
        }
    }
}
