namespace MHM
{
    partial class form_Nhapthuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Nhapthuoc));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbTenthuoc = new System.Windows.Forms.ComboBox();
            this.cbDanhmuc = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoluong = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtTennv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.txtSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiaban = new DevExpress.XtraEditors.TextEdit();
            this.txtGiamua = new DevExpress.XtraEditors.TextEdit();
            this.txtTenthuoc = new DevExpress.XtraEditors.TextEdit();
            this.txtMathuoc = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTennv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiamua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenthuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMathuoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã thuốc:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên thuốc:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Giá mua:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(356, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Giá bán: ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbTenthuoc);
            this.groupControl1.Controls.Add(this.cbDanhmuc);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.gridData);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtSoluong);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.txtTennv);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnDel);
            this.groupControl1.Controls.Add(this.txtSave);
            this.groupControl1.Controls.Add(this.txtGiaban);
            this.groupControl1.Controls.Add(this.txtGiamua);
            this.groupControl1.Controls.Add(this.txtTenthuoc);
            this.groupControl1.Controls.Add(this.txtMathuoc);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(757, 465);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin thuốc";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // cbTenthuoc
            // 
            this.cbTenthuoc.FormattingEnabled = true;
            this.cbTenthuoc.Location = new System.Drawing.Point(138, 63);
            this.cbTenthuoc.Name = "cbTenthuoc";
            this.cbTenthuoc.Size = new System.Drawing.Size(143, 21);
            this.cbTenthuoc.TabIndex = 27;
            this.cbTenthuoc.SelectedIndexChanged += new System.EventHandler(this.cbTenthuoc_SelectedIndexChanged);
            // 
            // cbDanhmuc
            // 
            this.cbDanhmuc.FormattingEnabled = true;
            this.cbDanhmuc.Location = new System.Drawing.Point(138, 127);
            this.cbDanhmuc.Name = "cbDanhmuc";
            this.cbDanhmuc.Size = new System.Drawing.Size(143, 21);
            this.cbDanhmuc.TabIndex = 26;
            this.cbDanhmuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhmuc_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(45, 130);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 13);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Danh mục thuốc:";
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridData.Location = new System.Drawing.Point(2, 206);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.Size = new System.Drawing.Size(753, 257);
            this.gridData.TabIndex = 6;
            this.gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellClick);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(356, 33);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Số lượng:";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(462, 30);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(143, 20);
            this.txtSoluong.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(724, 227);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(21, 20);
            this.txtId.TabIndex = 22;
            // 
            // txtTennv
            // 
            this.txtTennv.Enabled = false;
            this.txtTennv.Location = new System.Drawing.Point(462, 63);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(143, 20);
            this.txtTennv.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(356, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Tên nhân viên:";
            // 
            // btnClear
            // 
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(439, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 37);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(327, 163);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(85, 37);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtSave
            // 
            this.txtSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSave.ImageOptions.Image")));
            this.txtSave.Location = new System.Drawing.Point(216, 162);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(85, 37);
            this.txtSave.TabIndex = 17;
            this.txtSave.Text = "Lưu";
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(462, 97);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(143, 20);
            this.txtGiaban.TabIndex = 9;
            // 
            // txtGiamua
            // 
            this.txtGiamua.Location = new System.Drawing.Point(138, 97);
            this.txtGiamua.Name = "txtGiamua";
            this.txtGiamua.Size = new System.Drawing.Size(143, 20);
            this.txtGiamua.TabIndex = 8;
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Location = new System.Drawing.Point(138, 63);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(143, 20);
            this.txtTenthuoc.TabIndex = 6;
            // 
            // txtMathuoc
            // 
            this.txtMathuoc.Enabled = false;
            this.txtMathuoc.Location = new System.Drawing.Point(138, 30);
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(143, 20);
            this.txtMathuoc.TabIndex = 5;
            // 
            // form_Nhapthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 465);
            this.Controls.Add(this.groupControl1);
            this.MaximumSize = new System.Drawing.Size(773, 504);
            this.MinimumSize = new System.Drawing.Size(773, 504);
            this.Name = "form_Nhapthuoc";
            this.Text = "Nhập Thuốc";
            this.Load += new System.EventHandler(this.form_Nhapthuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTennv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiamua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenthuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMathuoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView gridData;
        private DevExpress.XtraEditors.TextEdit txtGiaban;
        private DevExpress.XtraEditors.TextEdit txtGiamua;
        private DevExpress.XtraEditors.TextEdit txtTenthuoc;
        private DevExpress.XtraEditors.TextEdit txtMathuoc;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton txtSave;
        private DevExpress.XtraEditors.TextEdit txtTennv;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSoluong;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbDanhmuc;
        private System.Windows.Forms.ComboBox cbTenthuoc;
    }
}