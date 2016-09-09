using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsOfSaleTests.Services
{
    [TestClass]
    public abstract class PointOfSaleServiceTest
    {

        [TestInitialize]
        public virtual void Populate() { /* Empty */ }

        [TestCleanup]
        public void TearDown()
        {
            PointOfSaleRoot.GetInstance().Clear();
        }

        protected void AddCategory(string category)
        {
            PointOfSaleRoot.GetInstance().CurrentProducts.AddCategory(category);
        }

        protected void AddSellingItem(string category,string productName,int priceEuro,int priceCents,
            Image itemImage)
        {
            PointOfSaleRoot.GetInstance().CurrentProducts.AddItemToCategory(category, new SellableProduct(productName, new Euro(priceEuro, priceCents)));
        }

        protected void AddProductToBasket(string name,int euro,int cents)
        {
            PointOfSaleRoot.GetInstance().BasketCart.AddItemToBasket(new SellableProduct(name, new Euro(euro, cents)));
        }

        protected void AddStatisticProduct(string productName,int quantity)
        {
            PointOfSaleRoot.GetInstance().SellingStatistic.AddProduct(new SellableProduct(productName, new Euro(1, 0)), quantity);
        }

        protected SellableProduct GetBasketProduct(string productName)
        {
            foreach(KeyValuePair<SellableProduct,int> pair in PointOfSaleRoot.GetInstance().BasketCart.GetAllItems())
            {
                if (pair.Key.Name.Equals(productName))
                {
                    return pair.Key;
                }
            }
            return null;
        }

        protected Euro GetBasketTotalPrice()
        {
            return PointOfSaleRoot.GetInstance().BasketCart.TotalPrice;
        }

        protected int GetBasketProductQuantity(string productName)
        {
            foreach (KeyValuePair<SellableProduct, int> pair in PointOfSaleRoot.GetInstance().BasketCart.GetAllItems())
            {
                if (pair.Key.Name.Equals(productName))
                {
                    return pair.Value;
                }
            }
            return 0;
        }

        protected bool SellingCategoryExists(string category)
        {
            foreach(KeyValuePair<string,IList<SellableProduct>> pair in PointOfSaleRoot.GetInstance().CurrentProducts.GetAllItems())
            {
                if (pair.Key.Equals(category))
                {
                    return true && (pair.Value.Count == 0);
                }
            }
            return false;
        }

        protected SellableProduct GetSellingItem(string itemName)
        {
            try
            {
                return PointOfSaleRoot.GetInstance().CurrentProducts.GetItem(itemName);
            }
            catch (SellingItemDoesntExistException)
            {
                return null;
            }
        }

        protected int GetStatisticProductQuantity(string productName)
        {
            foreach(KeyValuePair<string,int> entry in PointOfSaleRoot.GetInstance().SellingStatistic.GetAllProducts())
            {
                if (entry.Key.Equals(productName))
                {
                    return entry.Value;
                }
            }
            return 0;
        }

        protected Euro GetStatisticTotalValue()
        {
            return PointOfSaleRoot.GetInstance().SellingStatistic.TotalValue;
        }

        protected bool IsBasketEmpty()
        {
            return PointOfSaleRoot.GetInstance().BasketCart.IsEmpty();
        }

    }
}
