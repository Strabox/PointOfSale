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
        private IDictionary<string, IList<SellableItem>> sellingItems;


        public SellingItems()
        {
            sellingItems = new Dictionary<string, IList<SellableItem>>();
        }

        private void VerifyItemExist(string category,string name)
        {
            IList<SellableItem> items = sellingItems[category];
            foreach (SellableItem item in items)
            {
                if (item.Name.Equals(name))
                {
                    throw new SellingItemAlreadyExistException();
                }
            }
        }

        public void AddItemToCategory(string category,SellableItem newItem)
        {
            if (!sellingItems.ContainsKey(category))
            {
                throw new CategoryDoesntExistException();
            }
            VerifyItemExist(category,newItem.Name);
            IList<SellableItem> items = sellingItems[category];
            items.Add(newItem);
        }

        public void RemoveItemFromCategory(string category,string itemName)
        {
            if (!sellingItems.ContainsKey(category))
            {
                throw new CategoryDoesntExistException();
            }
            IList<SellableItem> items = sellingItems[category];
            foreach (SellableItem item in items)
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
            bool done = false;
            if (!itemName.Equals(newItemName))
            {
                VerifyItemExist(category,newItemName);
            }
            foreach(KeyValuePair<string,IList<SellableItem>> entry in sellingItems)
            {
                if (done)
                {
                    break;
                }
                foreach(SellableItem item in entry.Value)
                {
                    if (itemName.Equals(item.Name))
                    {
                        item.Name = newItemName;
                        item.Price = newPrice;
                        item.Image = itemNewImage;
                        done = true;
                        break;
                    }
                }
            }
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
            sellingItems.Add(category, new List<SellableItem>());
        }


        public SellableItem GetItem(string itemName)
        {
            foreach (KeyValuePair<string, IList<SellableItem>> entry in sellingItems)
            {
                foreach (SellableItem item in entry.Value)
                {
                    if (itemName.Equals(item.Name))
                    {
                        return item; 
                    }
                }
            }
            throw new SellingItemDoesntExistException();
        }

        /// <summary>
        ///     More to development purpose than production
        /// </summary>
        public void ResetToDefault()
        {
            sellingItems.Clear();
            AddCategory("Festas");
            AddItemToCategory("Festas", new SellableItem("Bebida", new Euro(0, 80), Properties.Resources.cerveja));
            AddItemToCategory("Festas", new SellableItem("Frango", new Euro(2, 50), Properties.Resources.frango));
            AddItemToCategory("Festas", new SellableItem("Salada de Tomate", new Euro(1, 50), Properties.Resources.tomate));
            AddItemToCategory("Festas", new SellableItem("Batatas Fritas", new Euro(1, 50), Properties.Resources.batatas));
            AddItemToCategory("Festas", new SellableItem("Carcaça", new Euro(0, 75), Properties.Resources.carcaça));
            AddItemToCategory("Festas", new SellableItem("Arroz Doce", new Euro(1, 50), Properties.Resources.arrozDoce));
            AddItemToCategory("Festas", new SellableItem("Bifana", new Euro(1, 90), Properties.Resources.bifana));
            AddItemToCategory("Festas", new SellableItem("Café", new Euro(0, 50), Properties.Resources.café));
            AddItemToCategory("Festas", new SellableItem("Caracóis", new Euro(2, 50), Properties.Resources.caracóis));
            AddItemToCategory("Festas", new SellableItem("Filhós", new Euro(1, 40), Properties.Resources.filhó));
            AddItemToCategory("Festas", new SellableItem("Melão", new Euro(1, 50), Properties.Resources.melão));
            AddItemToCategory("Festas", new SellableItem("Pipis", new Euro(2, 50), Properties.Resources.pipis));
        }

        public IList<KeyValuePair<string,IList<SellableItem>>> GetAllItems()
        {
            IList<KeyValuePair<string, IList<SellableItem>>> res = new List<KeyValuePair<string, IList<SellableItem>>>();
            foreach (KeyValuePair<string, IList<SellableItem>> entry in sellingItems)
            {
                IList<SellableItem> listRes = new List<SellableItem>();
                KeyValuePair<string, IList<SellableItem>> pair = new KeyValuePair<string, IList<SellableItem>>(entry.Key,listRes);
                res.Add(pair);
                foreach (SellableItem item in entry.Value)
                {
                    listRes.Add(new SellableItem(item.Name, item.Price, item.Image));
                }
            }
            return res;
        }

        public override string ToString()
        {
            string res = "";
            foreach(KeyValuePair<string,IList<SellableItem>> entry in sellingItems)
            {
                res += "Category " + entry.Key + ":" + Environment.NewLine;
                foreach(SellableItem item in entry.Value)
                {
                    res += "  " + item + Environment.NewLine;
                }
            }
            return res;
        }
    }
}
