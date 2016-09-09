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
    public partial class CheckoutForm : Form
    {
        private Euro totalPrice;

        private Euro payment;


        public CheckoutForm(Euro tp)
        {
            InitializeComponent();
            totalPrice = tp;
            payment = new Euro();
            labelTotalPrice.Text = totalPrice.ToString();
            buttonPay.Enabled = false;
            priceTextBoxPayment.Select();
        }

        private void RefreshUI()
        {
            priceTextBoxPayment.Text = payment.ToString();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            /* Empty */
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            CheckoutBasketCartService s = new CheckoutBasketCartService();
            s.Execute();
            this.Close();
        }

        private void textBoxPayment_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals(""))
            {
                buttonPay.Enabled = false;
                payment.IntegerPart = 0;
                payment.DecimalPart = 0;
            }
            else
            {
                string[] tokens = textBox.Text.Split(',');
                payment.IntegerPart = int.Parse(tokens[0]);
                payment.DecimalPart = int.Parse(tokens[1]);
                try
                {
                    DoChangeService s = new DoChangeService(payment, totalPrice);
                    s.Execute();
                    labelChange.Text = s.GetChange().ToString();
                    buttonPay.Enabled = true;
                }
                catch (InsuficcientPaymentException)
                {
                    labelChange.Text = "--,-- €";
                }

            }
        }

        private void button5Euro_Click(object sender, EventArgs e)
        {
            payment.Add(new Euro(5, 0));
            RefreshUI();
        }

        private void button10Euro_Click(object sender, EventArgs e)
        {
            payment.Add(new Euro(10, 0));
            RefreshUI();
        }

        private void button20Euro_Click(object sender, EventArgs e)
        {
            payment.Add(new Euro(20, 0));
            RefreshUI();
        }

        private void button50Euro_Click(object sender, EventArgs e)
        {
            payment.Add(new Euro(50, 0));
            RefreshUI();
        }
    }
}
