using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Services.Local;
using PointOfSaleUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleUI
{
    /// <summary>
    ///     Festas: Bebida, Frango, Bifanas, Pipis, Caracóis, Salada de Tomate, Batatas Fritas, Café , Filhó
    ///             Melão, Arroz Doce, Carcaças
    ///     Bar: [TODO]
    /// </summary>
    public partial class SellingForm : Form
    {

        public SellingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Refresh/update the selling items in UI
        /// </summary>
        private void RefreshSellingItems()
        {
            // Populate selling items
            tabControlItems.TabPages.Clear();
            IList<KeyValuePair<string, IList<SellableItem>>> items = DomainRoot.SellingItems.GetAllItems();
            foreach (KeyValuePair<string, IList<SellableItem>> pair in items)
            {
                int itemsQuantity = pair.Value.Count;
                int side = Convert.ToInt32(Math.Ceiling(Math.Sqrt(itemsQuantity)));
                int columns, rows;
                side = (side < 2) ? 2 : side;   //Prevent a Grid 1 X 1 due to size
                columns = side;
                rows = (((side * side) - itemsQuantity) == side) ? side - 1 : side; //Prevent empty lines
                TableLayoutPanel tlp = new TableLayoutPanel() { Dock = DockStyle.Fill };
                TabPage tab = new TabPage(pair.Key);
                tab.Controls.Add(tlp);
                tabControlItems.TabPages.Add(tab);

                tlp.ColumnCount = columns;
                for (int i = 0; i < columns; i++)
                {
                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
                }
                tlp.RowCount = rows;
                for (int i = 0; i < rows; i++)
                {
                    tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rows));
                }

                foreach (SellableItem item in pair.Value)
                {
                    int column = 0, row = 0;
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Dock = DockStyle.Fill;
                    pic.Image = item.Image;
                    pic.Click += (se, ev) => {
                        MouseEventArgs evs = ev as MouseEventArgs;
                        if (evs.Button == MouseButtons.Left)
                        {
                            new AddItemToBasketService(item.Name).Execute();
                            RefreshBasketUI();
                        }
                    };
                    tlp.Controls.Add(pic, column, row);
                    if (column == (side - 1))
                    {
                        column = 0;
                        row++;
                    }
                    else
                    {
                        column++;
                    }
                }
            }
        }

        /// <summary>
        ///     Refresh/update the basket information in UI
        /// </summary>
        private void RefreshBasketUI()
        {
            GetBasketTotalPriceService s = new GetBasketTotalPriceService();
            s.Execute();
            GetBasketCartStateService s2 = new GetBasketCartStateService();
            s2.Execute();
            GetBasketRepresentationService s3 = new GetBasketRepresentationService();
            s3.Execute();
            richTextBoxBasket.Text = s3.GetBasketRepresentation();
            labelTotalPrice.Text = s.GetTotalPrice().ToString() + " " + Euro.GetSymbol() ;
            if (s2.BasketIsEmpty())
            {
                buttonCheckout.Enabled = false;
            }
            else
            {
                buttonCheckout.Enabled = true;
            }   
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            buttonCheckout.Enabled = false;
            DomainRoot.SellingItems.ResetToDefault();   //Override the design time selling items
            RefreshSellingItems();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void globalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SellingStatisticForm().ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            new ResetBasketCartService().Execute();
            RefreshBasketUI();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            GetBasketTotalPriceService s = new GetBasketTotalPriceService();
            s.Execute();
            new CheckoutForm(s.GetTotalPrice()).ShowDialog();
        }

        private void SellingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                GetBasketTotalPriceService s = new GetBasketTotalPriceService();
                s.Execute();
                new CheckoutForm(s.GetTotalPrice()).ShowDialog();
            }
        }

        private void SellingForm_Activated(object sender, EventArgs e)
        {
            RefreshBasketUI();
        }

        private void SellingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            TODO
            if(new ExitingForm().ShowDialog() != DialogResult.OK)
            {
                e.Cancel = true;
            }
            */
        }
    }
}
