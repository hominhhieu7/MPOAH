﻿namespace MHM
{
    partial class quanlyuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlyuser));
            this.griduser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.griduser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // griduser
            // 
            this.griduser.AllowUserToAddRows = false;
            this.griduser.AllowUserToDeleteRows = false;
            this.griduser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griduser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.griduser.Location = new System.Drawing.Point(0, 192);
            this.griduser.Name = "griduser";
            this.griduser.ReadOnly = true;
            this.griduser.Size = new System.Drawing.Size(757, 273);
            this.griduser.TabIndex = 0;
            this.griduser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griduser_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ nhà:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(154, 33);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(142, 21);
            this.txtHoten.TabIndex = 4;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(154, 68);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(142, 21);
            this.txtDiachi.TabIndex = 5;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(154, 104);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(142, 21);
            this.txtSdt.TabIndex = 6;
            // 
            // txtSave
            // 
            this.txtSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSave.ImageOptions.Image")));
            this.txtSave.Location = new System.Drawing.Point(211, 149);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(85, 37);
            this.txtSave.TabIndex = 7;
            this.txtSave.Text = "Lưu";
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(322, 150);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(85, 37);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(494, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(137, 21);
            this.txtUsername.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // cbChucvu
            // 
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Location = new System.Drawing.Point(494, 104);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(137, 21);
            this.cbChucvu.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chức vụ:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(494, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(137, 21);
            this.txtPassword.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(744, 165);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(13, 21);
            this.txtId.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(434, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 37);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.cbChucvu);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtUsername);
            this.groupControl1.Controls.Add(this.btnDel);
            this.groupControl1.Controls.Add(this.txtSave);
            this.groupControl1.Controls.Add(this.txtSdt);
            this.groupControl1.Controls.Add(this.txtDiachi);
            this.groupControl1.Controls.Add(this.txtHoten);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(757, 192);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Thông tin người dùng";
            // 
            // quanlyuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 465);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.griduser);
            this.MaximumSize = new System.Drawing.Size(773, 504);
            this.MinimumSize = new System.Drawing.Size(773, 504);
            this.Name = "quanlyuser";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.quanlyuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griduser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView griduser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSdt;
        private DevExpress.XtraEditors.SimpleButton txtSave;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbChucvu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtId;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}