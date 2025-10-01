using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FormRegister
{
    public partial class frm_FormRegister : Form
    {
        public frm_FormRegister()
        {
            InitializeComponent();
        }
        //private string connectionString =
        //    ConfigurationManager.ConnectionStrings["UserDatabase"].ConnectionString;
        private string connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDatabase.mdf;Integrated Security=False";


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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            { 
                try
                {
                    conn.Open();
                    string query = "INSERT INTO GIAOVIEN (Username, Password, Email, Phone) VALUES (@user, @pass,@email,@phone)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txt_Username.Text);
                    cmd.Parameters.AddWithValue("@pass", HashPassword(txt_Password.Text));
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);

                    if (lbl_CheckName.Visible == false &&
                       lbl_CheckUsername.Visible == false &&
                       lbl_CheckEmail.Visible == false &&
                       lbl_CheckPassword.Visible == false &&
                       lbl_CheckConfirmPassword.Visible == false &&
                       txt_Name.Text.Length != 0 &&
                       txt_Username.Text.Length != 0 &&
                       txt_Email.Text.Length != 0 &&
                       txt_Password.Text.Length != 0 &&
                       txt_ConfirmPassword.Text.Length != 0
                       )
                    {
                        cmd.ExecuteNonQuery(); // thực hiện câu lệnh SQL 
                        MessageBox.Show(
                        "Đăng ký thành công!",
                        "Confirm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        //this.Close(); // Đóng form đăng ký
                        frm_FormLogin login = new frm_FormLogin();
                        login.Show(); // mở form đăng ký dạng modal (chặn ngoài)
                        this.Hide();
                    }
                    else
                    {
                        if (lbl_CheckName.Visible == true || txt_Name.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại Name!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if (lbl_CheckUsername.Visible == true || txt_Username.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại UserName!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if (lbl_CheckEmail.Visible == true || txt_Email.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại Email!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if (lbl_CheckPassword.Visible == true || txt_Password.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại Password!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if (lbl_CheckConfirmPassword.Visible == true || txt_ConfirmPassword.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại Confirm Password!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Lỗi", ex.Message);
                }
            }

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text.Length >= 5)
            {
                lbl_CheckName.Visible = false;
            }
            else
            {
                lbl_CheckName.Text = "Name ít nhất 5 kí tự!";
                lbl_CheckName.Visible = true;
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            string Parttern = @"^[a-zA-Z0-9_]{5,20}$";
            string UserName = txt_Username.Text;
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM GIAOVIEN WHERE username=@user";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@user", txt_Username.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (Regex.IsMatch(UserName, Parttern) && reader.HasRows)
                    {
                        lbl_CheckUsername.Text = "Xin lỗi, User đã được sử dụng! Vui lòng thử lại.";
                        lbl_CheckUsername.Visible = true;
                    }
                    else if (!Regex.IsMatch(UserName, Parttern))
                    {
                        lbl_CheckUsername.Text = "User có 5 - 20 kí tự bao gồm chữ hoa, chữ thường, số và kí tự gạch dưới \nkhông bao gồm khoảng trắng.";
                        lbl_CheckUsername.Visible = true;
                    }
                    else
                    {
                        lbl_CheckUsername.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string email = txt_Email.Text;
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM GIAOVIEN WHERE email = @email";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows && Regex.IsMatch(email, pattern))
                    {
                        lbl_CheckEmail.Text = "Email đã tồn tại!";
                        lbl_CheckEmail.Visible = true;
                    }
                    else if (!Regex.IsMatch(email, pattern))
                    {
                        lbl_CheckEmail.Text = "Định dạng Email không hợp lệ!";
                        lbl_CheckEmail.Visible = true;
                    }
                    else
                    {
                        lbl_CheckEmail.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            string parttern = @"^(0|\+84)(3[2-9]|5[6|8|9]|7[0|6-9]|8[1-9]|9[0-9])[0-9]{7}$";
            string phone = txt_Phone.Text;
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM GIAOVIEN WHERE phone = @phone";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows && Regex.IsMatch(phone, parttern))
                    {
                        lbl_CheckPhone.Text = "Phone Number đã tồn tại!";
                        lbl_CheckPhone.Visible = true;
                    }
                    else if(!Regex.IsMatch(phone, parttern))
                    {
                        lbl_CheckPhone.Text = "Định dạng Phone Number không hợp lệ!";
                        lbl_CheckPhone.Visible = true;
                    }
                    else
                    {
                        lbl_CheckPhone.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", ex.Message);
                }
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked == false)
            {
                // ẩn các kí tự trong password
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                // hiển thị các kí tự trong password
                txt_Password.UseSystemPasswordChar = false;
            }
            //string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d@$!%*?&]{8,}$";
            string password = txt_Password.Text;
            if (!Regex.IsMatch(password, pattern))
            {
                lbl_CheckPassword.Text = "Mật khẩu gồm có 8 kí tự, bao gồm chữ hoa, chữ thường và số.";
                lbl_CheckPassword.Visible = true;
            }
            else
            {
                lbl_CheckPassword.Visible = false;
            }
        }

        private void txt_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (chk_ShowConfirmPassword.Checked == false)
            {
                txt_ConfirmPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txt_ConfirmPassword.UseSystemPasswordChar = false;
            }
            string password = txt_Password.Text;
            string confirm = txt_ConfirmPassword.Text;
            if (!confirm.Equals(password))
            {
                lbl_CheckConfirmPassword.Text = "Mật khẩu không đúng, vui lòng nhập lại.";
                lbl_CheckConfirmPassword.Visible = true;
            }
            else
            {
                lbl_CheckConfirmPassword.Visible = false;
            }
        }

        private void chk_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;// mở các kí tự password
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;// ẩn các kí tự password
            }
        }

        private void chk_ShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowConfirmPassword.Checked)
            {
                txt_ConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_ConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            frm_FormLogin formLogin = new frm_FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
