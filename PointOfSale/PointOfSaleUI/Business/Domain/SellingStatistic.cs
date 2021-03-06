﻿using PointOfSaleUI.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    ///     Object contains a small statistic about selling products, to be persisted.
    /// </summary>
    [Serializable]
    public sealed class SellingStatistic : ISerializable
    {

        private IDictionary<string, int> statisticData;

        private Euro totalValue;
        public Euro TotalValue { get { return new Euro(totalValue.IntegerPart, totalValue.DecimalPart); } }

        public SellingStatistic()
        {
            statisticData = new Dictionary<string, int>();
            totalValue = new Euro();
        }

        /// <summary>
        ///     Deserialization constructor
        /// </summary>
        /// <param name="info">Serialization information</param>
        /// <param name="context">Context information</param>
        public SellingStatistic(SerializationInfo info,StreamingContext context)
        {
            statisticData = new Dictionary<string, int>();
            List<KeyValuePair<string, int>> list = info.GetValue("statisticData", typeof(List<KeyValuePair<string, int>>)) as List<KeyValuePair<string, int>>;
            foreach(KeyValuePair<string, int> entry in list)
            {
                statisticData.Add(entry.Key, entry.Value);
            }
            totalValue = info.GetValue("totalValue", typeof(Euro)) as Euro;
        }

        
        public void AddProduct(SellableProduct product,int quantity)
        {
            if(quantity < 1)
            {
                throw new ArgumentException("Product quantity < 1");
            }

            Euro total = new Euro(product.Price.IntegerPart, product.Price.DecimalPart);
            total.Multiply(quantity);
            totalValue.Add(total);
            if (statisticData.ContainsKey(product.Name))
            {
                statisticData[product.Name] = statisticData[product.Name] + quantity;
            }
            else
            {
                statisticData.Add(product.Name, quantity);
            }
        }

        public List<KeyValuePair<string, int>> GetAllProducts()
        {
            List<KeyValuePair<string, int>> res = new List<KeyValuePair<string, int>>();
            foreach(KeyValuePair<string, int> entry in statisticData)
            {
                res.Add(new KeyValuePair<string, int>(entry.Key, entry.Value));
            }
            return res;
        }

        public void ClearStatistic()
        {
            statisticData.Clear();
            totalValue = new Euro();
        }

        public override string ToString()
        {
            string res = "";
            foreach(KeyValuePair<string, int> entry in statisticData)
            {
                res += entry.Key + ": " + entry.Value + Environment.NewLine;
            }
            return res;
        }

        /* ========================= Serialize Methods ========================== */

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("statisticData", GetAllProducts());
            info.AddValue("totalValue", totalValue);
        }

    }
}
