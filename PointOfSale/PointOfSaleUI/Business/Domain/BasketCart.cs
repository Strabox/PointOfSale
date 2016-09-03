using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    ///     BasketCart represents the list and quantities of items client
    ///     want to buy.
    /// </summary>
    public class BasketCart
    {

        /// <summary>
        ///     Contain the items and respective quantities
        /// </summary>
        private Dictionary<SellableItem, int> basketCart;

        /// <summary>
        ///     Total price of all the items in the basket cart
        /// </summary>
        private Euro totalPrice;
        public Euro TotalPrice { get { return totalPrice; } }


        public BasketCart()
        {
            basketCart = new Dictionary<SellableItem, int>(new SellableItemComparer());
            totalPrice = new Euro();
        }


        public void AddItemToBasket(SellableItem item)
        {
            totalPrice.Add(item.Price);
            if (basketCart.ContainsKey(item))
            {
                basketCart[item]++;
            }
            else
            {
                basketCart.Add(item, 1);
            }
        }

        public void RemoveItemFromBasket(SellableItem item)
        {
            if (basketCart.ContainsKey(item))
            {
                totalPrice.Subtract(item.Price);
                if(basketCart[item] == 1){
                    basketCart.Remove(item);
                }
                else
                {
                    basketCart[item]--;
                }
            }
        }
        
        public List<KeyValuePair<SellableItem,int>> GetAllItems()
        {
            List<KeyValuePair<SellableItem, int>> res = new List<KeyValuePair<SellableItem, int>>();
            foreach(KeyValuePair<SellableItem,int> entry in basketCart)
            {
                res.Add(new KeyValuePair<SellableItem, int>(entry.Key, entry.Value));
            }
            return res;
        }

        /// <summary>
        ///     Verifiy if basket is empty
        /// </summary>
        /// <returns>true if empty, false otherwise</returns>
        public bool IsEmpty()
        {
            return basketCart.Count == 0;
        }

        /// <summary>
        ///     Remove all items from the basket cart and reset total price
        /// </summary>
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
                res += entry.Value + " X " + entry.Key.Name + Environment.NewLine;

            }
            return res;
        }

    }
}
