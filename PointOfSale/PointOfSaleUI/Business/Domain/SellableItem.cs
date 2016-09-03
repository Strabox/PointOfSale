using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    /// Representa an item that can be sold
    /// </summary>
    [Serializable]
    public class SellableItem : ISerializable
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
        ///     Item PVP price
        /// </summary>
        private Euro price;
        public Euro Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        ///     Items Image
        /// </summary>
        private Image image;
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public SellableItem(string name,Euro price,Image image)
        {
            Name = name;
            Price = price;
            Image = image;
        }

        public SellableItem(string name,Euro price)
        {
            Name = name;
            Price = price;
            image = null;
        }

        /// <summary>
        ///     Deserialization constructor
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public SellableItem(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("name");
            Price = info.GetValue("price", typeof(Euro)) as Euro;
            Image = info.GetValue("image", typeof(Image)) as Image;
        }

        public override string ToString()
        {
            return "Name: " + Name + " " + "Price: " + Price;
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

        /* ====================== Serialization Methods ====================== */

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", Name);
            info.AddValue("price", Price);
            info.AddValue("image", Image);
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
