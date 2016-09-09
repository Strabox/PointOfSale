using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class GetLoggedInUserRoleService : PointOfSaleService
    {

        private UserRole loggedInUserRole;

        protected override void AccessControl()
        {
            /* Empty */
        }

        protected override void Dispatch()
        {
            loggedInUserRole = PointOfSaleRoot.GetInstance().LoggedInUser.Role;
        }

        public UserRole GetUserRole()
        {
            return loggedInUserRole;
        }

    }
}
