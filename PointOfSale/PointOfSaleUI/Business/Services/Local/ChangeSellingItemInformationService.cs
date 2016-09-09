using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Services.Local
{
    /// <summary>
    ///     Change the information of a selling item
    /// </summary>
    public class ChangeSellingItemInformationService : PointOfSaleService
    {

        private string itemName;

        private string category;

        private string itemNewName;

        private int itemNewEuro;

        private int itemNewCents;

        private Image itemNewImage;


        public ChangeSellingItemInformationService(string itemName,string category,
            string itemNewName,int itemNewEuro,int itemNewCents,Image itemNewImage)
        {
            this.itemName = itemName;
            this.category = category;
            this.itemNewName = itemNewName;
            this.itemNewEuro = itemNewEuro;
            this.itemNewCents = itemNewCents;
            this.itemNewImage = itemNewImage;
        }

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
            if (itemName == null || category == null || itemNewName == null || itemNewImage == null)
            {
                throw new ArgumentNullException();
            }
            SellingItems items = PointOfSaleRoot.GetInstance().CurrentProducts;
            items.SetItemData(category, itemName, itemNewName, new Euro(itemNewEuro, itemNewCents), itemNewImage);
        }
    }
}
