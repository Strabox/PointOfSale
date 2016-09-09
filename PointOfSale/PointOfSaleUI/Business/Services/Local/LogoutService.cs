using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Service to logout the current logged in user
    /// </summary>
    public class LogoutService : PointOfSaleService
    {
        protected sealed override void AccessControl()
        {
            /* Any users can access the Login service */
        }

        protected sealed override void Dispatch()
        {
            PointOfSaleRoot.GetInstance().Logout();
        }
    }
}
