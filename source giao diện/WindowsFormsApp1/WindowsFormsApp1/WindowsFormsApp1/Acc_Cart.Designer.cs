namespace WindowsFormsApp1
{
    partial class Acc_Cart
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
            this.BillText = new System.Windows.Forms.TextBox();
            this.BillLbl = new System.Windows.Forms.Label();
            this.DateText = new System.Windows.Forms.TextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.AddrText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.CusLbl = new System.Windows.Forms.Label();
            this.TransportLbl = new System.Windows.Forms.Label();
            this.TransportBox = new System.Windows.Forms.TextBox();
            this.FeeBox = new System.Windows.Forms.TextBox();
            this.PayLbl = new System.Windows.Forms.Label();
            this.PayBox = new System.Windows.Forms.TextBox();
            this.Gooddgv = new System.Windows.Forms.DataGridView();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.CondBillLbl = new System.Windows.Forms.Label();
            this.CondBox = new System.Windows.Forms.TextBox();
            this.FeeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gooddgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BillText
            // 
            this.BillText.Location = new System.Drawing.Point(147, 9);
            this.BillText.Name = "BillText";
            this.BillText.Size = new System.Drawing.Size(212, 31);
            this.BillText.TabIndex = 11;
            // 
            // BillLbl
            // 
            this.BillLbl.AutoSize = true;
            this.BillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.BillLbl.Location = new System.Drawing.Point(2, 9);
            this.BillLbl.Name = "BillLbl";
            this.BillLbl.Size = new System.Drawing.Size(139, 29);
            this.BillLbl.TabIndex = 10;
            this.BillLbl.Text = "Mã hóa đơn";
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(1215, 7);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(407, 31);
            this.DateText.TabIndex = 13;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.DateLbl.Location = new System.Drawing.Point(1101, 7);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(108, 29);
            this.DateLbl.TabIndex = 12;
            this.DateLbl.Text = "Ngày đặt";
            // 
            // AddrText
            // 
            this.AddrText.Location = new System.Drawing.Point(7, 180);
            this.AddrText.Name = "AddrText";
            this.AddrText.Size = new System.Drawing.Size(526, 31);
            this.AddrText.TabIndex = 17;
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(290, 135);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(244, 31);
            this.PhoneText.TabIndex = 16;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(7, 135);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(277, 31);
            this.NameText.TabIndex = 15;
            // 
            // CusLbl
            // 
            this.CusLbl.AutoSize = true;
            this.CusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.CusLbl.Location = new System.Drawing.Point(1, 91);
            this.CusLbl.Name = "CusLbl";
            this.CusLbl.Size = new System.Drawing.Size(274, 31);
            this.CusLbl.TabIndex = 14;
            this.CusLbl.Text = "Thông tin khách hàng";
            // 
            // TransportLbl
            // 
            this.TransportLbl.AutoSize = true;
            this.TransportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.TransportLbl.Location = new System.Drawing.Point(688, 91);
            this.TransportLbl.Name = "TransportLbl";
            this.TransportLbl.Size = new System.Drawing.Size(254, 31);
            this.TransportLbl.TabIndex = 18;
            this.TransportLbl.Text = "Hình thức giao hàng";
            // 
            // TransportBox
            // 
            this.TransportBox.Location = new System.Drawing.Point(694, 135);
            this.TransportBox.Name = "TransportBox";
            this.TransportBox.Size = new System.Drawing.Size(258, 31);
            this.TransportBox.TabIndex = 19;
            // 
            // FeeBox
            // 
            this.FeeBox.Location = new System.Drawing.Point(694, 221);
            this.FeeBox.Name = "FeeBox";
            this.FeeBox.Size = new System.Drawing.Size(258, 31);
            this.FeeBox.TabIndex = 20;
            // 
            // PayLbl
            // 
            this.PayLbl.AutoSize = true;
            this.PayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.PayLbl.Location = new System.Drawing.Point(1101, 91);
            this.PayLbl.Name = "PayLbl";
            this.PayLbl.Size = new System.Drawing.Size(264, 31);
            this.PayLbl.TabIndex = 21;
            this.PayLbl.Text = "Hình thức thanh toán";
            // 
            // PayBox
            // 
            this.PayBox.Location = new System.Drawing.Point(1106, 135);
            this.PayBox.Name = "PayBox";
            this.PayBox.Size = new System.Drawing.Size(269, 31);
            this.PayBox.TabIndex = 22;
            // 
            // Gooddgv
            // 
            this.Gooddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gooddgv.Location = new System.Drawing.Point(12, 279);
            this.Gooddgv.Name = "Gooddgv";
            this.Gooddgv.RowHeadersWidth = 82;
            this.Gooddgv.RowTemplate.Height = 33;
            this.Gooddgv.Size = new System.Drawing.Size(1600, 367);
            this.Gooddgv.TabIndex = 23;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.TotalLbl.Location = new System.Drawing.Point(1102, 669);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(129, 29);
            this.TotalLbl.TabIndex = 24;
            this.TotalLbl.Text = "Tổng cộng";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(1237, 669);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(374, 31);
            this.TotalBox.TabIndex = 25;
            // 
            // CondBillLbl
            // 
            this.CondBillLbl.AutoSize = true;
            this.CondBillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.CondBillLbl.Location = new System.Drawing.Point(397, 9);
            this.CondBillLbl.Name = "CondBillLbl";
            this.CondBillLbl.Size = new System.Drawing.Size(168, 29);
            this.CondBillLbl.TabIndex = 26;
            this.CondBillLbl.Text = "Tình trạng đơn";
            // 
            // CondBox
            // 
            this.CondBox.Location = new System.Drawing.Point(571, 9);
            this.CondBox.Name = "CondBox";
            this.CondBox.Size = new System.Drawing.Size(131, 31);
            this.CondBox.TabIndex = 27;
            // 
            // FeeLbl
            // 
            this.FeeLbl.AutoSize = true;
            this.FeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.FeeLbl.Location = new System.Drawing.Point(688, 178);
            this.FeeLbl.Name = "FeeLbl";
            this.FeeLbl.Size = new System.Drawing.Size(199, 31);
            this.FeeLbl.TabIndex = 28;
            this.FeeLbl.Text = "Phí vận chuyển";
            // 
            // Acc_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 707);
            this.Controls.Add(this.FeeLbl);
            this.Controls.Add(this.CondBox);
            this.Controls.Add(this.CondBillLbl);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.Gooddgv);
            this.Controls.Add(this.PayBox);
            this.Controls.Add(this.PayLbl);
            this.Controls.Add(this.FeeBox);
            this.Controls.Add(this.TransportBox);
            this.Controls.Add(this.TransportLbl);
            this.Controls.Add(this.AddrText);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.CusLbl);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.BillText);
            this.Controls.Add(this.BillLbl);
            this.Name = "Acc_Cart";
            this.Text = "Acc_Cart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Acc_Cart_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Gooddgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BillText;
        private System.Windows.Forms.Label BillLbl;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.TextBox AddrText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label CusLbl;
        private System.Windows.Forms.Label TransportLbl;
        private System.Windows.Forms.TextBox TransportBox;
        private System.Windows.Forms.TextBox FeeBox;
        private System.Windows.Forms.Label PayLbl;
        private System.Windows.Forms.TextBox PayBox;
        private System.Windows.Forms.DataGridView Gooddgv;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label CondBillLbl;
        private System.Windows.Forms.TextBox CondBox;
        private System.Windows.Forms.Label FeeLbl;
    }
}