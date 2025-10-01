namespace FormRegister
{
    partial class frm_FormDelete
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Delete = new System.Windows.Forms.Label();
            this.lbl_CheckId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(102, 116);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(149, 41);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Id";
            this.lbl_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(243, 119);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(328, 35);
            this.txt_Id.TabIndex = 2;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(243, 233);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(151, 52);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Delete
            // 
            this.lbl_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete.Location = new System.Drawing.Point(0, 0);
            this.lbl_Delete.Name = "lbl_Delete";
            this.lbl_Delete.Size = new System.Drawing.Size(800, 83);
            this.lbl_Delete.TabIndex = 0;
            this.lbl_Delete.Text = "Delete Sinh Viên";
            this.lbl_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckId
            // 
            this.lbl_CheckId.AutoSize = true;
            this.lbl_CheckId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckId.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckId.Location = new System.Drawing.Point(243, 161);
            this.lbl_CheckId.Name = "lbl_CheckId";
            this.lbl_CheckId.Size = new System.Drawing.Size(0, 17);
            this.lbl_CheckId.TabIndex = 4;
            this.lbl_CheckId.Visible = false;
            // 
            // frm_FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_CheckId);
            this.Controls.Add(this.lbl_Delete);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Name = "frm_FormDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FormDelete_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Delete;
        private System.Windows.Forms.Label lbl_CheckId;
    }
}