using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    ///     BasketCart represents ...
    /// </summary>
    public class BasketCart
    {

        private Dictionary<SellableItem, int> basketCart;

        private Euro totalPrice;
        public Euro TotalPrice { get { return totalPrice; } }

        public BasketCart()
        {
            basketCart = new Dictionary<SellableItem, int>(new SellableItemComparer());
            totalPrice = new Euro();
        }


        public void AddItemToBasket(SellableItem item)
        {
            totalPrice.add(item.Price);
            if (basketCart.ContainsKey(item))
            {
                basketCart[item]++;
            }
            else
            {
                basketCart.Add(item, 1);
            }
        }

        public bool IsEmpty()
        {
            return basketCart.Count == 0;
        }

        public void ClearBasketCart()
        {
            basketCart.Clear();
            totalPrice = new Euro();
        }

        public override string ToString()
        {
            string res = string.Empty;
            foreach(KeyValuePair<SellableItem,int> entry in basketCart)
            {
                res += entry.Key.Name + " X " + entry.Value + Environment.NewLine;
            }
            return res;
        }

    }
}
