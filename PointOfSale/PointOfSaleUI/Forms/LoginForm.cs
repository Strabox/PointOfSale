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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                LoginService service = new LoginService(textBoxUsername.Text, textBoxPassword.Text);
                service.Execute();
            }
            catch (InvalidUsernamePasswordCombinationException)
            {
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                labelUserError.Visible = true;
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
