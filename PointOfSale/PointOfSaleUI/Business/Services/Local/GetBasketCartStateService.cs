using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class GetBasketCartStateService : PointOfSaleService
    {

        private BasketCart basketCart;

        private bool basketEmpty;

        public GetBasketCartStateService(BasketCart b)
        {
            basketCart = b;
        }

        protected override void Dispatch()
        {
            basketEmpty = basketCart.IsEmpty();
        }

        public bool BasketIsEmpty()
        {
            return basketEmpty;
        }
    }
}
