using PointOfSaleUI.Business.Services.Local;
using PointOfSaleUI.Business.Services.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Integrator
{
    public class CheckoutBasketCartIntegratorService : PointOfSaleService
    {

        private CheckoutBasketCartService localCheckoutService;

        private PrintTicketService printTicketService;


        public CheckoutBasketCartIntegratorService()
        {
            localCheckoutService = new CheckoutBasketCartService();
        }

        protected override void Dispatch()
        {
            localCheckoutService.Execute();
            printTicketService.Execute();
        }
    }
}
