using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class AddItemToBasketService : PointOfSaleService
    {

        private BasketCart basket;

        private SellableItem item;


        public AddItemToBasketService(BasketCart b,SellableItem i)
        {
            basket = b;
            item = i;
        }

        protected override void Dispatch()
        {
            basket.AddItemToBasket(item);
        }
    }
}
