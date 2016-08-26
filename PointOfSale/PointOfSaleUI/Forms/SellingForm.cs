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

        private BasketCart basketCart;


        public SellingForm()
        {
            InitializeComponent();
        }


        private void refreshUI()
        {
            GetBasketTotalPriceService s = new GetBasketTotalPriceService(basketCart);
            s.Execute();
            GetBasketCartStateService s2 = new GetBasketCartStateService(basketCart);
            s2.Execute();
            richTextBoxBasket.Text = basketCart.ToString();
            labelTotalPrice.Text = s.GetTotalPrice().ToString();
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
            basketCart = new BasketCart();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void globalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            new ResetBasketCartService(basketCart).Execute();
            refreshUI();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            GetBasketTotalPriceService s = new GetBasketTotalPriceService(basketCart);
            s.Execute();
            new CheckoutForm(s.GetTotalPrice()).ShowDialog();
        }

        private void SellingForm_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Wow");
        }

        /* ============================================================ */

        private void buttonBeverage_Click(object sender, EventArgs e)
        {
            new AddItemToBasketService(basketCart, new SellableItem("Bebida", new Euro(0, 90))).Execute();
            refreshUI();
        }

        private void buttonFries_Click(object sender, EventArgs e)
        {
            new AddItemToBasketService(basketCart, new SellableItem("Batatas Fritas", new Euro(1, 50))).Execute();
            refreshUI();
        }

        private void buttonChicken_Click(object sender, EventArgs e)
        {
            new AddItemToBasketService(basketCart, new SellableItem("Frango", new Euro(2, 50))).Execute();
            refreshUI();
        }

    }
}
