using PointOfSaleUI.Business.Domain;
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

        protected override void Dispatch()
        {
            BasketCart basket = DomainRoot.BasketCart;
            basketRepresentation = basket.ToString();
        }

        public string GetBasketRepresentation()
        {
            return basketRepresentation;
        }

    }
}
