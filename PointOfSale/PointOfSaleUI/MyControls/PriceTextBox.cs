using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleUI.MyControls
{
    public class PriceTextBox : TextBox
    {

        private string innerText = string.Empty;

        public PriceTextBox()
        {
            KeyDown += PriceTextBox_KeyDown;
            KeyPress += PriceTextBox_KeyPress;
        }

        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
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
            if (((KeyCode == 8) || (KeyCode == 46)) && (innerText.Length > 0))
            {
                innerText = innerText.Substring(0, innerText.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                innerText = innerText + Convert.ToChar(KeyCode);
            }
            if (innerText.Length == 0)
            {
                textBox.Text = "";
            }
            if (innerText.Length == 1)
            {
                textBox.Text = "0,0" + innerText;
            }
            else if (innerText.Length == 2)
            {
                textBox.Text = "0," + innerText;
            }
            else if (innerText.Length > 2)
            {
                textBox.Text = innerText.Substring(0, innerText.Length - 2) + "," +
                                innerText.Substring(innerText.Length - 2);
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
