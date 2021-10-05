namespace WindowsFormsApp1
{
    partial class QuanBuy
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
            this.QuanProd = new System.Windows.Forms.TextBox();
            this.RemoveProd = new System.Windows.Forms.Button();
            this.AddProd = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Fast24 = new System.Windows.Forms.CheckBox();
            this.Fast2 = new System.Windows.Forms.CheckBox();
            this.regular = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.atmbox = new System.Windows.Forms.CheckBox();
            this.cashbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // QuanProd
            // 
            this.QuanProd.Location = new System.Drawing.Point(159, 25);
            this.QuanProd.Name = "QuanProd";
            this.QuanProd.Size = new System.Drawing.Size(171, 31);
            this.QuanProd.TabIndex = 0;
            this.QuanProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemoveProd
            // 
            this.RemoveProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RemoveProd.Location = new System.Drawing.Point(336, 17);
            this.RemoveProd.Name = "RemoveProd";
            this.RemoveProd.Size = new System.Drawing.Size(60, 43);
            this.RemoveProd.TabIndex = 1;
            this.RemoveProd.Text = "-";
            this.RemoveProd.UseVisualStyleBackColor = true;
            this.RemoveProd.Click += new System.EventHandler(this.RemoveProd_Click);
            // 
            // AddProd
            // 
            this.AddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AddProd.Location = new System.Drawing.Point(89, 17);
            this.AddProd.Name = "AddProd";
            this.AddProd.Size = new System.Drawing.Size(64, 40);
            this.AddProd.TabIndex = 2;
            this.AddProd.Text = "+";
            this.AddProd.UseVisualStyleBackColor = true;
            this.AddProd.Click += new System.EventHandler(this.AddProd_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OKbutton.Location = new System.Drawing.Point(159, 367);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(171, 47);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(140, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vận chuyển";
            // 
            // Fast24
            // 
            this.Fast24.AutoSize = true;
            this.Fast24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Fast24.Location = new System.Drawing.Point(170, 149);
            this.Fast24.Name = "Fast24";
            this.Fast24.Size = new System.Drawing.Size(160, 33);
            this.Fast24.TabIndex = 5;
            this.Fast24.Text = "Nhanh 24h";
            this.Fast24.UseVisualStyleBackColor = true;
            this.Fast24.CheckedChanged += new System.EventHandler(this.Fast24_CheckedChanged);
            // 
            // Fast2
            // 
            this.Fast2.AutoSize = true;
            this.Fast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Fast2.Location = new System.Drawing.Point(12, 149);
            this.Fast2.Name = "Fast2";
            this.Fast2.Size = new System.Drawing.Size(147, 33);
            this.Fast2.TabIndex = 6;
            this.Fast2.Text = "Nhanh 2h";
            this.Fast2.UseVisualStyleBackColor = true;
            this.Fast2.CheckedChanged += new System.EventHandler(this.Fast2_CheckedChanged);
            // 
            // regular
            // 
            this.regular.AutoSize = true;
            this.regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.regular.Location = new System.Drawing.Point(349, 149);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(164, 33);
            this.regular.TabIndex = 7;
            this.regular.Text = "Tiêu chuẩn";
            this.regular.UseVisualStyleBackColor = true;
            this.regular.CheckedChanged += new System.EventHandler(this.regular_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(140, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thanh toán";
            // 
            // atmbox
            // 
            this.atmbox.AutoSize = true;
            this.atmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.atmbox.Location = new System.Drawing.Point(104, 271);
            this.atmbox.Name = "atmbox";
            this.atmbox.Size = new System.Drawing.Size(96, 33);
            this.atmbox.TabIndex = 9;
            this.atmbox.Text = "ATM";
            this.atmbox.UseVisualStyleBackColor = true;
            this.atmbox.CheckedChanged += new System.EventHandler(this.atmbox_CheckedChanged);
            // 
            // cashbox
            // 
            this.cashbox.AutoSize = true;
            this.cashbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cashbox.Location = new System.Drawing.Point(294, 271);
            this.cashbox.Name = "cashbox";
            this.cashbox.Size = new System.Drawing.Size(139, 33);
            this.cashbox.TabIndex = 10;
            this.cashbox.Text = "Tiền mặt";
            this.cashbox.UseVisualStyleBackColor = true;
            this.cashbox.CheckedChanged += new System.EventHandler(this.cashbox_CheckedChanged);
            // 
            // QuanBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 440);
            this.Controls.Add(this.cashbox);
            this.Controls.Add(this.atmbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.Fast2);
            this.Controls.Add(this.Fast24);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.AddProd);
            this.Controls.Add(this.RemoveProd);
            this.Controls.Add(this.QuanProd);
            this.Name = "QuanBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SL Mua";
            this.Load += new System.EventHandler(this.QuanBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuanProd;
        private System.Windows.Forms.Button RemoveProd;
        private System.Windows.Forms.Button AddProd;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Fast24;
        private System.Windows.Forms.CheckBox Fast2;
        private System.Windows.Forms.CheckBox regular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox atmbox;
        private System.Windows.Forms.CheckBox cashbox;
    }
}