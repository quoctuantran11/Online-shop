namespace WindowsFormsApp1
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.GridViewGood = new System.Windows.Forms.DataGridView();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.GoodIDLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Origin = new System.Windows.Forms.Label();
            this.OriginBox = new System.Windows.Forms.TextBox();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.GoodNameLbl = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.Pricebox = new System.Windows.Forms.TextBox();
            this.QuanBox = new System.Windows.Forms.TextBox();
            this.Findbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.UpdBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGood)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewGood
            // 
            this.GridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGood.Location = new System.Drawing.Point(22, 279);
            this.GridViewGood.Name = "GridViewGood";
            this.GridViewGood.RowHeadersWidth = 82;
            this.GridViewGood.RowTemplate.Height = 33;
            this.GridViewGood.Size = new System.Drawing.Size(1413, 324);
            this.GridViewGood.TabIndex = 17;
            this.GridViewGood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewGood_CellContentClick);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(202, 105);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(282, 31);
            this.IDBox.TabIndex = 21;
            // 
            // GoodIDLbl
            // 
            this.GoodIDLbl.AutoSize = true;
            this.GoodIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GoodIDLbl.Location = new System.Drawing.Point(30, 107);
            this.GoodIDLbl.Name = "GoodIDLbl";
            this.GoodIDLbl.Size = new System.Drawing.Size(156, 29);
            this.GoodIDLbl.TabIndex = 20;
            this.GoodIDLbl.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(646, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 76);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hàng hóa";
            // 
            // Origin
            // 
            this.Origin.AutoSize = true;
            this.Origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Origin.Location = new System.Drawing.Point(1006, 103);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(92, 29);
            this.Origin.TabIndex = 29;
            this.Origin.Text = "Xuất xứ";
            // 
            // OriginBox
            // 
            this.OriginBox.Location = new System.Drawing.Point(1113, 105);
            this.OriginBox.Name = "OriginBox";
            this.OriginBox.Size = new System.Drawing.Size(322, 31);
            this.OriginBox.TabIndex = 28;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TypeLbl.Location = new System.Drawing.Point(509, 105);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(160, 29);
            this.TypeLbl.TabIndex = 35;
            this.TypeLbl.Text = "Tên loại hàng";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Brand.Location = new System.Drawing.Point(509, 197);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(148, 29);
            this.Brand.TabIndex = 34;
            this.Brand.Text = "Thương hiệu";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PriceLbl.Location = new System.Drawing.Point(509, 146);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(96, 29);
            this.PriceLbl.TabIndex = 33;
            this.PriceLbl.Text = "Đơn giá";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.QuantityLbl.Location = new System.Drawing.Point(30, 197);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(109, 29);
            this.QuantityLbl.TabIndex = 32;
            this.QuantityLbl.Text = "Số lượng";
            // 
            // GoodNameLbl
            // 
            this.GoodNameLbl.AutoSize = true;
            this.GoodNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GoodNameLbl.Location = new System.Drawing.Point(30, 154);
            this.GoodNameLbl.Name = "GoodNameLbl";
            this.GoodNameLbl.Size = new System.Drawing.Size(166, 29);
            this.GoodNameLbl.TabIndex = 31;
            this.GoodNameLbl.Text = "Tên sản phẩm";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(672, 105);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(322, 31);
            this.TypeBox.TabIndex = 38;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(673, 197);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(322, 31);
            this.BrandBox.TabIndex = 37;
            // 
            // Pricebox
            // 
            this.Pricebox.Location = new System.Drawing.Point(672, 148);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(322, 31);
            this.Pricebox.TabIndex = 36;
            // 
            // QuanBox
            // 
            this.QuanBox.Location = new System.Drawing.Point(201, 199);
            this.QuanBox.Name = "QuanBox";
            this.QuanBox.Size = new System.Drawing.Size(283, 31);
            this.QuanBox.TabIndex = 40;
            // 
            // Findbox
            // 
            this.Findbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Findbox.Location = new System.Drawing.Point(201, 154);
            this.Findbox.Name = "Findbox";
            this.Findbox.Size = new System.Drawing.Size(283, 31);
            this.Findbox.TabIndex = 39;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SearchButton.Location = new System.Drawing.Point(990, 630);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(206, 51);
            this.SearchButton.TabIndex = 41;
            this.SearchButton.Text = "Tìm kiếm";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ExitButton.Location = new System.Drawing.Point(1299, 628);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(136, 55);
            this.ExitButton.TabIndex = 42;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AddBtn.Location = new System.Drawing.Point(22, 628);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(161, 51);
            this.AddBtn.TabIndex = 43;
            this.AddBtn.Text = "Thêm";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DelBtn.Location = new System.Drawing.Point(248, 631);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(175, 50);
            this.DelBtn.TabIndex = 44;
            this.DelBtn.Text = "Xóa";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // UpdBtn
            // 
            this.UpdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UpdBtn.Location = new System.Drawing.Point(489, 631);
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(168, 52);
            this.UpdBtn.TabIndex = 45;
            this.UpdBtn.Text = "Sửa";
            this.UpdBtn.UseVisualStyleBackColor = true;
            this.UpdBtn.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SaveBtn.Location = new System.Drawing.Point(727, 631);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(164, 52);
            this.SaveBtn.TabIndex = 46;
            this.SaveBtn.Text = "Lưu";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 710);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.UpdBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.QuanBox);
            this.Controls.Add(this.Findbox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.Pricebox);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.GoodNameLbl);
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.OriginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.GoodIDLbl);
            this.Controls.Add(this.GridViewGood);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewGood;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label GoodIDLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Origin;
        private System.Windows.Forms.TextBox OriginBox;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label GoodNameLbl;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.TextBox Pricebox;
        private System.Windows.Forms.TextBox QuanBox;
        private System.Windows.Forms.TextBox Findbox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button UpdBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}