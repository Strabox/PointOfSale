namespace PointOfSaleUI.Forms
{
    partial class CheckoutForm
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
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button20Euro = new System.Windows.Forms.Button();
            this.button50Euro = new System.Windows.Forms.Button();
            this.button10Euro = new System.Windows.Forms.Button();
            this.button5Euro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTotalMoney = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelChange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(133, 9);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(106, 42);
            this.labelTotalPrice.TabIndex = 0;
            this.labelTotalPrice.Text = "0,0 €";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(110, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            // 
            // button20Euro
            // 
            this.button20Euro.BackgroundImage = global::PointOfSaleUI.Properties.Resources._20euros;
            this.button20Euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20Euro.Location = new System.Drawing.Point(342, 81);
            this.button20Euro.Name = "button20Euro";
            this.button20Euro.Size = new System.Drawing.Size(164, 84);
            this.button20Euro.TabIndex = 5;
            this.button20Euro.UseVisualStyleBackColor = true;
            this.button20Euro.Click += new System.EventHandler(this.button20Euro_Click);
            // 
            // button50Euro
            // 
            this.button50Euro.BackgroundImage = global::PointOfSaleUI.Properties.Resources._50euros;
            this.button50Euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button50Euro.Location = new System.Drawing.Point(507, 81);
            this.button50Euro.Name = "button50Euro";
            this.button50Euro.Size = new System.Drawing.Size(164, 84);
            this.button50Euro.TabIndex = 4;
            this.button50Euro.UseVisualStyleBackColor = true;
            this.button50Euro.Click += new System.EventHandler(this.button50Euro_Click);
            // 
            // button10Euro
            // 
            this.button10Euro.BackgroundImage = global::PointOfSaleUI.Properties.Resources._10euros;
            this.button10Euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10Euro.Location = new System.Drawing.Point(172, 81);
            this.button10Euro.Name = "button10Euro";
            this.button10Euro.Size = new System.Drawing.Size(164, 84);
            this.button10Euro.TabIndex = 3;
            this.button10Euro.UseVisualStyleBackColor = true;
            this.button10Euro.Click += new System.EventHandler(this.button10Euro_Click);
            // 
            // button5Euro
            // 
            this.button5Euro.BackgroundImage = global::PointOfSaleUI.Properties.Resources._5euros;
            this.button5Euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5Euro.Location = new System.Drawing.Point(2, 81);
            this.button5Euro.Name = "button5Euro";
            this.button5Euro.Size = new System.Drawing.Size(164, 84);
            this.button5Euro.TabIndex = 2;
            this.button5Euro.UseVisualStyleBackColor = true;
            this.button5Euro.Click += new System.EventHandler(this.button5Euro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelTotalPrice);
            this.panel1.Location = new System.Drawing.Point(211, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 55);
            this.panel1.TabIndex = 7;
            // 
            // buttonTotalMoney
            // 
            this.buttonTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotalMoney.Location = new System.Drawing.Point(341, 171);
            this.buttonTotalMoney.Name = "buttonTotalMoney";
            this.buttonTotalMoney.Size = new System.Drawing.Size(334, 54);
            this.buttonTotalMoney.TabIndex = 8;
            this.buttonTotalMoney.Text = "Pagar Sem Troco";
            this.buttonTotalMoney.UseVisualStyleBackColor = true;
            this.buttonTotalMoney.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxPayment);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 23);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(361, 52);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "€";
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPayment.Location = new System.Drawing.Point(197, 8);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPayment.Size = new System.Drawing.Size(113, 40);
            this.textBoxPayment.TabIndex = 13;
            this.textBoxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPayment.TextChanged += new System.EventHandler(this.textBoxPayment_TextChanged);
            this.textBoxPayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPayment_KeyDown);
            this.textBoxPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPayment_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagamento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.buttonTotalMoney);
            this.groupBox1.Controls.Add(this.button50Euro);
            this.groupBox1.Controls.Add(this.buttonPay);
            this.groupBox1.Controls.Add(this.button20Euro);
            this.groupBox1.Controls.Add(this.button10Euro);
            this.groupBox1.Controls.Add(this.button5Euro);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 231);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelChange);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(369, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 52);
            this.panel3.TabIndex = 13;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(132, 11);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(87, 33);
            this.labelChange.TabIndex = 13;
            this.labelChange.Text = "--,-- €";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Troco:";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Location = new System.Drawing.Point(2, 170);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(334, 55);
            this.buttonPay.TabIndex = 11;
            this.buttonPay.Text = "Pagar";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(14, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(673, 55);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(695, 377);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckoutForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5Euro;
        private System.Windows.Forms.Button button10Euro;
        private System.Windows.Forms.Button button50Euro;
        private System.Windows.Forms.Button button20Euro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTotalMoney;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Label label5;
    }
}