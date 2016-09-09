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
        private Dictionary<SellableProduct, int> basketCart;

        /// <summary>
        ///     Total price of all the items in the basket cart
        /// </summary>
        private Euro totalPrice;
        public Euro TotalPrice { get { return new Euro(totalPrice.IntegerPart, totalPrice.DecimalPart); } }


        public BasketCart()
        {
            basketCart = new Dictionary<SellableProduct, int>(new SellableItemComparer());
            totalPrice = new Euro();
        }


        public void AddItemToBasket(SellableProduct item)
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

        public void RemoveItemFromBasket(SellableProduct item)
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
        
        public List<KeyValuePair<SellableProduct,int>> GetAllItems()
        {
            List<KeyValuePair<SellableProduct, int>> res = new List<KeyValuePair<SellableProduct, int>>();
            foreach(KeyValuePair<SellableProduct,int> entry in basketCart)
            {
                res.Add(new KeyValuePair<SellableProduct, int>(entry.Key, entry.Value));
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
            foreach(KeyValuePair<SellableProduct,int> entry in basketCart)
            {
                res += entry.Value + " X " + entry.Key.Name + Environment.NewLine;

            }
            return res;
        }

    }
}
