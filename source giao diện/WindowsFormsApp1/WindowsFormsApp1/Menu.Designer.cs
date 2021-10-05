namespace WindowsFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuCate = new System.Windows.Forms.ToolStripMenuItem();
            this.CateSell = new System.Windows.Forms.ToolStripMenuItem();
            this.CateBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.CateAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.AccInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.AccSignout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.lbName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCate,
            this.MnuReport,
            this.MnuSupport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1221, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MnuCate
            // 
            this.MnuCate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CateSell,
            this.CateBuy,
            this.CateAcc});
            this.MnuCate.Name = "MnuCate";
            this.MnuCate.Size = new System.Drawing.Size(109, 29);
            this.MnuCate.Text = "&Danh mục";
            // 
            // CateSell
            // 
            this.CateSell.Name = "CateSell";
            this.CateSell.Size = new System.Drawing.Size(270, 34);
            this.CateSell.Text = "Bán hàng";
            this.CateSell.Click += new System.EventHandler(this.CateSell_Click);
            // 
            // CateBuy
            // 
            this.CateBuy.Name = "CateBuy";
            this.CateBuy.Size = new System.Drawing.Size(270, 34);
            this.CateBuy.Text = "Mua hàng";
            this.CateBuy.Click += new System.EventHandler(this.CateBuy_Click);
            // 
            // CateAcc
            // 
            this.CateAcc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccInfo,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.MyOrder,
            this.AccSignout});
            this.CateAcc.Name = "CateAcc";
            this.CateAcc.Size = new System.Drawing.Size(270, 34);
            this.CateAcc.Text = "Tài khoản";
            // 
            // AccInfo
            // 
            this.AccInfo.Name = "AccInfo";
            this.AccInfo.Size = new System.Drawing.Size(270, 34);
            this.AccInfo.Text = "Hồ sơ";
            this.AccInfo.Click += new System.EventHandler(this.AccInfo_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // MyOrder
            // 
            this.MyOrder.Name = "MyOrder";
            this.MyOrder.Size = new System.Drawing.Size(270, 34);
            this.MyOrder.Text = "Đơn hàng của tôi";
            this.MyOrder.Click += new System.EventHandler(this.MyOrder_Click);
            // 
            // AccSignout
            // 
            this.AccSignout.Name = "AccSignout";
            this.AccSignout.Size = new System.Drawing.Size(270, 34);
            this.AccSignout.Text = "Đăng xuất";
            this.AccSignout.Click += new System.EventHandler(this.AccSignout_Click);
            // 
            // MnuReport
            // 
            this.MnuReport.Name = "MnuReport";
            this.MnuReport.Size = new System.Drawing.Size(91, 29);
            this.MnuReport.Text = "&Báo cáo";
            this.MnuReport.Click += new System.EventHandler(this.MnuReport_Click);
            // 
            // MnuSupport
            // 
            this.MnuSupport.Name = "MnuSupport";
            this.MnuSupport.Size = new System.Drawing.Size(80, 29);
            this.MnuSupport.Text = "&Hỗ trợ";
            this.MnuSupport.Click += new System.EventHandler(this.MnuSupport_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(1158, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "label1";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 566);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Chương trình bán hàng online";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuCate;
        private System.Windows.Forms.ToolStripMenuItem CateSell;
        private System.Windows.Forms.ToolStripMenuItem CateBuy;
        private System.Windows.Forms.ToolStripMenuItem CateAcc;
        private System.Windows.Forms.ToolStripMenuItem AccInfo;
        private System.Windows.Forms.ToolStripMenuItem AccSignout;
        private System.Windows.Forms.ToolStripMenuItem MnuReport;
        private System.Windows.Forms.ToolStripMenuItem MnuSupport;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyOrder;
    }
}