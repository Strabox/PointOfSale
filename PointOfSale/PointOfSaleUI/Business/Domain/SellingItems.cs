using PointOfSaleUI.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    /// <summary>
    /// Contains all the items that this point are current selling
    /// </summary>
    [Serializable]
    public class SellingItems
    {
        /// <summary>
        ///     Pairs Category, List of items in that category
        /// </summary>
        private IDictionary<string, IList<SellableProduct>> sellingItems;


        public SellingItems()
        {
            sellingItems = new Dictionary<string, IList<SellableProduct>>();
        }

        private void VerifyItemExist(string category,string name)
        {
            IList<SellableProduct> items = sellingItems[category];
            foreach (SellableProduct item in items)
            {
                if (item.Name.Equals(name))
                {
                    throw new SellingItemAlreadyExistException();
                }
            }
        }

        public void AddItemToCategory(string category,SellableProduct newItem)
        {
            if (!sellingItems.ContainsKey(category))
            {
                throw new CategoryDoesntExistException();
            }
            VerifyItemExist(category,newItem.Name);
            IList<SellableProduct> items = sellingItems[category];
            items.Add(newItem);
        }

        public void RemoveItemFromCategory(string category,string itemName)
        {
            if (!sellingItems.ContainsKey(category))
            {
                throw new CategoryDoesntExistException();
            }
            IList<SellableProduct> items = sellingItems[category];
            foreach (SellableProduct item in items)
            {
                if (item.Name.Equals(itemName))
                {
                    items.Remove(item);
                    break;
                }
            }
        }

        public void SetItemData(string category,string itemName,string newItemName,Euro newPrice,Image itemNewImage)
        {
            if (!itemName.Equals(newItemName))
            {
                VerifyItemExist(category,newItemName);
            }
            foreach(KeyValuePair<string,IList<SellableProduct>> entry in sellingItems)
            {
                foreach(SellableProduct item in entry.Value)
                {
                    if (itemName.Equals(item.Name))
                    {
                        item.Name = newItemName;
                        item.Price = newPrice;
                        item.Image = itemNewImage;
                        return;
                    }
                }
            }
            throw new SellingItemDoesntExistException();
        }

        public void RemoveCategory(string category)
        {
            sellingItems.Remove(category);
        }

        public void AddCategory(string category)
        {
            if (sellingItems.ContainsKey(category))
            {
                throw new CategoryAlreadyExistException();
            }
            sellingItems.Add(category, new List<SellableProduct>());
        }


        public SellableProduct GetItem(string itemName)
        {
            foreach (KeyValuePair<string, IList<SellableProduct>> entry in sellingItems)
            {
                foreach (SellableProduct item in entry.Value)
                {
                    if (itemName.Equals(item.Name))
                    {
                        return item; 
                    }
                }
            }
            throw new SellingItemDoesntExistException();
        }

        public void Clear()
        {
            sellingItems.Clear();
        }

        /// <summary>
        ///     More to development purpose than production
        /// </summary>
        public void ResetToDefault()
        {
            sellingItems.Clear();
            AddCategory("Festas");
            AddItemToCategory("Festas", new SellableProduct("Bebida", new Euro(0, 80), Properties.Resources.bebidas));
            AddItemToCategory("Festas", new SellableProduct("Frango", new Euro(7, 0), Properties.Resources.frango));
            AddItemToCategory("Festas", new SellableProduct("Salada de Tomate", new Euro(1, 50), Properties.Resources.tomate));
            AddItemToCategory("Festas", new SellableProduct("Batatas Fritas", new Euro(1, 50), Properties.Resources.batatas));
            AddItemToCategory("Festas", new SellableProduct("Carcaça", new Euro(0, 50), Properties.Resources.carcaça));
            AddItemToCategory("Festas", new SellableProduct("Arroz Doce", new Euro(1, 0), Properties.Resources.arrozDoce));
            AddItemToCategory("Festas", new SellableProduct("Bifana", new Euro(2, 50), Properties.Resources.bifana));
            AddItemToCategory("Festas", new SellableProduct("Caracóis", new Euro(2, 00), Properties.Resources.caracóis));
            AddItemToCategory("Festas", new SellableProduct("Filhós", new Euro(1, 0), Properties.Resources.filhó));
            AddItemToCategory("Festas", new SellableProduct("Melão", new Euro(1, 0), Properties.Resources.melão));
            //AddItemToCategory("Festas", new SellableItem("Pipis", new Euro(2, 50), Properties.Resources.pipis));
        }

        public IList<KeyValuePair<string,IList<SellableProduct>>> GetAllItems()
        {
            IList<KeyValuePair<string, IList<SellableProduct>>> res = new List<KeyValuePair<string, IList<SellableProduct>>>();
            foreach (KeyValuePair<string, IList<SellableProduct>> entry in sellingItems)
            {
                IList<SellableProduct> listRes = new List<SellableProduct>();
                KeyValuePair<string, IList<SellableProduct>> pair = new KeyValuePair<string, IList<SellableProduct>>(entry.Key,listRes);
                res.Add(pair);
                foreach (SellableProduct item in entry.Value)
                {
                    listRes.Add(new SellableProduct(item.Name, item.Price, item.Image));
                }
            }
            return res;
        }

        public override string ToString()
        {
            string res = "";
            foreach(KeyValuePair<string,IList<SellableProduct>> entry in sellingItems)
            {
                res += "Category " + entry.Key + ":" + Environment.NewLine;
                foreach(SellableProduct item in entry.Value)
                {
                    res += "  " + item + Environment.NewLine;
                }
            }
            return res;
        }
    }
}
