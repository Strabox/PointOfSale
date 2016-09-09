using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class GetLoggedInUserService : PointOfSaleService
    {

        private string username;

        protected override void AccessControl()
        {
            /* Anyone can ask for this */
        }

        protected override void Dispatch()
        {
            username = PointOfSaleRoot.GetInstance().LoggedInUser.Username;
        }

        public string GetCurrentUser()
        {
            return username;
        }

    }
}
