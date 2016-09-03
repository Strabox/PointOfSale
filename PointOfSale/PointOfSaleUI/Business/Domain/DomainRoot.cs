using PointOfSaleUI.Business.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    ///     DomainRoot contains the main domain objects (principally singletons)
    /// </summary>
    public static class DomainRoot
    {

        /// <summary>
        ///     Singleton BasketCart for the application
        /// </summary>
        private static BasketCart basketCart = null;
        public static BasketCart BasketCart
        {
            get
            {
                if (basketCart == null)
                {
                    basketCart = new BasketCart();
                }
                return basketCart;
            }
        }

        /// <summary>
        ///     Items that are currently selling in the application
        /// </summary>
        private static SellingItems sellingItems = null;
        public static SellingItems SellingItems
        {
            get
            {
                if(sellingItems == null)
                {
                    sellingItems = PersistenceManager.GetObjectFromBinaryFile(PersistenceManager.PERSISTENT_ITEMS_FILE)
                        as SellingItems;
                    if(sellingItems == null)
                    {
                        sellingItems = new SellingItems();
                    }
                }
                return sellingItems;
            }
        }

        /// <summary>
        ///     Singleton selling statistic object for the application. Persisted to disk.
        /// </summary>
        private static SellingStatistic sellingStatistic = null;
        public static SellingStatistic SellingStatistic
        {
            get
            {
                if(sellingStatistic == null)
                {
                    sellingStatistic = PersistenceManager.GetObjectFromBinaryFile(PersistenceManager.PERSISTENT_DATA_FILE)
                        as SellingStatistic;
                    if(sellingStatistic == null)
                    {
                        sellingStatistic = new SellingStatistic();
                    }
                }
                return sellingStatistic;
            }
        }


    }
}
