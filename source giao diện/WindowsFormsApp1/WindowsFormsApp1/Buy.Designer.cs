namespace WindowsFormsApp1
{
    partial class Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy));
            this.Findbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Account = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountDeal = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.HightoLow = new System.Windows.Forms.CheckBox();
            this.GridViewGood = new System.Windows.Forms.DataGridView();
            this.LowtoHigh = new System.Windows.Forms.CheckBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PickButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoodIDLbl = new System.Windows.Forms.Label();
            this.GoodNameLbl = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.QuanBox = new System.Windows.Forms.TextBox();
            this.Pricebox = new System.Windows.Forms.TextBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.OriginBox = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Origin = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Findbox
            // 
            this.Findbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Findbox.Location = new System.Drawing.Point(184, 158);
            this.Findbox.Name = "Findbox";
            this.Findbox.Size = new System.Drawing.Size(283, 31);
            this.Findbox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SearchButton.Location = new System.Drawing.Point(17, 34);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(206, 54);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Tìm kiếm";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CartButton
            // 
            this.CartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CartButton.BackgroundImage")));
            this.CartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CartButton.Location = new System.Drawing.Point(496, 34);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(244, 55);
            this.CartButton.TabIndex = 2;
            this.CartButton.Text = "Giỏ hàng";
            this.CartButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1629, 90);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(399, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 76);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hàng hóa";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Account});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1629, 40);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Account
            // 
            this.Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountInfo,
            this.AccountDeal,
            this.AccountLogout});
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(136, 36);
            this.Account.Text = "&Tài khoản";
            // 
            // AccountInfo
            // 
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Size = new System.Drawing.Size(334, 44);
            this.AccountInfo.Text = "Hồ sơ";
            this.AccountInfo.Click += new System.EventHandler(this.AccountInfo_Click);
            // 
            // AccountDeal
            // 
            this.AccountDeal.Name = "AccountDeal";
            this.AccountDeal.Size = new System.Drawing.Size(334, 44);
            this.AccountDeal.Text = "Đơn hàng của tôi";
            this.AccountDeal.Click += new System.EventHandler(this.AccountDeal_Click);
            // 
            // AccountLogout
            // 
            this.AccountLogout.Name = "AccountLogout";
            this.AccountLogout.Size = new System.Drawing.Size(334, 44);
            this.AccountLogout.Text = "Đăng xuất";
            // 
            // HightoLow
            // 
            this.HightoLow.AutoSize = true;
            this.HightoLow.Location = new System.Drawing.Point(241, 259);
            this.HightoLow.Name = "HightoLow";
            this.HightoLow.Size = new System.Drawing.Size(191, 29);
            this.HightoLow.TabIndex = 10;
            this.HightoLow.Text = "Giá cao -> thấp";
            this.HightoLow.UseVisualStyleBackColor = true;
            this.HightoLow.CheckedChanged += new System.EventHandler(this.HightoLow_CheckedChanged);
            // 
            // GridViewGood
            // 
            this.GridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGood.Location = new System.Drawing.Point(17, 304);
            this.GridViewGood.Name = "GridViewGood";
            this.GridViewGood.RowHeadersWidth = 82;
            this.GridViewGood.RowTemplate.Height = 33;
            this.GridViewGood.Size = new System.Drawing.Size(1121, 324);
            this.GridViewGood.TabIndex = 16;
            this.GridViewGood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewGood_CellContentClick);
            // 
            // LowtoHigh
            // 
            this.LowtoHigh.AutoSize = true;
            this.LowtoHigh.Location = new System.Drawing.Point(17, 259);
            this.LowtoHigh.Name = "LowtoHigh";
            this.LowtoHigh.Size = new System.Drawing.Size(191, 29);
            this.LowtoHigh.TabIndex = 17;
            this.LowtoHigh.Text = "Giá thấp -> cao";
            this.LowtoHigh.UseVisualStyleBackColor = true;
            this.LowtoHigh.CheckedChanged += new System.EventHandler(this.LowtoHigh_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ExitButton.Location = new System.Drawing.Point(1002, 34);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(136, 55);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PickButton
            // 
            this.PickButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PickButton.Location = new System.Drawing.Point(1162, 331);
            this.PickButton.Name = "PickButton";
            this.PickButton.Size = new System.Drawing.Size(141, 56);
            this.PickButton.TabIndex = 4;
            this.PickButton.Text = "Chọn";
            this.PickButton.UseVisualStyleBackColor = true;
            this.PickButton.Click += new System.EventHandler(this.PickButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CartButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1639, 102);
            this.panel1.TabIndex = 7;
            // 
            // GoodIDLbl
            // 
            this.GoodIDLbl.AutoSize = true;
            this.GoodIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GoodIDLbl.Location = new System.Drawing.Point(12, 113);
            this.GoodIDLbl.Name = "GoodIDLbl";
            this.GoodIDLbl.Size = new System.Drawing.Size(156, 29);
            this.GoodIDLbl.TabIndex = 5;
            this.GoodIDLbl.Text = "Mã sản phẩm";
            // 
            // GoodNameLbl
            // 
            this.GoodNameLbl.AutoSize = true;
            this.GoodNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GoodNameLbl.Location = new System.Drawing.Point(12, 160);
            this.GoodNameLbl.Name = "GoodNameLbl";
            this.GoodNameLbl.Size = new System.Drawing.Size(166, 29);
            this.GoodNameLbl.TabIndex = 18;
            this.GoodNameLbl.Text = "Tên sản phẩm";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(184, 111);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(282, 31);
            this.IDBox.TabIndex = 19;
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.QuantityLbl.Location = new System.Drawing.Point(12, 203);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(109, 29);
            this.QuantityLbl.TabIndex = 20;
            this.QuantityLbl.Text = "Số lượng";
            // 
            // QuanBox
            // 
            this.QuanBox.Location = new System.Drawing.Point(184, 203);
            this.QuanBox.Name = "QuanBox";
            this.QuanBox.Size = new System.Drawing.Size(283, 31);
            this.QuanBox.TabIndex = 21;
            // 
            // Pricebox
            // 
            this.Pricebox.Location = new System.Drawing.Point(670, 154);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(322, 31);
            this.Pricebox.TabIndex = 22;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(671, 203);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(322, 31);
            this.BrandBox.TabIndex = 23;
            // 
            // OriginBox
            // 
            this.OriginBox.Location = new System.Drawing.Point(671, 109);
            this.OriginBox.Name = "OriginBox";
            this.OriginBox.Size = new System.Drawing.Size(322, 31);
            this.OriginBox.TabIndex = 24;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PriceLbl.Location = new System.Drawing.Point(490, 154);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(96, 29);
            this.PriceLbl.TabIndex = 25;
            this.PriceLbl.Text = "Đơn giá";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Brand.Location = new System.Drawing.Point(490, 205);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(148, 29);
            this.Brand.TabIndex = 26;
            this.Brand.Text = "Thương hiệu";
            // 
            // Origin
            // 
            this.Origin.AutoSize = true;
            this.Origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Origin.Location = new System.Drawing.Point(491, 111);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(92, 29);
            this.Origin.TabIndex = 27;
            this.Origin.Text = "Xuất xứ";
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 707);
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.OriginBox);
            this.Controls.Add(this.PickButton);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.Pricebox);
            this.Controls.Add(this.QuanBox);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.GoodNameLbl);
            this.Controls.Add(this.GoodIDLbl);
            this.Controls.Add(this.Findbox);
            this.Controls.Add(this.LowtoHigh);
            this.Controls.Add(this.GridViewGood);
            this.Controls.Add(this.HightoLow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.Buy_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Findbox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox HightoLow;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Account;
        private System.Windows.Forms.ToolStripMenuItem AccountInfo;
        private System.Windows.Forms.ToolStripMenuItem AccountDeal;
        private System.Windows.Forms.ToolStripMenuItem AccountLogout;
        private System.Windows.Forms.DataGridView GridViewGood;
        private System.Windows.Forms.CheckBox LowtoHigh;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PickButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GoodIDLbl;
        private System.Windows.Forms.Label GoodNameLbl;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.TextBox QuanBox;
        private System.Windows.Forms.TextBox Pricebox;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.TextBox OriginBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Origin;
    }
}