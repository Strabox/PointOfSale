using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class DoChangeService : PointOfSaleService
    {

        private Euro price;

        private Euro payment;

        private Euro change;

        public DoChangeService(Euro pa,Euro pr)
        {
            payment = pa;
            price = pr;
        }

        protected override void Dispatch()
        {
            try {
                change = new Euro(payment.IntegerPart, payment.DecimalPart);
                change.Subtract(price);
            }
            catch (NegativeEuroResultException)
            {
                throw new InsuficcientMoneyException();
            }
        }

        public Euro GetChange()
        {
            return change;
        }

    }
}
