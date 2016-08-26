using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class ResetBasketCartService : PointOfSaleService
    {

        private BasketCart basket;

        public ResetBasketCartService(BasketCart b)
        {
            basket = b;
        }

        protected override void Dispatch()
        {
            basket.ClearBasketCart();
        }
    }
}
