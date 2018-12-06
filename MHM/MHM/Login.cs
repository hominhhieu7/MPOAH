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
    public partial class Login : Form
    {
        QLHTEntities db = new QLHTEntities();
        public Login()
        {
            InitializeComponent();
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            var data = db.tbl_Employee.FirstOrDefault(p => p.Username == txtUsername.Text && p.Password == txtPassword.Text);
            if (data != null)
            {
                Infor.Tennv = data.Hovaten;
                Infor.Id = data.Id;
                if (data.Position == "GD")
                {
                    Visible = false;
                    Menuadmin menuadmin = new Menuadmin();
                    menuadmin.Show();
                }
                else
                {
                    Visible = false;
                    Menuemployee mainMenu = new Menuemployee();
                    mainMenu.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
