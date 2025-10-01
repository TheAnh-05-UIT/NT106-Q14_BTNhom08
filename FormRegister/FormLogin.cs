using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegister
{
    public partial class frm_FormLogin : Form
    {
        public frm_FormLogin()
        {
            InitializeComponent();
        }

        private void lklbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_FormRegister formRegister = new frm_FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        // ma hoa password
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2")); // chuyển byte sang hex
                }
                return builder.ToString();
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM GIAOVIEN WHERE username=@user AND password=@pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txt_Username.Text);
                    cmd.Parameters.AddWithValue("@pass", HashPassword(txt_Password.Text));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Đăng nhập thành công!",
                            "Confirm",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        // mở form chính
                        frm_FormMain main = new frm_FormMain();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void chk_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked == false)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
