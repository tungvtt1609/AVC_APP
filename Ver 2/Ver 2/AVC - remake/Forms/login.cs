using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVC___remake.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            tB_user.Focus();
            tB_pass.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangnhap()
        {
            if (tB_user.Text.Length == 0 && tB_pass.Text.Length == 0)
                MessageBox.Show("Ban chua dang nhap tai khoan");
            else
                if (tB_pass.Text.Length == 0)
                MessageBox.Show("Ban chua dang nhap mat khau");
            else
                    if (tB_user.Text.Length == 0)
                MessageBox.Show("Ban chua dang nhap user");
            else
                    if (this.tB_user.Text == "Anhtung1234" && this.tB_pass.Text == "123456")
                MessageBox.Show("Dang nhap thanh cong");
            else
                MessageBox.Show("Dang nhap khong thanh cong");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main main1 = new Main();
            if (this.tB_user.Text == "Anhtung1234" && this.tB_pass.Text == "123456")
            {
                main1.Show();
            }
            dangnhap();
        }
    }
}
