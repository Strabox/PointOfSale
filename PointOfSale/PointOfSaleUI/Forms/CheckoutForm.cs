using PointOfSaleUI.Business.Domain;
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
    public partial class CheckoutForm : Form
    {

        private Euro totalPrice;


        public CheckoutForm(Euro tp)
        {
            InitializeComponent();
            totalPrice = tp;
            labelTotalPrice.Text = totalPrice.ToString();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
