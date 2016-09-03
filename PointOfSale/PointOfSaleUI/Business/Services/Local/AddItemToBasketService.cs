using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Service add an item to the basket cart
    /// </summary>
    public class AddItemToBasketService : PointOfSaleService
    {

        private string itemName;

        public AddItemToBasketService(string iname)
        {
            itemName = iname;
        }

        protected override void Dispatch()
        {
            BasketCart basket = DomainRoot.BasketCart;
            SellingItems items = DomainRoot.SellingItems;
            SellableItem item = items.GetItem(itemName);
            basket.AddItemToBasket(new SellableItem(item.Name,new Euro(item.Price.IntegerPart,item.Price.DecimalPart)));
        }
    }
}
