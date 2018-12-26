using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MHM.Model;
namespace MHM
{
    public partial class Menuemployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menuemployee()
        {
            InitializeComponent();
        }
        private bool Checkform(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void Activechildform(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnNhapthuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Checkform("form_Nhapthuoc"))
            {
                form_Nhapthuoc nhap = new form_Nhapthuoc();
                nhap.MdiParent = this;
                nhap.Show();
            }
            else
            {
                Activechildform("form_Nhapthuoc");
            }
        }

        private void btnDoimk_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Infor.check == 0)
            {
                form_doimk doimk = new form_doimk();
                doimk.Show();
                Infor.check++;
            }
        }

        private void btnDMThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Checkform("form_DMThuoc"))
            {
                form_DMThuoc nhap = new form_DMThuoc();
                nhap.MdiParent = this;
                nhap.Show();
            }
            else
            {
                Activechildform("form_DMThuoc");
            }
        }

        private void btnQLThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Checkform("form_Quanlythuoc"))
            {
                form_Quanlythuoc nhap = new form_Quanlythuoc();
                nhap.MdiParent = this;
                nhap.Show();
            }
            else
            {
                Activechildform("form_Quanlythuoc");
            }
        }

        private void btnDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn đăng xuất ???", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
            else if (dialog == DialogResult.No)
            {
                return;
            }
            else
            {
                MessageBox.Show("Lỗi!!!", "Thông báo");
            }
        }

        private void Menuemployee_Load(object sender, EventArgs e)
        {
            lbTennv.Text = Infor.Tennv;
        }

        private void btnKhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Checkform("form_DMKH"))
            {
                form_DMKH nhap = new form_DMKH();
                nhap.MdiParent = this;
                nhap.Show();
            }
            else
            {
                Activechildform("form_DMKH");
            }
        }

        private void btnBanthuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Checkform("form_Banthuoc"))
            {
                form_Banthuoc nhap = new form_Banthuoc();
                nhap.MdiParent = this;
                nhap.Show();
            }
            else
            {
                Activechildform("form_Banthuoc");
            }
        }
    }
}