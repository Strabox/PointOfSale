using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Persistence
{
    [Serializable]
    public class PersistentData
    {

        private Dictionary<string, int> statisticData;

        public PersistentData()
        {
            statisticData = new Dictionary<string, int>();
        }



    }
}
