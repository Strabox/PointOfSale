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

        private bool basketEmpty;

        protected override void Dispatch()
        {
            BasketCart basketCart = DomainRoot.BasketCart;
            basketEmpty = basketCart.IsEmpty();
        }

        public bool BasketIsEmpty()
        {
            return basketEmpty;
        }
    }
}
