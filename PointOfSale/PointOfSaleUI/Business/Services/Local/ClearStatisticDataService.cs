using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using PointOfSaleUI.Business.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    public class ClearStatisticDataService : PointOfSaleService
    {
        protected sealed override void AccessControl()
        {
            PointOfSaleRoot root = PointOfSaleRoot.GetInstance();
            User user = root.LoggedInUser;
            if (root.LoggedInUser == null || (user.Role != UserRole.ADMIN))
            {
                throw new NoAuthorizationException();
            }
        }

        protected sealed override void Dispatch()
        {
            SellingStatistic statistic = PointOfSaleRoot.GetInstance().SellingStatistic;
            statistic.ClearStatistic();
            PersistenceManager.PersistObjectToBinaryFile(PersistenceManager.PERSISTENT_DATA_FILE, statistic);
        }

    }
}
