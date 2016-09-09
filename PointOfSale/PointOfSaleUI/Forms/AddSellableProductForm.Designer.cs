namespace PointOfSaleUI.Forms
{
    partial class AddSellableProductForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxItemImage = new System.Windows.Forms.PictureBox();
            this.labelItemImage = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.buttonAddISellingItem = new System.Windows.Forms.Button();
            this.priceTextBoxItemPrice = new PointOfSaleUI.MyControls.PriceTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(99, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Adicionar produto";
            // 
            // pictureBoxItemImage
            // 
            this.pictureBoxItemImage.Location = new System.Drawing.Point(88, 86);
            this.pictureBoxItemImage.Name = "pictureBoxItemImage";
            this.pictureBoxItemImage.Size = new System.Drawing.Size(268, 243);
            this.pictureBoxItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItemImage.TabIndex = 1;
            this.pictureBoxItemImage.TabStop = false;
            // 
            // labelItemImage
            // 
            this.labelItemImage.AutoSize = true;
            this.labelItemImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemImage.Location = new System.Drawing.Point(83, 58);
            this.labelItemImage.Name = "labelItemImage";
            this.labelItemImage.Size = new System.Drawing.Size(93, 25);
            this.labelItemImage.TabIndex = 2;
            this.labelItemImage.Text = "Imagem:";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(88, 335);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(268, 29);
            this.buttonLoadImage.TabIndex = 3;
            this.buttonLoadImage.Text = "Carregar Imagem";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(83, 367);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(74, 25);
            this.labelItemName.TabIndex = 4;
            this.labelItemName.Text = "Nome:";
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.Location = new System.Drawing.Point(83, 433);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(74, 25);
            this.labelItemPrice.TabIndex = 5;
            this.labelItemPrice.Text = "Preço:";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemName.Location = new System.Drawing.Point(88, 395);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(268, 31);
            this.textBoxItemName.TabIndex = 6;
            // 
            // buttonAddISellingItem
            // 
            this.buttonAddISellingItem.Location = new System.Drawing.Point(88, 511);
            this.buttonAddISellingItem.Name = "buttonAddISellingItem";
            this.buttonAddISellingItem.Size = new System.Drawing.Size(268, 27);
            this.buttonAddISellingItem.TabIndex = 8;
            this.buttonAddISellingItem.Text = "Adicionar Produto";
            this.buttonAddISellingItem.UseVisualStyleBackColor = true;
            this.buttonAddISellingItem.Click += new System.EventHandler(this.buttonAddISellingItem_Click);
            // 
            // priceTextBoxItemPrice
            // 
            this.priceTextBoxItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBoxItemPrice.Location = new System.Drawing.Point(88, 461);
            this.priceTextBoxItemPrice.Name = "priceTextBoxItemPrice";
            this.priceTextBoxItemPrice.Size = new System.Drawing.Size(268, 31);
            this.priceTextBoxItemPrice.TabIndex = 9;
            // 
            // AddSellingItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 541);
            this.Controls.Add(this.priceTextBoxItemPrice);
            this.Controls.Add(this.buttonAddISellingItem);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelItemPrice);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.labelItemImage);
            this.Controls.Add(this.pictureBoxItemImage);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSellingItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSellingItemForm_FormClosing);
            this.Load += new System.EventHandler(this.AddSellingItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxItemImage;
        private System.Windows.Forms.Label labelItemImage;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Button buttonAddISellingItem;
        private MyControls.PriceTextBox priceTextBoxItemPrice;
    }
}