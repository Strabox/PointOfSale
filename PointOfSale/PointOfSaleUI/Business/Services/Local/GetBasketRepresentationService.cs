using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class GetBasketRepresentationService : PointOfSaleService
    {

        private string basketRepresentation;

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
            basketRepresentation = basket.ToString();
        }

        public string GetBasketRepresentation()
        {
            return basketRepresentation;
        }
    }
}
