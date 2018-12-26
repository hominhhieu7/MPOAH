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
    public partial class Menuadmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menuadmin()
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
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Checkform("quanlyuser"))
            {
                quanlyuser quanlyusers = new quanlyuser();
                quanlyusers.MdiParent = this;
                quanlyusers.Show();
            }
            else
            {
                Activechildform("quanlyuser");
            }
            
        }
        
        private void Menuadmin_Load(object sender, EventArgs e)
        {
            
        }

        private void barBtntonthuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Checkform("Baocaotonthuoc"))
            {
                Baocaotonthuoc quanlyusers = new Baocaotonthuoc();
                quanlyusers.MdiParent = this;
                quanlyusers.Show();
            }
            else
            {
                Activechildform("Baocaotonthuoc");
            }
        }

        private void barBtnDMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Infor.check == 0)
            {
                form_doimk doimk = new form_doimk();
                doimk.Show();
                Infor.check++;
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Menuadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Infor.check = 0;
        }

        private void btnDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn đăng xuất ???", "Đăng xuất", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
            else if(dialog == DialogResult.No){
                return;
            }
            else
            {
                MessageBox.Show("Lỗi!!!", "Thông báo");
            }
        }
    }
}