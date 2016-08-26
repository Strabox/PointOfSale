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

        private Euro change;

        private Euro price;

        public DoChangeService(Euro c,Euro p)
        {
            change = c;
            price = p;
        }

        protected override void Dispatch()
        {
            try {
                change.subtract(price);
            }
            catch (NegativeEuroResultException)
            {
                throw new InsuficcientMoneyException();
            }
        }

    }
}
