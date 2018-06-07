using System;

namespace ConsignmentShop
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.StoreItem = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.ShoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.buttonSaveToXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(309, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(268, 24);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Комиссиционный магазин";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(38, 140);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(307, 164);
            this.ItemsListBox.TabIndex = 1;
            // 
            // StoreItem
            // 
            this.StoreItem.AutoSize = true;
            this.StoreItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreItem.Location = new System.Drawing.Point(33, 112);
            this.StoreItem.Name = "StoreItem";
            this.StoreItem.Size = new System.Drawing.Size(140, 20);
            this.StoreItem.TabIndex = 2;
            this.StoreItem.Text = "Товары магазина";
            // 
            // AddToCart
            // 
            this.AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCart.Location = new System.Drawing.Point(365, 201);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(127, 69);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Добавить в корзину";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // ShoppingCartListboxLabel
            // 
            this.ShoppingCartListboxLabel.AutoSize = true;
            this.ShoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListboxLabel.Location = new System.Drawing.Point(612, 112);
            this.ShoppingCartListboxLabel.Name = "ShoppingCartListboxLabel";
            this.ShoppingCartListboxLabel.Size = new System.Drawing.Size(72, 20);
            this.ShoppingCartListboxLabel.TabIndex = 5;
            this.ShoppingCartListboxLabel.Text = "Корзина";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 20;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(512, 140);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(298, 164);
            this.ShoppingCartListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(591, 322);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(139, 51);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Покупка";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.Location = new System.Drawing.Point(33, 322);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(104, 20);
            this.vendorListboxLabel.TabIndex = 8;
            this.vendorListboxLabel.Text = "Поставщики";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 20;
            this.vendorListBox.Location = new System.Drawing.Point(38, 350);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(307, 164);
            this.vendorListBox.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(449, 421);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(157, 20);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Прибыль магазина:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(657, 421);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(49, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "0.00₽";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(38, 50);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(123, 39);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(340, 50);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(112, 40);
            this.DelBtn.TabIndex = 12;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(191, 50);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(123, 39);
            this.EditBtn.TabIndex = 13;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // buttonSaveToXML
            // 
            this.buttonSaveToXML.Location = new System.Drawing.Point(465, 49);
            this.buttonSaveToXML.Name = "buttonSaveToXML";
            this.buttonSaveToXML.Size = new System.Drawing.Size(391, 40);
            this.buttonSaveToXML.TabIndex = 14;
            this.buttonSaveToXML.Text = "Сохранить магазин в XML";
            this.buttonSaveToXML.UseVisualStyleBackColor = true;
            this.buttonSaveToXML.Click += new System.EventHandler(this.buttonSaveToXML_Click);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(868, 540);
            this.Controls.Add(this.buttonSaveToXML);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.ShoppingCartListboxLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.StoreItem);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Комиссиционный магазин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label headerText;
        public System.Windows.Forms.ListBox ItemsListBox;
        public System.Windows.Forms.Label StoreItem;
        public System.Windows.Forms.Button AddToCart;
        public System.Windows.Forms.Label ShoppingCartListboxLabel;
        public System.Windows.Forms.ListBox ShoppingCartListBox;
        public System.Windows.Forms.Button makePurchase;
        public System.Windows.Forms.Label vendorListboxLabel;
        public System.Windows.Forms.ListBox vendorListBox;
        public System.Windows.Forms.Label storeProfitLabel;
        public System.Windows.Forms.Label storeProfitValue;
        public System.Windows.Forms.Button AddBtn;
        public System.Windows.Forms.Button DelBtn;
        public System.Windows.Forms.Button EditBtn;
        public System.Windows.Forms.Button buttonSaveToXML;

        public EventHandler StoreItem_Click { get;  set; }
        public EventHandler ConsignmentShop_Load { get; set; }
    }
}

