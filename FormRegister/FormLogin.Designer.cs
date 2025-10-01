namespace FormRegister
{
    partial class frm_FormLogin
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbk_Username = new System.Windows.Forms.Label();
            this.lbl_NotAMember = new System.Windows.Forms.Label();
            this.chk_ShowPassword = new System.Windows.Forms.CheckBox();
            this.lklbl_Register = new System.Windows.Forms.LinkLabel();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(0, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(800, 74);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Log In";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbk_Username
            // 
            this.lbk_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbk_Username.Location = new System.Drawing.Point(78, 109);
            this.lbk_Username.Name = "lbk_Username";
            this.lbk_Username.Size = new System.Drawing.Size(148, 55);
            this.lbk_Username.TabIndex = 1;
            this.lbk_Username.Text = "Username";
            this.lbk_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NotAMember
            // 
            this.lbl_NotAMember.AutoSize = true;
            this.lbl_NotAMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotAMember.ForeColor = System.Drawing.Color.Gray;
            this.lbl_NotAMember.Location = new System.Drawing.Point(254, 369);
            this.lbl_NotAMember.Name = "lbl_NotAMember";
            this.lbl_NotAMember.Size = new System.Drawing.Size(118, 20);
            this.lbl_NotAMember.TabIndex = 7;
            this.lbl_NotAMember.Text = "Not a member?";
            // 
            // chk_ShowPassword
            // 
            this.chk_ShowPassword.AutoSize = true;
            this.chk_ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ShowPassword.Location = new System.Drawing.Point(557, 215);
            this.chk_ShowPassword.Name = "chk_ShowPassword";
            this.chk_ShowPassword.Size = new System.Drawing.Size(88, 29);
            this.chk_ShowPassword.TabIndex = 5;
            this.chk_ShowPassword.Text = "Show";
            this.chk_ShowPassword.UseVisualStyleBackColor = true;
            this.chk_ShowPassword.CheckedChanged += new System.EventHandler(this.chk_ShowPassword_CheckedChanged);
            // 
            // lklbl_Register
            // 
            this.lklbl_Register.AutoSize = true;
            this.lklbl_Register.Location = new System.Drawing.Point(254, 389);
            this.lklbl_Register.Name = "lklbl_Register";
            this.lklbl_Register.Size = new System.Drawing.Size(101, 20);
            this.lklbl_Register.TabIndex = 8;
            this.lklbl_Register.TabStop = true;
            this.lklbl_Register.Text = "Sign Up Now";
            this.lklbl_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_Register_LinkClicked);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(78, 202);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(148, 55);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(255, 298);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(170, 51);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Log In";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(258, 122);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(387, 30);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(258, 215);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(273, 30);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // frm_FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lklbl_Register);
            this.Controls.Add(this.chk_ShowPassword);
            this.Controls.Add(this.lbl_NotAMember);
            this.Controls.Add(this.lbk_Username);
            this.Controls.Add(this.lbl_Login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbk_Username;
        private System.Windows.Forms.Label lbl_NotAMember;
        private System.Windows.Forms.CheckBox chk_ShowPassword;
        private System.Windows.Forms.LinkLabel lklbl_Register;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
    }
}