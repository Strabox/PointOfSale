using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Services.Local;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleUI.Forms
{
    public partial class SettingsForm : Form
    {

        private string nameItemSelected;

        private string categoryItemSelected;

        private bool itemSelected = false;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void RefreshSellingItemsUI()
        {
            int imageIndex = 0;
            treeViewCategoryItems.ImageList = new ImageList();
            treeViewCategoryItems.Nodes.Clear();
            foreach (KeyValuePair<string, IList<SellableItem>> entry in DomainRoot.SellingItems.GetAllItems())
            {
                TreeNode node = treeViewCategoryItems.Nodes.Add(entry.Key);
                node.ContextMenuStrip = contextMenuStripCategoryMenu;
                foreach (SellableItem item in entry.Value)
                {
                    treeViewCategoryItems.ImageList.Images.Add(item.Image);
                    TreeNode subNode = node.Nodes.Add(item.Name);
                    subNode.ImageIndex = imageIndex;
                    subNode.SelectedImageIndex = imageIndex;

                    imageIndex++;
                }
            }
        }

        /* ============================= Event handlers ===================================== */

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            buttonEditSelectedItem.Enabled = false;
            RefreshSellingItemsUI();
        }

        private void treeViewCategoryItems_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if(node.Parent != null)     //Children Node click
            { 
                SellableItem item = DomainRoot.SellingItems.GetItem(node.Text);
                nameItemSelected = item.Name;
                categoryItemSelected = node.Parent.Text;

                pictureBoxSelectedItem.Image = item.Image;
                textBoxSelectedItemName.Text = item.Name;
                textBoxSelectedItemPrice.Text = item.Price.ToString();

                itemSelected = true;
            }
            else                        //Root Node Click
            {
                itemSelected = false;
                buttonEditSelectedItem.Enabled = false;
                pictureBoxSelectedItem.Image = null;
                textBoxSelectedItemName.Text = string.Empty;
                textBoxSelectedItemPrice.Text = string.Empty;
            }
        }

        /* ============================ Price TextBox Management =========================== */

        private string str = "";

        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void textBoxSelectedItemPrice_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str = str + Convert.ToChar(KeyCode);
            }
            if (str.Length == 0)
            {
                textBox.Text = "";
            }
            if (str.Length == 1)
            {
                textBox.Text = "0,0" + str;
            }
            else if (str.Length == 2)
            {
                textBox.Text = "0," + str;
            }
            else if (str.Length > 2)
            {
                textBox.Text = str.Substring(0, str.Length - 2) + "," +
                                str.Substring(str.Length - 2);
            }
        }

        private void textBoxSelectedItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonEditSelectedItem_Click(object sender, EventArgs e)
        {
            string newName = textBoxSelectedItemName.Text;
            string[] tokens = textBoxSelectedItemPrice.Text.Split(',');
            int euroPrice = int.Parse(tokens[0]);
            int centsPrice = int.Parse(tokens[1]);
            Image image = pictureBoxSelectedItem.Image;

            ChangeSellingItemInformationService service;
            service = new ChangeSellingItemInformationService(nameItemSelected, categoryItemSelected,
                newName, euroPrice, centsPrice, image);
            service.Execute();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSelectedItemName_TextChanged(object sender, EventArgs e)
        {
            if (itemSelected)
            {
                buttonEditSelectedItem.Enabled = true;
            }
        }

        private void textBoxSelectedItemPrice_TextChanged(object sender, EventArgs e)
        {
            if (itemSelected)
            {
                buttonEditSelectedItem.Enabled = true;
            }
        }
    }
}
