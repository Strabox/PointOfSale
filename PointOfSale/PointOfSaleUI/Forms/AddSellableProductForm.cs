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
    public partial class AddSellableProductForm : Form
    {

        private string category;

        private bool itemAdded = false;


        public AddSellableProductForm(string category)
        {
            this.category = category;
            InitializeComponent();
        }

        private void AddSellingItemForm_Load(object sender, EventArgs e)
        {
            /* Empty */
        }

        private void buttonAddISellingItem_Click(object sender, EventArgs e)
        {
            string itemName = textBoxItemName.Text;
            Image itemImage = pictureBoxItemImage.Image;
            string[] tokens = priceTextBoxItemPrice.Text.Split(',');
            int euro = int.Parse(tokens[0]), cents = int.Parse(tokens[1]);

            AddSellingItemService service = new AddSellingItemService(itemName, euro, cents, itemImage, category);
            service.Execute();
            itemAdded = true;
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog imageDialog = new OpenFileDialog())
            {
                imageDialog.Title = "Carregar Imagem";
                
                if(imageDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxItemImage.Image = new Bitmap(imageDialog.FileName);
                }
            }
        }

        private void AddSellingItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemAdded)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Ignore;
            }
        }
    }
}
