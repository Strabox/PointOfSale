namespace PointOfSaleUI.Forms
{
    partial class SellsStatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTotalSelling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalSelling)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTotalSelling
            // 
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea4.AxisX.ScaleBreakStyle.Spacing = 3D;
            chartArea4.Name = "ChartArea1";
            this.chartTotalSelling.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            legend4.Title = "Produto";
            this.chartTotalSelling.Legends.Add(legend4);
            this.chartTotalSelling.Location = new System.Drawing.Point(12, 12);
            this.chartTotalSelling.Name = "chartTotalSelling";
            this.chartTotalSelling.Size = new System.Drawing.Size(882, 504);
            this.chartTotalSelling.TabIndex = 0;
            this.chartTotalSelling.Text = "chartTotalSelling";
            title4.Name = "Total de Vendas";
            title4.Text = "Total de Vendas";
            this.chartTotalSelling.Titles.Add(title4);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(12, 522);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(882, 48);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Reset";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // SellingStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 582);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.chartTotalSelling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellingStatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatisticas de Vendas";
            this.Load += new System.EventHandler(this.SellingStatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalSelling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalSelling;
        private System.Windows.Forms.Button buttonClear;
    }
}