namespace MHM
{
    partial class form_doimk
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_doimk));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMkcu = new DevExpress.XtraEditors.TextEdit();
            this.txtMkmoi = new DevExpress.XtraEditors.TextEdit();
            this.txtXnmk = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMkcu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMkmoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXnmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 204);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mật khẩu cũ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(85, 249);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(85, 294);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtMkcu
            // 
            this.txtMkcu.Location = new System.Drawing.Point(218, 201);
            this.txtMkcu.Name = "txtMkcu";
            this.txtMkcu.Properties.PasswordChar = '*';
            this.txtMkcu.Size = new System.Drawing.Size(134, 20);
            this.txtMkcu.TabIndex = 4;
            // 
            // txtMkmoi
            // 
            this.txtMkmoi.Location = new System.Drawing.Point(218, 246);
            this.txtMkmoi.Name = "txtMkmoi";
            this.txtMkmoi.Properties.PasswordChar = '*';
            this.txtMkmoi.Size = new System.Drawing.Size(134, 20);
            this.txtMkmoi.TabIndex = 5;
            // 
            // txtXnmk
            // 
            this.txtXnmk.Location = new System.Drawing.Point(218, 291);
            this.txtXnmk.Name = "txtXnmk";
            this.txtXnmk.Properties.PasswordChar = '*';
            this.txtXnmk.Size = new System.Drawing.Size(133, 20);
            this.txtXnmk.TabIndex = 6;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(235, 361);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 37);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(124, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // form_doimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 444);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtXnmk);
            this.Controls.Add(this.txtMkmoi);
            this.Controls.Add(this.txtMkcu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(465, 483);
            this.MinimumSize = new System.Drawing.Size(465, 483);
            this.Name = "form_doimk";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMkcu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMkmoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXnmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMkcu;
        private DevExpress.XtraEditors.TextEdit txtMkmoi;
        private DevExpress.XtraEditors.TextEdit txtXnmk;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}