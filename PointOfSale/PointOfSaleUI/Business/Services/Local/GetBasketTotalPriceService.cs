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


        protected sealed override void Dispatch()
        {
            BasketCart basket = DomainRoot.BasketCart;
            totalPrice = new Euro(basket.TotalPrice.IntegerPart, basket.TotalPrice.DecimalPart);
        }

        public Euro GetTotalPrice()
        {
            return totalPrice;
        }
    }
}
