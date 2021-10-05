namespace WindowsFormsApp1
{
    partial class Cart
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
            this.CartLbl = new System.Windows.Forms.Label();
            this.CusLbl = new System.Windows.Forms.Label();
            this.BillLbl = new System.Windows.Forms.Label();
            this.BillText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.AddrText = new System.Windows.Forms.TextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.DateText = new System.Windows.Forms.TextBox();
            this.MoneyLbl = new System.Windows.Forms.Label();
            this.MoneyText = new System.Windows.Forms.TextBox();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.EmpLbl = new System.Windows.Forms.Label();
            this.CartGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CartGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CartLbl
            // 
            this.CartLbl.AutoSize = true;
            this.CartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.CartLbl.Location = new System.Drawing.Point(12, 162);
            this.CartLbl.Name = "CartLbl";
            this.CartLbl.Size = new System.Drawing.Size(123, 31);
            this.CartLbl.TabIndex = 0;
            this.CartLbl.Text = "Giỏ hàng";
            // 
            // CusLbl
            // 
            this.CusLbl.AutoSize = true;
            this.CusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.CusLbl.Location = new System.Drawing.Point(1042, 25);
            this.CusLbl.Name = "CusLbl";
            this.CusLbl.Size = new System.Drawing.Size(274, 31);
            this.CusLbl.TabIndex = 2;
            this.CusLbl.Text = "Thông tin khách hàng";
            // 
            // BillLbl
            // 
            this.BillLbl.AutoSize = true;
            this.BillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.BillLbl.Location = new System.Drawing.Point(13, 27);
            this.BillLbl.Name = "BillLbl";
            this.BillLbl.Size = new System.Drawing.Size(139, 29);
            this.BillLbl.TabIndex = 3;
            this.BillLbl.Text = "Mã hóa đơn";
            // 
            // BillText
            // 
            this.BillText.Location = new System.Drawing.Point(172, 27);
            this.BillText.Name = "BillText";
            this.BillText.Size = new System.Drawing.Size(212, 31);
            this.BillText.TabIndex = 4;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(1048, 69);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(277, 31);
            this.NameText.TabIndex = 5;
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(1331, 69);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(244, 31);
            this.PhoneText.TabIndex = 6;
            // 
            // AddrText
            // 
            this.AddrText.Location = new System.Drawing.Point(1048, 114);
            this.AddrText.Name = "AddrText";
            this.AddrText.Size = new System.Drawing.Size(526, 31);
            this.AddrText.TabIndex = 7;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.DateLbl.Location = new System.Drawing.Point(13, 69);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(108, 29);
            this.DateLbl.TabIndex = 8;
            this.DateLbl.Text = "Ngày đặt";
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(172, 69);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(407, 31);
            this.DateText.TabIndex = 9;
            // 
            // MoneyLbl
            // 
            this.MoneyLbl.AutoSize = true;
            this.MoneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.MoneyLbl.Location = new System.Drawing.Point(1042, 664);
            this.MoneyLbl.Name = "MoneyLbl";
            this.MoneyLbl.Size = new System.Drawing.Size(127, 31);
            this.MoneyLbl.TabIndex = 10;
            this.MoneyLbl.Text = "Tổng tiền";
            // 
            // MoneyText
            // 
            this.MoneyText.Location = new System.Drawing.Point(1175, 664);
            this.MoneyText.Name = "MoneyText";
            this.MoneyText.Size = new System.Drawing.Size(400, 31);
            this.MoneyText.TabIndex = 11;
            // 
            // cboEmp
            // 
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Location = new System.Drawing.Point(172, 112);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(407, 33);
            this.cboEmp.TabIndex = 12;
            // 
            // EmpLbl
            // 
            this.EmpLbl.AutoSize = true;
            this.EmpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.EmpLbl.Location = new System.Drawing.Point(13, 112);
            this.EmpLbl.Name = "EmpLbl";
            this.EmpLbl.Size = new System.Drawing.Size(153, 29);
            this.EmpLbl.TabIndex = 13;
            this.EmpLbl.Text = "ID Nhân Viên";
            // 
            // CartGV
            // 
            this.CartGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGV.Location = new System.Drawing.Point(22, 218);
            this.CartGV.Name = "CartGV";
            this.CartGV.RowHeadersWidth = 82;
            this.CartGV.RowTemplate.Height = 33;
            this.CartGV.Size = new System.Drawing.Size(840, 476);
            this.CartGV.TabIndex = 14;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 709);
            this.Controls.Add(this.CartGV);
            this.Controls.Add(this.EmpLbl);
            this.Controls.Add(this.cboEmp);
            this.Controls.Add(this.MoneyText);
            this.Controls.Add(this.MoneyLbl);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.AddrText);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.BillText);
            this.Controls.Add(this.BillLbl);
            this.Controls.Add(this.CusLbl);
            this.Controls.Add(this.CartLbl);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CartLbl;
        private System.Windows.Forms.Label CusLbl;
        private System.Windows.Forms.Label BillLbl;
        private System.Windows.Forms.TextBox BillText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.TextBox AddrText;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.Label MoneyLbl;
        private System.Windows.Forms.TextBox MoneyText;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.Label EmpLbl;
        private System.Windows.Forms.DataGridView CartGV;
    }
}