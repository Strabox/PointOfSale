#define DEVELOPMENT

using PointOfSaleUI.Business.Domain;
using PointOfSaleUI.Business.Exceptions;
using PointOfSaleUI.Business.Services.Local;
using PointOfSaleUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
    public partial class SellProductsForm : Form
    {

        public SellProductsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Refresh/update the selling items in UI
        /// </summary>
        private void RefreshSellingItemsUI()
        {
            // Populate selling items
            tabControlItems.TabPages.Clear();
            IList<KeyValuePair<string, IList<SellableProduct>>> items = PointOfSaleRoot.GetInstance().CurrentProducts.GetAllItems();
            foreach (KeyValuePair<string, IList<SellableProduct>> pair in items)
            {
                int itemsQuantity = pair.Value.Count;
                int side = Convert.ToInt32(Math.Ceiling(Math.Sqrt(itemsQuantity)));
                int columns, rows;
                side = (side < 2) ? 2 : side;       //Prevent a Grid 1 X 1 due to size
                columns = side;
                rows = (((side * side) - itemsQuantity) >= side) ? side - 1 : side; //Prevent empty lines
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

                foreach (SellableProduct item in pair.Value)
                {
                    int column = 0, row = 0, aux = 5;
                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    contextMenu.Items.Add("Adicionar 5");
                    contextMenu.Items.Add("Adicionar 10");
                    contextMenu.Items.Add("Adicionar 15");
                    contextMenu.Items.Add("Adicionar 20");
                    ToolStripItemCollection c = contextMenu.Items;
                    foreach(ToolStripMenuItem tsItem in c)
                    {
                        tsItem.Click += (se, ev) => {
                            new AddProductToBasketService(item.Name,aux).Execute();
                            RefreshBasketUI();
                        };
                        aux += 5;
                    }
                    Button itemButton = new Button();
                    itemButton.BackgroundImage = item.Image;
                    itemButton.BackgroundImageLayout = ImageLayout.Stretch;
                    itemButton.Dock = DockStyle.Fill;
                    itemButton.Text = item.Price.ToString() + " " + Euro.GetSymbol();
                    itemButton.TextAlign = ContentAlignment.TopRight;
                    itemButton.Font = Properties.Settings.Default.SellingButtonPriceFont;
                    itemButton.ContextMenuStrip = contextMenu;
                    itemButton.Click += (se, ev) => {
                        MouseEventArgs evs = ev as MouseEventArgs;
                        if (evs != null && evs.Button == MouseButtons.Left)
                        {
                            new AddProductToBasketService(item.Name,1).Execute();
                            RefreshBasketUI();
                        }
                    };
                    tlp.Controls.Add(itemButton, column, row);
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
        ///     Refresh/update the basket information and related conctrols in UI
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

        private void RefreshUserLevelAccessUI()
        {
            GetLoggedInUserRoleService service = new GetLoggedInUserRoleService();
            service.Execute();
            if (service.GetUserRole() == UserRole.ADMIN)
            {
                settingsToolStripMenuItem.Visible = true;
                exitToolStripMenuItem1.Visible = true;
                logoutToolStripMenuItem.Visible = true;
            }
            else
            {
                logoutToolStripMenuItem.Visible = false;
                settingsToolStripMenuItem.Visible = false;
                exitToolStripMenuItem1.Visible = false;
            }
            GetLoggedInUserService service2 = new GetLoggedInUserService();
            service2.Execute();
            labelLoggedInUser.Text = service2.GetCurrentUser() + " , logado";
        }

        /* ============================== Event handlers ============================== */

        private void SellingForm_Load(object sender, EventArgs e)
        {
            buttonCheckout.Enabled = false;
            PointOfSaleRoot.GetInstance().CurrentProducts.ResetToDefault();   //Override the design time selling items
            RefreshSellingItemsUI();
            RefreshUserLevelAccessUI();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void globalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SellsStatisticForm().ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(new SettingsForm().ShowDialog() == DialogResult.OK)
            {
                RefreshSellingItemsUI();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(new LoginForm().ShowDialog() == DialogResult.OK)
            {
                RefreshUserLevelAccessUI();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LogoutService().Execute();
            RefreshUserLevelAccessUI();
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
            #if (!DEVELOPMENT)
            try
            {
                ExitPointOfSaleAppService service = new ExitPointOfSaleAppService();
                service.Execute();
            }
            catch (NoAuthorizationException)
            {
                MessageBox.Show("Não tem autorização para efectuar esta acção", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            #endif
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
    }
}
