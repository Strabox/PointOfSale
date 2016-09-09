using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class ExitPointOfSaleAppService : PointOfSaleService
    {
        protected override void AccessControl()
        {
            PointOfSaleRoot root = PointOfSaleRoot.GetInstance();
            User user = root.LoggedInUser;
            if (root.LoggedInUser == null || (user.Role != UserRole.ADMIN))
            {
                throw new NoAuthorizationException();
            }
        }

        protected override void Dispatch()
        {
            /* Service doesnt do nothing */
        }
    }
}
