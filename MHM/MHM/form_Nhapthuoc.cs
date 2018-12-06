using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MHM.Data;
using System.Data.Entity;
using MHM.Model;
namespace MHM
{
    public partial class form_Nhapthuoc : DevExpress.XtraEditors.XtraForm
    {
        QLHTEntities db = new QLHTEntities();
        public form_Nhapthuoc()
        {
            InitializeComponent();
        }

        private void form_Nhapthuoc_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            gridData.DataSource = db.tbl_Medicine.ToList();
            gridData.Columns[1].HeaderText = "Mã thuốc";
            gridData.Columns[2].HeaderText = "Tên thuốc";
            gridData.Columns[3].HeaderText = "Số lượng thuốc";
            gridData.Columns[4].HeaderText = "Ngày nhập thuốc";
            gridData.Columns[5].HeaderText = "Giá nhập thuốc";
            gridData.Columns[6].HeaderText = "Giá bán thuốc";
            gridData.Columns[7].HeaderText = "Tên nhân viên";
            gridData.Columns[0].Width = 30;
            gridData.Columns[3].Width = 100;
            gridData.Columns[4].Width = 100;
            gridData.Columns[5].Width = 80;
            txtTennv.Text = Infor.Tennv;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}