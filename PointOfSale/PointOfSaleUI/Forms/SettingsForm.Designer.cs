namespace PointOfSaleUI.Forms
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.tabPageEditSellingItems = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxAddNewCategory = new System.Windows.Forms.GroupBox();
            this.labelNewCategoryName = new System.Windows.Forms.Label();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.treeViewCategoryItems = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEditSelectedItem = new System.Windows.Forms.Button();
            this.labelSelectedItemPrice = new System.Windows.Forms.Label();
            this.labelSelectedItemName = new System.Windows.Forms.Label();
            this.textBoxSelectedItemName = new System.Windows.Forms.TextBox();
            this.pictureBoxSelectedItem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.contextMenuStripCategoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuRemoveCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceTextBoxSelectedItemPrice = new PointOfSaleUI.MyControls.PriceTextBox();
            this.toolStripMenuRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripItemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPageEditSellingItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxAddNewCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedItem)).BeginInit();
            this.tabControlSettings.SuspendLayout();
            this.contextMenuStripCategoryMenu.SuspendLayout();
            this.contextMenuStripItemMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageEditSellingItems
            // 
            this.tabPageEditSellingItems.Controls.Add(this.splitContainer1);
            this.tabPageEditSellingItems.Location = new System.Drawing.Point(4, 29);
            this.tabPageEditSellingItems.Name = "tabPageEditSellingItems";
            this.tabPageEditSellingItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditSellingItems.Size = new System.Drawing.Size(771, 656);
            this.tabPageEditSellingItems.TabIndex = 1;
            this.tabPageEditSellingItems.Text = "Editar Produtos";
            this.tabPageEditSellingItems.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxAddNewCategory);
            this.splitContainer1.Panel1.Controls.Add(this.treeViewCategoryItems);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.priceTextBoxSelectedItemPrice);
            this.splitContainer1.Panel2.Controls.Add(this.labelImage);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLoadImage);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEditSelectedItem);
            this.splitContainer1.Panel2.Controls.Add(this.labelSelectedItemPrice);
            this.splitContainer1.Panel2.Controls.Add(this.labelSelectedItemName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSelectedItemName);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxSelectedItem);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(765, 650);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxAddNewCategory
            // 
            this.groupBoxAddNewCategory.Controls.Add(this.labelNewCategoryName);
            this.groupBoxAddNewCategory.Controls.Add(this.buttonAddCategory);
            this.groupBoxAddNewCategory.Controls.Add(this.textBoxCategoryName);
            this.groupBoxAddNewCategory.Location = new System.Drawing.Point(24, 495);
            this.groupBoxAddNewCategory.Name = "groupBoxAddNewCategory";
            this.groupBoxAddNewCategory.Size = new System.Drawing.Size(336, 142);
            this.groupBoxAddNewCategory.TabIndex = 8;
            this.groupBoxAddNewCategory.TabStop = false;
            this.groupBoxAddNewCategory.Text = "Adicionar Categoria";
            // 
            // labelNewCategoryName
            // 
            this.labelNewCategoryName.AutoSize = true;
            this.labelNewCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCategoryName.Location = new System.Drawing.Point(6, 29);
            this.labelNewCategoryName.Name = "labelNewCategoryName";
            this.labelNewCategoryName.Size = new System.Drawing.Size(203, 25);
            this.labelNewCategoryName.TabIndex = 6;
            this.labelNewCategoryName.Text = "Nome da Categoria:";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(6, 99);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(324, 33);
            this.buttonAddCategory.TabIndex = 5;
            this.buttonAddCategory.Text = "Adicionar Categoria";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(6, 56);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(324, 26);
            this.textBoxCategoryName.TabIndex = 7;
            this.textBoxCategoryName.TextChanged += new System.EventHandler(this.textBoxCategoryName_TextChanged);
            // 
            // treeViewCategoryItems
            // 
            this.treeViewCategoryItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCategoryItems.Location = new System.Drawing.Point(24, 47);
            this.treeViewCategoryItems.Name = "treeViewCategoryItems";
            this.treeViewCategoryItems.Size = new System.Drawing.Size(336, 447);
            this.treeViewCategoryItems.TabIndex = 4;
            this.treeViewCategoryItems.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCategoryItems_NodeMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos Actuais";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.Location = new System.Drawing.Point(44, 47);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(93, 25);
            this.labelImage.TabIndex = 9;
            this.labelImage.Text = "Imagem:";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadImage.Location = new System.Drawing.Point(49, 370);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(272, 32);
            this.buttonLoadImage.TabIndex = 8;
            this.buttonLoadImage.Text = "Carregar Imagem";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "€";
            // 
            // buttonEditSelectedItem
            // 
            this.buttonEditSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSelectedItem.Location = new System.Drawing.Point(49, 592);
            this.buttonEditSelectedItem.Name = "buttonEditSelectedItem";
            this.buttonEditSelectedItem.Size = new System.Drawing.Size(272, 33);
            this.buttonEditSelectedItem.TabIndex = 6;
            this.buttonEditSelectedItem.Text = "Confirmar";
            this.buttonEditSelectedItem.UseVisualStyleBackColor = true;
            this.buttonEditSelectedItem.Click += new System.EventHandler(this.buttonEditSelectedItem_Click);
            // 
            // labelSelectedItemPrice
            // 
            this.labelSelectedItemPrice.AutoSize = true;
            this.labelSelectedItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedItemPrice.Location = new System.Drawing.Point(44, 495);
            this.labelSelectedItemPrice.Name = "labelSelectedItemPrice";
            this.labelSelectedItemPrice.Size = new System.Drawing.Size(74, 25);
            this.labelSelectedItemPrice.TabIndex = 5;
            this.labelSelectedItemPrice.Text = "Preço:";
            // 
            // labelSelectedItemName
            // 
            this.labelSelectedItemName.AutoSize = true;
            this.labelSelectedItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedItemName.Location = new System.Drawing.Point(44, 425);
            this.labelSelectedItemName.Name = "labelSelectedItemName";
            this.labelSelectedItemName.Size = new System.Drawing.Size(74, 25);
            this.labelSelectedItemName.TabIndex = 3;
            this.labelSelectedItemName.Text = "Nome:";
            // 
            // textBoxSelectedItemName
            // 
            this.textBoxSelectedItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedItemName.Location = new System.Drawing.Point(49, 453);
            this.textBoxSelectedItemName.Name = "textBoxSelectedItemName";
            this.textBoxSelectedItemName.Size = new System.Drawing.Size(272, 26);
            this.textBoxSelectedItemName.TabIndex = 2;
            this.textBoxSelectedItemName.TextChanged += new System.EventHandler(this.textBoxSelectedItemName_TextChanged);
            // 
            // pictureBoxSelectedItem
            // 
            this.pictureBoxSelectedItem.Location = new System.Drawing.Point(49, 75);
            this.pictureBoxSelectedItem.Name = "pictureBoxSelectedItem";
            this.pictureBoxSelectedItem.Size = new System.Drawing.Size(272, 270);
            this.pictureBoxSelectedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedItem.TabIndex = 1;
            this.pictureBoxSelectedItem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto Seleccionado";
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageEditSellingItems);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSettings.Location = new System.Drawing.Point(10, 10);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(779, 689);
            this.tabControlSettings.TabIndex = 0;
            // 
            // contextMenuStripCategoryMenu
            // 
            this.contextMenuStripCategoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRemoveCategory,
            this.toolStripMenuAddItem});
            this.contextMenuStripCategoryMenu.Name = "contextMenuStripCategoryMenu";
            this.contextMenuStripCategoryMenu.Size = new System.Drawing.Size(176, 48);
            // 
            // toolStripMenuRemoveCategory
            // 
            this.toolStripMenuRemoveCategory.Name = "toolStripMenuRemoveCategory";
            this.toolStripMenuRemoveCategory.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuRemoveCategory.Text = "Remover Categoria";
            this.toolStripMenuRemoveCategory.Click += new System.EventHandler(this.toolStripMenuRemoveCategory_Click);
            // 
            // toolStripMenuAddItem
            // 
            this.toolStripMenuAddItem.Name = "toolStripMenuAddItem";
            this.toolStripMenuAddItem.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuAddItem.Text = "Adicionar Produto";
            this.toolStripMenuAddItem.Click += new System.EventHandler(this.toolStripMenuAddItem_Click);
            // 
            // priceTextBoxSelectedItemPrice
            // 
            this.priceTextBoxSelectedItemPrice.Location = new System.Drawing.Point(49, 525);
            this.priceTextBoxSelectedItemPrice.Name = "priceTextBoxSelectedItemPrice";
            this.priceTextBoxSelectedItemPrice.Size = new System.Drawing.Size(247, 26);
            this.priceTextBoxSelectedItemPrice.TabIndex = 10;
            this.priceTextBoxSelectedItemPrice.TextChanged += new System.EventHandler(this.textBoxSelectedItemPrice_TextChanged);
            // 
            // toolStripMenuRemoveItem
            // 
            this.toolStripMenuRemoveItem.Name = "toolStripMenuRemoveItem";
            this.toolStripMenuRemoveItem.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuRemoveItem.Text = "Remover Produto";
            this.toolStripMenuRemoveItem.Click += new System.EventHandler(this.toolStripMenuRemoveItem_Click);
            // 
            // contextMenuStripItemMenu
            // 
            this.contextMenuStripItemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRemoveItem});
            this.contextMenuStripItemMenu.Name = "contextMenuStripItemMenu";
            this.contextMenuStripItemMenu.Size = new System.Drawing.Size(168, 48);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 709);
            this.Controls.Add(this.tabControlSettings);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Definições";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabPageEditSellingItems.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxAddNewCategory.ResumeLayout(false);
            this.groupBoxAddNewCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedItem)).EndInit();
            this.tabControlSettings.ResumeLayout(false);
            this.contextMenuStripCategoryMenu.ResumeLayout(false);
            this.contextMenuStripItemMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageEditSellingItems;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewCategoryItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSelectedItem;
        private System.Windows.Forms.Label labelSelectedItemPrice;
        private System.Windows.Forms.Label labelSelectedItemName;
        private System.Windows.Forms.TextBox textBoxSelectedItemName;
        private System.Windows.Forms.Button buttonEditSelectedItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCategoryMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRemoveCategory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAddItem;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label labelNewCategoryName;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.GroupBox groupBoxAddNewCategory;
        private MyControls.PriceTextBox priceTextBoxSelectedItemPrice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRemoveItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItemMenu;
    }
}