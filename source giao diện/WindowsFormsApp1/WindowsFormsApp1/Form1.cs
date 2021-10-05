using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuanBuy : Form
    {
        public QuanBuy()
        {
            InitializeComponent();
        }

        public int quantity = 0;
        int max = 999;
        public bool fast2 = false, fast24 = false, regl = false, atm = false, cash = false;

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProd_Click(object sender, EventArgs e)
        {
            if(QuanProd.Text != "")
            {
                quantity = Convert.ToInt32(QuanProd.Text);
            }
            if (quantity < 0)
            {
                quantity = 0;
            }
            if (quantity > max)
            {
                quantity = max;
            }
            quantity += 1;
            QuanProd.Text = quantity.ToString();
        }

        private void RemoveProd_Click(object sender, EventArgs e)
        {
            if (QuanProd.Text != "")
            {
                quantity = Convert.ToInt32(QuanProd.Text);
            }
            if (quantity > 0)
            {
                quantity -= 1;
                QuanProd.Text = quantity.ToString();
            }
            if (quantity < 0)
            {
                quantity = 0;
            }
        }

        private void QuanBuy_Load(object sender, EventArgs e)
        {
            QuanProd.Text = "0";

        }


        private void atmbox_CheckedChanged(object sender, EventArgs e)
        {
            if(atmbox.Checked == true)
            {
                cashbox.Checked = false;
                atm = true;
            }
        }

        private void cashbox_CheckedChanged(object sender, EventArgs e)
        {
            if (cashbox.Checked == true)
            {
                atmbox.Checked = false;
                cash = true;
            }
        }

        private void Fast2_CheckedChanged(object sender, EventArgs e)
        {
            if (Fast2.Checked == true)
            {
                Fast24.Checked = false;
                regular.Checked = false;
                fast2 = true;
            }
        }

        private void Fast24_CheckedChanged(object sender, EventArgs e)
        {
            if (Fast24.Checked == true)
            {
                Fast2.Checked = false;
                regular.Checked = false;
                fast24 = true;
            }
        }

        private void regular_CheckedChanged(object sender, EventArgs e)
        {
            if (regular.Checked == true)
            {
                Fast24.Checked = false;
                Fast2.Checked = false;
                regl = true;
            }
        }
    }
}
