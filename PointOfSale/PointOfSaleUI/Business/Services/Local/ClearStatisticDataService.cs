using PointOfSaleUI.Business.Domain;
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

        protected override void Dispatch()
        {
            SellingStatistic statistic = DomainRoot.SellingStatistic;
            statistic.ClearStatistic();
            PersistenceManager.PersistObjectToBinaryFile(PersistenceManager.PERSISTENT_DATA_FILE, statistic);
        }

    }
}
