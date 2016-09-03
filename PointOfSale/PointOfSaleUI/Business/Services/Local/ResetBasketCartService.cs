﻿using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class ResetBasketCartService : PointOfSaleService
    {

        protected override void Dispatch()
        {
            BasketCart basket = DomainRoot.BasketCart;
            basket.ClearBasketCart();
        }

    }
}
