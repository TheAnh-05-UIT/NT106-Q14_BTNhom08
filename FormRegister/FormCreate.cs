using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormRegister
{
    public partial class frm_FormCreate : Form
    {
        public frm_FormCreate()
        {
            InitializeComponent();
        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO SINHVIEN (NAMESV, EMAIL, PHONE) VALUES (@name, @email, @phone)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);

                    if (lbl_CheckEmail.Visible == false &&
                        lbl_CheckName.Visible == false &&
                        lbl_CheckPhone.Visible == false &&
                        txt_Name.Text.Length != 0 &&
                        txt_Email.Text.Length != 0 &&
                        txt_Phone.Text.Length != 0)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(
                        "Tạo thành công sinh viên!",
                        "Confirm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        frm_FormMain frm = new frm_FormMain();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        if(lbl_CheckName.Visible == true || txt_Name.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại tên sinh viên!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        else if (lbl_CheckEmail.Visible == true || txt_Email.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại email sinh viên!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        else if (lbl_CheckPhone.Visible == true || txt_Phone.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại phone sinh viên!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", ex.Message);
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
                    string query = "SELECT * FROM SINHVIEN WHERE email = @email";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows && Regex.IsMatch(email, pattern))
                    {
                        lbl_CheckEmail.Text = "Email đã tồn tại.";
                        lbl_CheckEmail.Visible = true;
                    }
                    else if (!Regex.IsMatch(email, pattern))
                    {
                        lbl_CheckEmail.Text = "Định dạng Email không hợp lệ.";
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
                    string query = "SELECT * FROM SINHVIEN WHERE phone = @phone";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows && Regex.IsMatch(phone, parttern))
                    {
                        lbl_CheckPhone.Text = "Phone Number đã tồn tại.";
                        lbl_CheckPhone.Visible = true;
                    }
                    else if (!Regex.IsMatch(phone, parttern))
                    {
                        lbl_CheckPhone.Text = "Định dạng Phone Number không hợp lệ.";
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

        private void frm_FormCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel == false)
            {
                frm_FormMain formMain = new frm_FormMain();
                formMain.Show();
                this.Hide();
            }
        }
    }
}
