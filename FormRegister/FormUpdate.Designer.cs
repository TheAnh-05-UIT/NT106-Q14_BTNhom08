namespace FormRegister
{
    partial class frm_FormUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Update = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_CheckId = new System.Windows.Forms.Label();
            this.lbl_CheckName = new System.Windows.Forms.Label();
            this.lbl_CheckEmail = new System.Windows.Forms.Label();
            this.lbl_CheckPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Update
            // 
            this.lbl_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update.Location = new System.Drawing.Point(0, 0);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Size = new System.Drawing.Size(854, 85);
            this.lbl_Update.TabIndex = 0;
            this.lbl_Update.Text = "Update Sinh Viên";
            this.lbl_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(86, 300);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(158, 64);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(86, 109);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(158, 64);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Id";
            this.lbl_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(86, 206);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(158, 64);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(86, 392);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(158, 64);
            this.lbl_Phone.TabIndex = 6;
            this.lbl_Phone.Text = "Phone";
            this.lbl_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(250, 126);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(383, 32);
            this.txt_Id.TabIndex = 2;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(250, 223);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(383, 32);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(250, 317);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(383, 32);
            this.txt_Email.TabIndex = 6;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(250, 409);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(383, 32);
            this.txt_Phone.TabIndex = 7;
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_Phone_TextChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(294, 506);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(163, 60);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_CheckId
            // 
            this.lbl_CheckId.AutoSize = true;
            this.lbl_CheckId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckId.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckId.Location = new System.Drawing.Point(250, 170);
            this.lbl_CheckId.Name = "lbl_CheckId";
            this.lbl_CheckId.Size = new System.Drawing.Size(0, 17);
            this.lbl_CheckId.TabIndex = 9;
            this.lbl_CheckId.Visible = false;
            // 
            // lbl_CheckName
            // 
            this.lbl_CheckName.AutoSize = true;
            this.lbl_CheckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckName.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckName.Location = new System.Drawing.Point(250, 267);
            this.lbl_CheckName.Name = "lbl_CheckName";
            this.lbl_CheckName.Size = new System.Drawing.Size(0, 17);
            this.lbl_CheckName.TabIndex = 10;
            this.lbl_CheckName.Visible = false;
            // 
            // lbl_CheckEmail
            // 
            this.lbl_CheckEmail.AutoSize = true;
            this.lbl_CheckEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckEmail.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckEmail.Location = new System.Drawing.Point(250, 361);
            this.lbl_CheckEmail.Name = "lbl_CheckEmail";
            this.lbl_CheckEmail.Size = new System.Drawing.Size(0, 17);
            this.lbl_CheckEmail.TabIndex = 11;
            this.lbl_CheckEmail.Visible = false;
            // 
            // lbl_CheckPhone
            // 
            this.lbl_CheckPhone.AutoSize = true;
            this.lbl_CheckPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckPhone.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckPhone.Location = new System.Drawing.Point(250, 453);
            this.lbl_CheckPhone.Name = "lbl_CheckPhone";
            this.lbl_CheckPhone.Size = new System.Drawing.Size(0, 17);
            this.lbl_CheckPhone.TabIndex = 12;
            this.lbl_CheckPhone.Visible = false;
            // 
            // frm_FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 593);
            this.Controls.Add(this.lbl_CheckPhone);
            this.Controls.Add(this.lbl_CheckEmail);
            this.Controls.Add(this.lbl_CheckName);
            this.Controls.Add(this.lbl_CheckId);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Update);
            this.Name = "frm_FormUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FormUpdate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_CheckId;
        private System.Windows.Forms.Label lbl_CheckName;
        private System.Windows.Forms.Label lbl_CheckEmail;
        private System.Windows.Forms.Label lbl_CheckPhone;
    }
}