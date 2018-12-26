namespace MHM
{
    partial class Menuemployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuemployee));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhapthuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoimk = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.btnDMThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachhang = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanthuoc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.lbTennv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNhapthuoc,
            this.btnDoimk,
            this.barMdiChildrenListItem1,
            this.btnDMThuoc,
            this.btnQLThuoc,
            this.barButtonItem1,
            this.btnDangxuat,
            this.btnKhachhang,
            this.btnBanthuoc});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.QuickToolbarItemLinks.Add(this.btnDoimk);
            this.ribbon.Size = new System.Drawing.Size(763, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnNhapthuoc
            // 
            this.btnNhapthuoc.Caption = "Nhập thuốc";
            this.btnNhapthuoc.Id = 1;
            this.btnNhapthuoc.ImageOptions.Image = global::MHM.Properties.Resources.pill_icon;
            this.btnNhapthuoc.Name = "btnNhapthuoc";
            this.btnNhapthuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhapthuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapthuoc_ItemClick);
            // 
            // btnDoimk
            // 
            this.btnDoimk.Caption = "Đổi mật khẩu";
            this.btnDoimk.Id = 2;
            this.btnDoimk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoimk.ImageOptions.Image")));
            this.btnDoimk.Name = "btnDoimk";
            this.btnDoimk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoimk_ItemClick);
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 3;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // btnDMThuoc
            // 
            this.btnDMThuoc.Caption = "Danh mục thuốc";
            this.btnDMThuoc.Id = 4;
            this.btnDMThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDMThuoc.ImageOptions.Image")));
            this.btnDMThuoc.Name = "btnDMThuoc";
            this.btnDMThuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDMThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDMThuoc_ItemClick);
            // 
            // btnQLThuoc
            // 
            this.btnQLThuoc.Caption = "Quản lý thuốc";
            this.btnQLThuoc.Id = 5;
            this.btnQLThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLThuoc.ImageOptions.Image")));
            this.btnQLThuoc.Name = "btnQLThuoc";
            this.btnQLThuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLThuoc_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng xuất";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Caption = "Đăng xuất";
            this.btnDangxuat.Id = 7;
            this.btnDangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.ImageOptions.Image")));
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangxuat_ItemClick);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Caption = "Danh mục khách hàng";
            this.btnKhachhang.Id = 8;
            this.btnKhachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.ImageOptions.Image")));
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhachhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachhang_ItemClick);
            // 
            // btnBanthuoc
            // 
            this.btnBanthuoc.Caption = "Bán thuốc";
            this.btnBanthuoc.Id = 9;
            this.btnBanthuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBanthuoc.ImageOptions.Image")));
            this.btnBanthuoc.Name = "btnBanthuoc";
            this.btnBanthuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBanthuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanthuoc_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý nhập thuốc";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapthuoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLThuoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDMThuoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangxuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý nhập thuốc";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Bán thuốc";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKhachhang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Thông tin khách hàng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBanthuoc);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Bán thuốc";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(763, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // lbTennv
            // 
            this.lbTennv.AutoSize = true;
            this.lbTennv.Location = new System.Drawing.Point(670, 31);
            this.lbTennv.Name = "lbTennv";
            this.lbTennv.Size = new System.Drawing.Size(35, 13);
            this.lbTennv.TabIndex = 3;
            this.lbTennv.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xin chào:";
            // 
            // Menuemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTennv);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(773, 700);
            this.MinimumSize = new System.Drawing.Size(773, 700);
            this.Name = "Menuemployee";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Menuemployee";
            this.Load += new System.EventHandler(this.Menuemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnNhapthuoc;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDoimk;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarButtonItem btnDMThuoc;
        private DevExpress.XtraBars.BarButtonItem btnQLThuoc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDangxuat;
        private System.Windows.Forms.Label lbTennv;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnKhachhang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBanthuoc;
    }
}