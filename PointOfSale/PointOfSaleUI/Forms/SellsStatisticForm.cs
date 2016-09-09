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
using System.Windows.Forms.DataVisualization.Charting;

namespace PointOfSaleUI.Forms
{
    public partial class SellsStatisticForm : Form
    {

        public SellsStatisticForm()
        {
            InitializeComponent();
            List<KeyValuePair<string, int>> sd = PointOfSaleRoot.GetInstance().SellingStatistic.GetAllProducts(); 
            foreach(KeyValuePair<string,int> pair in sd)
            {
                Series s = chartTotalSelling.Series.Add(pair.Key);
                s.Points.Add(pair.Value);
                s.IsValueShownAsLabel = true;
            } 
        }

        private void SellingStatisticForm_Load(object sender, EventArgs e)
        {
            /* Empty */
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Têm a certeza que deseja apagar os dados?", "Apagar estatistica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    new ClearStatisticDataService().Execute();
                    chartTotalSelling.Series.Clear();
                }
            }
            catch (NoAuthorizationException)
            {
                MessageBox.Show("Não tem autorização para efectuar esta acção", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
