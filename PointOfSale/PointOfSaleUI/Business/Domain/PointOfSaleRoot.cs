using PointOfSaleUI.Business.Exceptions;
using PointOfSaleUI.Business.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    ///     PointOfSaleRoot contains the main domain objects (principally singletons)
    /// </summary>
    public class PointOfSaleRoot
    {

        private static PointOfSaleRoot root = null;

        /// <summary>
        ///     Return singelton PointOfSaleRoot
        /// </summary>
        /// <returns>PointOfSaleRoot Singleton</returns>
        public static PointOfSaleRoot GetInstance()
        {
            if (root == null)
            {
                root = new PointOfSaleRoot();
            }
            return root;
        }

        /// <summary>
        ///     Singleton BasketCart for the application
        /// </summary>
        private BasketCart basketCart = null;
        public BasketCart BasketCart
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
        private SellingItems currentProducts = null;
        public SellingItems CurrentProducts
        {
            get
            {
                if(currentProducts == null)
                {
                    currentProducts = PersistenceManager.GetObjectFromBinaryFile(PersistenceManager.PERSISTENT_ITEMS_FILE)
                        as SellingItems;
                    if(currentProducts == null)
                    {
                        currentProducts = new SellingItems();
                    }
                }
                return currentProducts;
            }
        }

        /// <summary>
        ///     Singleton selling statistic object for the application. Persisted to disk.
        /// </summary>
        private SellingStatistic sellingStatistic = null;
        public SellingStatistic SellingStatistic
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

        /// <summary>
        ///     Current user logged
        /// </summary>
        private User loggedInUser = null;
        public User LoggedInUser { get { return loggedInUser; } }

        /// <summary>
        ///     All users in the system
        /// </summary>
        private IList<User> users = null;


        public PointOfSaleRoot()
        {
            users = PersistenceManager.GetObjectFromBinaryFile(PersistenceManager.PERSISTENT_USERS_FILE)
                as IList<User>;
            if(users == null)
            {
                users = new List<User>();
                users.Add(new User("Administrador", "arcusbadass", UserRole.ADMIN));
                PersistenceManager.PersistObjectToBinaryFile(PersistenceManager.PERSISTENT_USERS_FILE, users);
            }
            loggedInUser = new User(User.ANONYMOUS_USER_NAME, string.Empty, UserRole.ANONYMOUS); ;
        }


        public void Login(string username, string password)
        {
            foreach(User user in users)
            {
                if (user.Username.Equals(username) && user.PasswordHash.Equals(password))
                {
                    loggedInUser = user;
                    return;
                }
                else if(user.Username.Equals(username) && !user.PasswordHash.Equals(password))
                {
                    throw new InvalidUsernamePasswordCombinationException();
                }
            }
            throw new InvalidUsernamePasswordCombinationException();
        }

        public void Logout()
        {
            //Let anonymous user always as logged in
            loggedInUser = new User(User.ANONYMOUS_USER_NAME, string.Empty, UserRole.ANONYMOUS);
        }

        /// <summary>
        ///     Clear in memory objects and PERSISTED ones
        /// </summary>
        public void Clear()
        {
            sellingStatistic = null;
            currentProducts = null;
            basketCart = null;
            PersistenceManager.DeleteFile(PersistenceManager.PERSISTENT_DATA_FILE);
            PersistenceManager.DeleteFile(PersistenceManager.PERSISTENT_ITEMS_FILE);
            PersistenceManager.DeleteFile(PersistenceManager.PERSISTENT_USERS_FILE);
        }

    }
}
