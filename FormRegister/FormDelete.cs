using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegister
{
    public partial class frm_FormDelete : Form
    {
        public frm_FormDelete()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM SINHVIEN WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txt_Id.Text));
                    
                    
                    if (txt_Id.Text.Length != 0)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(
                            "Xóa thành công sinh viên!",
                            "Confirm",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        frm_FormMain frmMain = new frm_FormMain();
                        frmMain.Show();
                        this.Hide();
                    }

                }
                catch (Exception ex)  
                {
                    MessageBox.Show("Lỗi" , ex.Message);
                }
            }
        }

        private void frm_FormDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel == false)
            {
                frm_FormMain formMain = new frm_FormMain();
                formMain.Show();
                this.Hide();
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
                        lbl_CheckId.Visible = false;
                    }
                    else
                    {
                        lbl_CheckId.Text = "Id không tồn tại!";
                        lbl_CheckId.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", ex.Message);
                }
            }
        }
    }
}
