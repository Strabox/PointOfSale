using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services
{
    /// <summary>
    ///     PointOfSale abstract service interface
    /// </summary>
    public abstract class PointOfSaleService
    {
        
        public void Execute()
        {
            Dispatch();
        }

        protected abstract void Dispatch();

    }
}
