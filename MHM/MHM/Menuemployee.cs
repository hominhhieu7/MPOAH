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
            form_doimk doimk = new form_doimk();
            doimk.Show();
        }
    }
}