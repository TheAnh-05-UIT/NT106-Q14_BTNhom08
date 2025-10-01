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
    public partial class frm_FormUpdate : Form
    {
        public frm_FormUpdate()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE SINHVIEN SET NAMESV=@name,EMAIL=@email,PHONE=@phone WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txt_Id.Text));
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);


                    if (lbl_CheckId.Visible == false && 
                        lbl_CheckEmail.Visible == false && 
                        lbl_CheckName.Visible == false &&
                        lbl_CheckPhone.Visible == false &&
                        txt_Id.Text.Length != 0 &&
                        txt_Email.Text.Length != 0 && 
                        txt_Name.Text.Length != 0 &&
                        txt_Phone.Text.Length != 0)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(
                        "Cập nhật thành công sinh viên!",
                        "Confirm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        frm_FormMain frm_FormMain = new frm_FormMain();
                        frm_FormMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (lbl_CheckId.Visible == true || txt_Id.Text.Length == 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "Kiểm tra lại id sinh viên!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        else if (lbl_CheckName.Visible == true || txt_Name.Text.Length == 0)
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

        private void frm_FormUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel == false)
            {
                frm_FormMain formMain = new frm_FormMain();
                formMain.Show();
                this.Hide();
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
                    string query = "SELECT * FROM SINHVIEN WHERE EMAIL = @email AND Id <> @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("Id",int.Parse(txt_Id.Text));
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows && Regex.IsMatch(email, pattern))
                    {
                        lbl_CheckEmail.Text = "Email trùng với sinh viên khác.";
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
                    string query = "SELECT * FROM SINHVIEN WHERE PHONE = @phone AND Id <> @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("Id", int.Parse(txt_Id.Text));
                    cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows && Regex.IsMatch(phone, parttern))
                    {
                        lbl_CheckPhone.Text = "Phone Number trùng với sinh viên khác!";
                        lbl_CheckPhone.Visible = true;
                    }
                    else if (!Regex.IsMatch(phone, parttern))
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

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
            string id = txt_Id.Text;
            for (int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i]))
                {
                    lbl_CheckId.Text = "Id không hợp lệ! Id là một số nguyên dương.\nVui lòng nhập lại";
                    lbl_CheckId.Visible = true;
                }
                else
                {
                    lbl_CheckId.Visible = false;
                }
            }
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SINHVIEN WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("Id", int.Parse(txt_Id.Text));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows) 
                    { 
                        lbl_CheckId.Visible = false ;
                    }
                    else
                    {
                        lbl_CheckId.Text = "Id không tồn tại!";
                        lbl_CheckId.Visible = true;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Lỗi", ex.Message);
                }
            }
        }
    }
}
