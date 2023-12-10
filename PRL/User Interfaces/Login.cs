using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.User_Interfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtTK.Padding = new Padding(3, 3, 3, 3);
            txtMK.Padding = new Padding(3, 3, 3, 3);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginFun();
        }

        private void LoginFun()
        {
            if (txtTK.Text.Length == 0 && txtMK.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống!", "Cảnh báo");
            }
            else if (txtTK.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản không được bỏ trống!", "Cảnh báo");
            }
            else if (txtMK.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Cảnh báo");
            }
            else
            {
                if (txtTK.Text == "admin" && txtMK.Text == "admin")
                {
                    this.Hide();
                    HoaDon f2 = new HoaDon();
                    f2.ShowDialog();
                    this.Close();
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Tài khoản không đúng");
                }
            }
        }
        private bool isPasswordVisible = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMK.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }


        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoginFun();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
