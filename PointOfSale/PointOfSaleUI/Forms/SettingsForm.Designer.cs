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
            this.tabPageSellableSettings = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewCategoryItems = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEditSelectedItem = new System.Windows.Forms.Button();
            this.labelSelectedItemPrice = new System.Windows.Forms.Label();
            this.textBoxSelectedItemPrice = new System.Windows.Forms.TextBox();
            this.labelSelectedItemName = new System.Windows.Forms.Label();
            this.textBoxSelectedItemName = new System.Windows.Forms.TextBox();
            this.pictureBoxSelectedItem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.contextMenuStripCategoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripItemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPageSellableSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedItem)).BeginInit();
            this.tabControlSettings.SuspendLayout();
            this.contextMenuStripCategoryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageSellableSettings
            // 
            this.tabPageSellableSettings.Controls.Add(this.splitContainer1);
            this.tabPageSellableSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSellableSettings.Name = "tabPageSellableSettings";
            this.tabPageSellableSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSellableSettings.Size = new System.Drawing.Size(771, 608);
            this.tabPageSellableSettings.TabIndex = 1;
            this.tabPageSellableSettings.Text = "Produtos";
            this.tabPageSellableSettings.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewCategoryItems);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelImage);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLoadImage);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEditSelectedItem);
            this.splitContainer1.Panel2.Controls.Add(this.labelSelectedItemPrice);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSelectedItemPrice);
            this.splitContainer1.Panel2.Controls.Add(this.labelSelectedItemName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSelectedItemName);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxSelectedItem);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(765, 602);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewCategoryItems
            // 
            this.treeViewCategoryItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCategoryItems.Location = new System.Drawing.Point(24, 47);
            this.treeViewCategoryItems.Name = "treeViewCategoryItems";
            this.treeViewCategoryItems.Size = new System.Drawing.Size(336, 542);
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
            this.labelImage.Location = new System.Drawing.Point(48, 434);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(93, 25);
            this.labelImage.TabIndex = 9;
            this.labelImage.Text = "Imagem:";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadImage.Location = new System.Drawing.Point(49, 462);
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
            this.label3.Location = new System.Drawing.Point(302, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "€";
            // 
            // buttonEditSelectedItem
            // 
            this.buttonEditSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSelectedItem.Location = new System.Drawing.Point(49, 556);
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
            this.labelSelectedItemPrice.Location = new System.Drawing.Point(48, 377);
            this.labelSelectedItemPrice.Name = "labelSelectedItemPrice";
            this.labelSelectedItemPrice.Size = new System.Drawing.Size(74, 25);
            this.labelSelectedItemPrice.TabIndex = 5;
            this.labelSelectedItemPrice.Text = "Preço:";
            // 
            // textBoxSelectedItemPrice
            // 
            this.textBoxSelectedItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedItemPrice.Location = new System.Drawing.Point(49, 405);
            this.textBoxSelectedItemPrice.Name = "textBoxSelectedItemPrice";
            this.textBoxSelectedItemPrice.Size = new System.Drawing.Size(247, 26);
            this.textBoxSelectedItemPrice.TabIndex = 4;
            this.textBoxSelectedItemPrice.TextChanged += new System.EventHandler(this.textBoxSelectedItemPrice_TextChanged);
            this.textBoxSelectedItemPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSelectedItemPrice_KeyDown);
            this.textBoxSelectedItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSelectedItemPrice_KeyPress);
            // 
            // labelSelectedItemName
            // 
            this.labelSelectedItemName.AutoSize = true;
            this.labelSelectedItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedItemName.Location = new System.Drawing.Point(48, 320);
            this.labelSelectedItemName.Name = "labelSelectedItemName";
            this.labelSelectedItemName.Size = new System.Drawing.Size(74, 25);
            this.labelSelectedItemName.TabIndex = 3;
            this.labelSelectedItemName.Text = "Nome:";
            // 
            // textBoxSelectedItemName
            // 
            this.textBoxSelectedItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedItemName.Location = new System.Drawing.Point(49, 348);
            this.textBoxSelectedItemName.Name = "textBoxSelectedItemName";
            this.textBoxSelectedItemName.Size = new System.Drawing.Size(272, 26);
            this.textBoxSelectedItemName.TabIndex = 2;
            this.textBoxSelectedItemName.TextChanged += new System.EventHandler(this.textBoxSelectedItemName_TextChanged);
            // 
            // pictureBoxSelectedItem
            // 
            this.pictureBoxSelectedItem.Location = new System.Drawing.Point(49, 47);
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
            this.tabControlSettings.Controls.Add(this.tabPageSellableSettings);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Location = new System.Drawing.Point(10, 10);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(779, 634);
            this.tabControlSettings.TabIndex = 0;
            // 
            // contextMenuStripCategoryMenu
            // 
            this.contextMenuStripCategoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.adicionarToolStripMenuItem});
            this.contextMenuStripCategoryMenu.Name = "contextMenuStripCategoryMenu";
            this.contextMenuStripCategoryMenu.Size = new System.Drawing.Size(126, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.removeToolStripMenuItem.Text = "Remover";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // contextMenuStripItemMenu
            // 
            this.contextMenuStripItemMenu.Name = "contextMenuStripItemMenu";
            this.contextMenuStripItemMenu.Size = new System.Drawing.Size(153, 26);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 654);
            this.Controls.Add(this.tabControlSettings);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Definições";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabPageSellableSettings.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedItem)).EndInit();
            this.tabControlSettings.ResumeLayout(false);
            this.contextMenuStripCategoryMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageSellableSettings;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewCategoryItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSelectedItem;
        private System.Windows.Forms.Label labelSelectedItemPrice;
        private System.Windows.Forms.TextBox textBoxSelectedItemPrice;
        private System.Windows.Forms.Label labelSelectedItemName;
        private System.Windows.Forms.TextBox textBoxSelectedItemName;
        private System.Windows.Forms.Button buttonEditSelectedItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCategoryMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItemMenu;
    }
}