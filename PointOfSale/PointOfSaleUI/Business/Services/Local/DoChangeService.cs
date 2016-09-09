using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Service that given a payment amount and a price returns the respective change
    /// </summary>
    public class DoChangeService : PointOfSaleService
    {

        private Euro price;

        private Euro payment;

        private Euro change;

        public DoChangeService(Euro payment,Euro price)
        {
            this.payment = payment;
            this.price = price;
        }

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
            if(payment == null || price == null)
            {
                throw new ArgumentNullException();
            }

            try {
                change = payment - price;
            }
            catch (NegativeEuroResultException)
            {
                throw new InsuficcientPaymentException();
            }
        }

        public Euro GetChange()
        {
            return change;
        }
    }
}
