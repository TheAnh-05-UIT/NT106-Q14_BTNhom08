using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegister
{
    public partial class frm_FormMain : Form
    {
        public frm_FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDatabaseDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.userDatabaseDataSet.SINHVIEN);

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            frm_FormCreate frm_FormCreate = new frm_FormCreate();
            frm_FormCreate.Show();
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            frm_FormDelete frm_FormDelete = new frm_FormDelete();
            frm_FormDelete.Show();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm_FormUpdate frm_FormUpdate = new frm_FormUpdate();
            frm_FormUpdate.Show();
            this.Close();
        }

        private void frm_FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
               return;
            }
        }
    }
}
