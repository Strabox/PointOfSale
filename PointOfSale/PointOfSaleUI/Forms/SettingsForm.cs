using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
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

        /// <summary>
        ///     At least one modification to selling items was made.
        /// </summary>
        private bool sellingItemsModified = false;


        public SettingsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Refresh the list of selling items
        /// </summary>
        private void RefreshSellingItemsUI()
        {
            int imageIndex = 0;
            treeViewCategoryItems.ImageList = new ImageList();
            treeViewCategoryItems.Nodes.Clear();    //Clear the tree view items list
            foreach (KeyValuePair<string, IList<SellableProduct>> entry in PointOfSaleRoot.GetInstance().CurrentProducts.GetAllItems())
            {
                TreeNode node = treeViewCategoryItems.Nodes.Add(entry.Key);
                node.ContextMenuStrip = contextMenuStripCategoryMenu;
                foreach (SellableProduct item in entry.Value)
                {
                    treeViewCategoryItems.ImageList.Images.Add(item.Image);
                    TreeNode itemNode = node.Nodes.Add(item.Name);
                    itemNode.ContextMenuStrip = contextMenuStripItemMenu;
                    itemNode.ImageIndex = imageIndex;
                    itemNode.SelectedImageIndex = imageIndex;

                    imageIndex++;
                }
            }
        }

        /* ============================= Event handlers ===================================== */

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            buttonEditSelectedItem.Enabled = false;
            buttonAddCategory.Enabled = false;
            RefreshSellingItemsUI();
        }

        private void treeViewCategoryItems_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)      //Selecting item with left click
            {
                TreeNode node = e.Node;
                if (node.Parent != null)        //Children Node click
                {
                    SellableProduct item = PointOfSaleRoot.GetInstance().CurrentProducts.GetItem(node.Text);
                    nameItemSelected = item.Name;
                    categoryItemSelected = node.Parent.Text;

                    pictureBoxSelectedItem.Image = item.Image;
                    textBoxSelectedItemName.Text = item.Name;
                    priceTextBoxSelectedItemPrice.Text = item.Price.ToString();

                    itemSelected = true;
                }
                else                            //Root Node Click
                {
                    itemSelected = false;
                    buttonEditSelectedItem.Enabled = false;
                    pictureBoxSelectedItem.Image = null;
                    textBoxSelectedItemName.Text = string.Empty;
                    priceTextBoxSelectedItemPrice.Text = string.Empty;
                }
            }
            else if (e.Button == MouseButtons.Right)    //Selecting item with right click
            {
                treeViewCategoryItems.SelectedNode = e.Node;
            }
        }

        private void buttonEditSelectedItem_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = textBoxSelectedItemName.Text;
                string[] tokens = priceTextBoxSelectedItemPrice.Text.Split(',');
                int euroPrice = int.Parse(tokens[0]);
                int centsPrice = int.Parse(tokens[1]);
                Image image = pictureBoxSelectedItem.Image;

                ChangeSellingItemInformationService service;
                service = new ChangeSellingItemInformationService(nameItemSelected, categoryItemSelected,
                    newName, euroPrice, centsPrice, image);
                service.Execute();
                sellingItemsModified = true;
            }
            catch (NoAuthorizationException)
            {
                MessageBox.Show("Não tem autorização para efectuar esta acção", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void toolStripMenuRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripItem menuItem = sender as ToolStripItem;
                ContextMenuStrip ctxStrip = menuItem.Owner as ContextMenuStrip;
                TreeView treeView = ctxStrip.SourceControl as TreeView;
                TreeNode clickedNode = treeView.SelectedNode;

                string category = clickedNode.Parent.Text;
                string item = clickedNode.Text;

                RemoveSellingItemService service = new RemoveSellingItemService(category, item);
                service.Execute();
                RefreshSellingItemsUI();
                sellingItemsModified = true;
            }
            catch (NoAuthorizationException)
            {
                MessageBox.Show("Não tem autorização para efectuar esta acção", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void toolStripMenuRemoveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripItem menuItem = sender as ToolStripItem;
                ContextMenuStrip ctxStrip = menuItem.Owner as ContextMenuStrip;
                TreeView treeView = ctxStrip.SourceControl as TreeView;
                TreeNode clickedNode = treeView.SelectedNode;

                string category = clickedNode.Text;
                RemoveSellingCategoryService service = new RemoveSellingCategoryService(category);
                service.Execute();
                RefreshSellingItemsUI();
                sellingItemsModified = true;
            }
            catch (NoAuthorizationException)
            {
                MessageBox.Show("Não tem autorização para efectuar esta acção", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripMenuAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripItem menuItem = sender as ToolStripItem;
                ContextMenuStrip ctxStrip = menuItem.Owner as ContextMenuStrip;
                TreeView treeView = ctxStrip.SourceControl as TreeView;
                TreeNode clickedNode = treeView.SelectedNode;

                if (new AddSellableProductForm(clickedNode.Text).ShowDialog() == DialogResult.OK)
                {
                    RefreshSellingItemsUI();
                    sellingItemsModified = true;
                }
            }
            catch (NoAuthorizationException)
            {
                MessageBox.Show("Não tem autorização para efectuar esta acção", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxCategoryName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxCategoryName = sender as TextBox;
            if (textBoxCategoryName.Text.Equals(string.Empty))
            {
                buttonAddCategory.Enabled = false;
            }
            else
            {
                buttonAddCategory.Enabled = true;
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string newCategory = textBoxCategoryName.Text;
                AddCategoryService service = new AddCategoryService(newCategory);
                service.Execute();
                RefreshSellingItemsUI();
                sellingItemsModified = true;
            }
            catch (NoAuthorizationException)
            {
                MessageBox.Show("Não tem autorização para efectuar esta acção", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sellingItemsModified)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Ignore;
            }
        }
    }
}
