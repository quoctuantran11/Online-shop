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
        string strUserName1;
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(string data) : this()
        {
            strUserName1 = data;
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            lbName.Text = strUserName1;
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
            AccountInfo info = new AccountInfo(strUserName1);
            this.Hide();
            info.ShowDialog();
            this.Show();
        }


        private void AccSignout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbName_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass changepass = new ChangePass(strUserName1);
            this.Hide();
            changepass.ShowDialog();
            this.Show();
        }

        private void MyOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(strUserName1);
            this.Hide();
            order.ShowDialog();
            this.Show();
        }
    }
}
