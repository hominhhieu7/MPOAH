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
            txtId.Visible = false;
            txtId.Text = "0";
            var data = db.tbl_Medicine.ToList();
            gridData.DataSource = data;
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

        private void txtSave_Click(object sender, EventArgs e)
        {
            var add = new tbl_Medicine();
            int id;
            id = Convert.ToInt32(txtId.Text);
            add.Mathuoc = txtMathuoc.Text;
            add.Ngaynhap = DateTime.Now;
            add.Soluong = Convert.ToDouble(txtSoluong.Text);
            add.Tenthuoc = txtTenthuoc.Text;
            add.Addwho = txtTennv.Text;
            add.Giaban = Convert.ToDecimal(txtGiaban.Text);
            add.Gianhap = Convert.ToDecimal(txtGiamua.Text);
            if (id == 0)
            {
                db.tbl_Medicine.Add(add);
                MessageBox.Show("Đã lưu!!!", "Thông báo", MessageBoxButtons.OK);
                load();
            }
            else
            {
                tbl_Medicine update = db.tbl_Medicine.Where(p => p.Id == id).Select(p => p).FirstOrDefault();
                update.Mathuoc = txtMathuoc.Text;
                update.Ngaynhap = DateTime.Now;
                update.Soluong = Convert.ToDouble(txtSoluong.Text);
                update.Tenthuoc = txtTenthuoc.Text;
                update.Addwho = txtTennv.Text;
                update.Giaban = Convert.ToDecimal(txtGiaban.Text);
                update.Gianhap = Convert.ToDecimal(txtGiamua.Text);
                db.SaveChanges();
                MessageBox.Show("Đã lưu!!!", "Thông báo", MessageBoxButtons.OK);
                load();

            }
            db.SaveChanges();
            load();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.Rows.Count > 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectrow = gridData.Rows[index];
                txtId.Text = selectrow.Cells[0].Value.ToString();
                txtMathuoc.Text = selectrow.Cells[1].Value.ToString();
                
            }
        }
    }
}