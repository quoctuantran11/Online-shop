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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            Function.Connect(); //Mở kết nối
        }

        private void CateSell_Click(object sender, EventArgs e)
        {
           
        }

        private void MnuSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hotline: 1800100có\nGmail: onlineLogistic@gmail.com");
        }

        private void MnuReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da report den team dev!!");
        }

        private void CateBuy_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            this.Hide();
            buy.ShowDialog();
            this.Show();
        }

        private void AccInfo_Click(object sender, EventArgs e)
        {
            AccountInfo info = new AccountInfo();
            info.ShowDialog();
        }

        private void AccList_Click(object sender, EventArgs e)
        {
            Acc_Cart cart_acc = new Acc_Cart();
            cart_acc.ShowDialog();
        }

        private void AccSignout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
