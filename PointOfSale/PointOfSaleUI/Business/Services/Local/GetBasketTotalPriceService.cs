using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class GetBasketTotalPriceService : PointOfSaleService
    {
        private Euro totalPrice;

        private BasketCart basket;

        public GetBasketTotalPriceService(BasketCart b)
        {
            basket = b;
        }

        protected sealed override void Dispatch()
        {
            totalPrice = new Euro(basket.TotalPrice.IntegerPart, basket.TotalPrice.DecimalPart);
        }

        public Euro GetTotalPrice()
        {
            return totalPrice;
        }
    }
}
