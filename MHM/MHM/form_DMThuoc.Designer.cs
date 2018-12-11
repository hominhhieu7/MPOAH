namespace MHM
{
    partial class form_DMThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DMThuoc));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMadm = new DevExpress.XtraEditors.TextEdit();
            this.txtTendm = new DevExpress.XtraEditors.TextEdit();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMadm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(212, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã danh mục:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(212, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên danh mục:";
            // 
            // txtMadm
            // 
            this.txtMadm.Location = new System.Drawing.Point(318, 46);
            this.txtMadm.Name = "txtMadm";
            this.txtMadm.Size = new System.Drawing.Size(141, 20);
            this.txtMadm.TabIndex = 2;
            // 
            // txtTendm
            // 
            this.txtTendm.Location = new System.Drawing.Point(318, 101);
            this.txtTendm.Name = "txtTendm";
            this.txtTendm.Size = new System.Drawing.Size(141, 20);
            this.txtTendm.TabIndex = 3;
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGrid.Location = new System.Drawing.Point(0, 232);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.Size = new System.Drawing.Size(757, 233);
            this.dtGrid.TabIndex = 4;
            this.dtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellClick);
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(430, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 37);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(318, 185);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(85, 37);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(207, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtId.Location = new System.Drawing.Point(747, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(10, 20);
            this.txtId.TabIndex = 23;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnDel);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.txtTendm);
            this.groupControl1.Controls.Add(this.txtMadm);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(756, 232);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Nhập danh mục thuốc";
            // 
            // form_DMThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 465);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtGrid);
            this.MaximumSize = new System.Drawing.Size(773, 504);
            this.MinimumSize = new System.Drawing.Size(773, 504);
            this.Name = "form_DMThuoc";
            this.Text = "Danh mục thuốc";
            this.Load += new System.EventHandler(this.form_DMThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMadm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMadm;
        private DevExpress.XtraEditors.TextEdit txtTendm;
        private System.Windows.Forms.DataGridView dtGrid;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtId;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}