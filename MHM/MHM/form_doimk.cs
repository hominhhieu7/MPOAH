using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHM.Data;
using MHM.Model;

namespace MHM
{
    public partial class form_doimk : Form
    {
        QLHTEntities db = new QLHTEntities();
        public form_doimk()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMkcu.Text == "" || txtMkmoi.Text == "" || txtXnmk.Text == "")
            {
                MessageBox.Show("Không được để trống các trường!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtMkmoi.Text != txtXnmk.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không giống nhau!!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int id = Infor.Id;
                tbl_Employee _Employee = db.tbl_Employee.Where(p => p.Id == id).First();
                if (txtMkcu.Text != _Employee.Password)
                {
                    MessageBox.Show("Sai mật khẩu!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _Employee.Password = txtXnmk.Text;
                    db.SaveChanges();
                    MessageBox.Show("Đã đổi mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }

        private void form_doimk_FormClosing(object sender, FormClosingEventArgs e)
        {
            Infor.check = 0;
        }
    }
}
