using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    /// Representa an item that can be sold
    /// </summary>
    public class SellableItem
    {

        /// <summary>
        ///     Name is the item/product identifier
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        ///     Item PvP price
        /// </summary>
        private Euro price;
        public Euro Price
        {
            get { return price; }
            set { price = value; }
        }

        public SellableItem(string name,Euro price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            SellableItem item = obj as SellableItem;
            return item.Name.Equals(Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

    }

    /// <summary>
    ///     Compararer for sellable items
    /// </summary>
    public class SellableItemComparer : IEqualityComparer<SellableItem>
    {
        public bool Equals(SellableItem x, SellableItem y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(SellableItem obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
