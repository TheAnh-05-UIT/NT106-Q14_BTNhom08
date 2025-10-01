namespace FormRegister
{
    partial class frm_FormCreate
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.btn_Creates = new System.Windows.Forms.Button();
            this.lbl_Create = new System.Windows.Forms.Label();
            this.lbl_CheckName = new System.Windows.Forms.Label();
            this.lbl_CheckEmail = new System.Windows.Forms.Label();
            this.lbl_CheckPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(58, 84);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(167, 57);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(58, 181);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(167, 57);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Email.Click += new System.EventHandler(this.lbl_Email_Click);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(58, 277);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(167, 57);
            this.lbl_Phone.TabIndex = 5;
            this.lbl_Phone.Text = "Phone";
            this.lbl_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(231, 95);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(406, 35);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(231, 192);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(406, 35);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(235, 288);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(406, 35);
            this.txt_Phone.TabIndex = 6;
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_Phone_TextChanged);
            // 
            // btn_Creates
            // 
            this.btn_Creates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Creates.Location = new System.Drawing.Point(231, 418);
            this.btn_Creates.Name = "btn_Creates";
            this.btn_Creates.Size = new System.Drawing.Size(159, 69);
            this.btn_Creates.TabIndex = 7;
            this.btn_Creates.Text = "Create";
            this.btn_Creates.UseVisualStyleBackColor = true;
            this.btn_Creates.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Create
            // 
            this.lbl_Create.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Create.Location = new System.Drawing.Point(0, 0);
            this.lbl_Create.Name = "lbl_Create";
            this.lbl_Create.Size = new System.Drawing.Size(800, 84);
            this.lbl_Create.TabIndex = 0;
            this.lbl_Create.Text = "Create Sinh Viên";
            this.lbl_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckName
            // 
            this.lbl_CheckName.AutoSize = true;
            this.lbl_CheckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckName.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckName.Location = new System.Drawing.Point(232, 143);
            this.lbl_CheckName.Name = "lbl_CheckName";
            this.lbl_CheckName.Size = new System.Drawing.Size(0, 17);
            this.lbl_CheckName.TabIndex = 8;
            this.lbl_CheckName.Visible = false;
            // 
            // lbl_CheckEmail
            // 
            this.lbl_CheckEmail.AutoSize = true;
            this.lbl_CheckEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckEmail.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckEmail.Location = new System.Drawing.Point(232, 240);
            this.lbl_CheckEmail.Name = "lbl_CheckEmail";
            this.lbl_CheckEmail.Size = new System.Drawing.Size(0, 17);
            this.lbl_CheckEmail.TabIndex = 9;
            this.lbl_CheckEmail.Visible = false;
            // 
            // lbl_CheckPhone
            // 
            this.lbl_CheckPhone.AutoSize = true;
            this.lbl_CheckPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckPhone.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckPhone.Location = new System.Drawing.Point(232, 336);
            this.lbl_CheckPhone.Name = "lbl_CheckPhone";
            this.lbl_CheckPhone.Size = new System.Drawing.Size(0, 17);
            this.lbl_CheckPhone.TabIndex = 10;
            this.lbl_CheckPhone.Visible = false;
            // 
            // frm_FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.lbl_CheckPhone);
            this.Controls.Add(this.lbl_CheckEmail);
            this.Controls.Add(this.lbl_CheckName);
            this.Controls.Add(this.lbl_Create);
            this.Controls.Add(this.btn_Creates);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Name);
            this.Name = "frm_FormCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FormCreate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Button btn_Creates;
        private System.Windows.Forms.Label lbl_Create;
        private System.Windows.Forms.Label lbl_CheckName;
        private System.Windows.Forms.Label lbl_CheckEmail;
        private System.Windows.Forms.Label lbl_CheckPhone;
    }
}