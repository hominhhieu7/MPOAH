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

        }
    }
}