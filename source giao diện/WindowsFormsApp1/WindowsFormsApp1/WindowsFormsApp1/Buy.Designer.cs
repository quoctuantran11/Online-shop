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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.GridViewGood = new System.Windows.Forms.DataGridView();
            this.LowtoHigh = new System.Windows.Forms.CheckBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PickButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
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
            this.TypeLbl = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Findbox
            // 
            this.Findbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Findbox.Location = new System.Drawing.Point(138, 126);
            this.Findbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Findbox.Name = "Findbox";
            this.Findbox.Size = new System.Drawing.Size(213, 26);
            this.Findbox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SearchButton.Location = new System.Drawing.Point(536, 34);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(154, 43);
            this.SearchButton.TabIndex = 4;
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
            this.CartButton.Location = new System.Drawing.Point(722, 33);
            this.CartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(183, 44);
            this.CartButton.TabIndex = 5;
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 72);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(494, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 58);
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
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1222, 36);
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
            this.Account.Size = new System.Drawing.Size(102, 32);
            this.Account.Text = "&Tài khoản";
            // 
            // AccountInfo
            // 
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Size = new System.Drawing.Size(251, 34);
            this.AccountInfo.Text = "Hồ sơ";
            // 
            // AccountDeal
            // 
            this.AccountDeal.Name = "AccountDeal";
            this.AccountDeal.Size = new System.Drawing.Size(251, 34);
            this.AccountDeal.Text = "Đơn hàng của tôi";
            // 
            // AccountLogout
            // 
            this.AccountLogout.Name = "AccountLogout";
            this.AccountLogout.Size = new System.Drawing.Size(251, 34);
            this.AccountLogout.Text = "Đăng xuất";
            // 
            // HightoLow
            // 
            this.HightoLow.AutoSize = true;
            this.HightoLow.Location = new System.Drawing.Point(181, 207);
            this.HightoLow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HightoLow.Name = "HightoLow";
            this.HightoLow.Size = new System.Drawing.Size(144, 24);
            this.HightoLow.TabIndex = 10;
            this.HightoLow.Text = "Giá cao -> thấp";
            this.HightoLow.UseVisualStyleBackColor = true;
            this.HightoLow.CheckedChanged += new System.EventHandler(this.HightoLow_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(363, 207);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Bán chạy";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GridViewGood
            // 
            this.GridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGood.Location = new System.Drawing.Point(13, 243);
            this.GridViewGood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridViewGood.Name = "GridViewGood";
            this.GridViewGood.RowHeadersWidth = 82;
            this.GridViewGood.RowTemplate.Height = 33;
            this.GridViewGood.Size = new System.Drawing.Size(1032, 259);
            this.GridViewGood.TabIndex = 16;
            this.GridViewGood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewGood_CellContentClick);
            // 
            // LowtoHigh
            // 
            this.LowtoHigh.AutoSize = true;
            this.LowtoHigh.Location = new System.Drawing.Point(13, 207);
            this.LowtoHigh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LowtoHigh.Name = "LowtoHigh";
            this.LowtoHigh.Size = new System.Drawing.Size(144, 24);
            this.LowtoHigh.TabIndex = 17;
            this.LowtoHigh.Text = "Giá thấp -> cao";
            this.LowtoHigh.UseVisualStyleBackColor = true;
            this.LowtoHigh.CheckedChanged += new System.EventHandler(this.LowtoHigh_CheckedChanged);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AddButton.Location = new System.Drawing.Point(13, 33);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 45);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ExitButton.Location = new System.Drawing.Point(943, 33);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(102, 44);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PickButton
            // 
            this.PickButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PickButton.Location = new System.Drawing.Point(1059, 270);
            this.PickButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PickButton.Name = "PickButton";
            this.PickButton.Size = new System.Drawing.Size(106, 45);
            this.PickButton.TabIndex = 7;
            this.PickButton.Text = "Chọn";
            this.PickButton.UseVisualStyleBackColor = true;
            this.PickButton.Click += new System.EventHandler(this.PickButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.UpdButton);
            this.panel1.Controls.Add(this.DelButton);
            this.panel1.Controls.Add(this.CartButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 82);
            this.panel1.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SaveButton.Location = new System.Drawing.Point(415, 34);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 44);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdButton
            // 
            this.UpdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UpdButton.Location = new System.Drawing.Point(290, 34);
            this.UpdButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(101, 44);
            this.UpdButton.TabIndex = 2;
            this.UpdButton.Text = "Sửa";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DelButton.Location = new System.Drawing.Point(152, 33);
            this.DelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(110, 44);
            this.DelButton.TabIndex = 1;
            this.DelButton.Text = "Xóa";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // GoodIDLbl
            // 
            this.GoodIDLbl.AutoSize = true;
            this.GoodIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GoodIDLbl.Location = new System.Drawing.Point(9, 90);
            this.GoodIDLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoodIDLbl.Name = "GoodIDLbl";
            this.GoodIDLbl.Size = new System.Drawing.Size(117, 22);
            this.GoodIDLbl.TabIndex = 5;
            this.GoodIDLbl.Text = "Mã sản phẩm";
            // 
            // GoodNameLbl
            // 
            this.GoodNameLbl.AutoSize = true;
            this.GoodNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GoodNameLbl.Location = new System.Drawing.Point(9, 128);
            this.GoodNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoodNameLbl.Name = "GoodNameLbl";
            this.GoodNameLbl.Size = new System.Drawing.Size(125, 22);
            this.GoodNameLbl.TabIndex = 18;
            this.GoodNameLbl.Text = "Tên sản phẩm";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(138, 89);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(212, 26);
            this.IDBox.TabIndex = 0;
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.QuantityLbl.Location = new System.Drawing.Point(9, 162);
            this.QuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(81, 22);
            this.QuantityLbl.TabIndex = 20;
            this.QuantityLbl.Text = "Số lượng";
            // 
            // QuanBox
            // 
            this.QuanBox.Location = new System.Drawing.Point(138, 162);
            this.QuanBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuanBox.Name = "QuanBox";
            this.QuanBox.Size = new System.Drawing.Size(213, 26);
            this.QuanBox.TabIndex = 5;
            // 
            // Pricebox
            // 
            this.Pricebox.Location = new System.Drawing.Point(502, 123);
            this.Pricebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(242, 26);
            this.Pricebox.TabIndex = 4;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(503, 162);
            this.BrandBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(242, 26);
            this.BrandBox.TabIndex = 6;
            // 
            // OriginBox
            // 
            this.OriginBox.Location = new System.Drawing.Point(844, 90);
            this.OriginBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OriginBox.Name = "OriginBox";
            this.OriginBox.Size = new System.Drawing.Size(242, 26);
            this.OriginBox.TabIndex = 2;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PriceLbl.Location = new System.Drawing.Point(368, 123);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(72, 22);
            this.PriceLbl.TabIndex = 25;
            this.PriceLbl.Text = "Đơn giá";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Brand.Location = new System.Drawing.Point(368, 164);
            this.Brand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(111, 22);
            this.Brand.TabIndex = 26;
            this.Brand.Text = "Thương hiệu";
            // 
            // Origin
            // 
            this.Origin.AutoSize = true;
            this.Origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Origin.Location = new System.Drawing.Point(760, 90);
            this.Origin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(71, 22);
            this.Origin.TabIndex = 27;
            this.Origin.Text = "Xuất xứ";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TypeLbl.Location = new System.Drawing.Point(368, 90);
            this.TypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(120, 22);
            this.TypeLbl.TabIndex = 28;
            this.TypeLbl.Text = "Tên loại hàng";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(502, 89);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(242, 26);
            this.TypeBox.TabIndex = 1;
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(1177, 600);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TypeLbl);
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
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.HightoLow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView GridViewGood;
        private System.Windows.Forms.CheckBox LowtoHigh;
        private System.Windows.Forms.Button AddButton;
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
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.TextBox TypeBox;
    }
}