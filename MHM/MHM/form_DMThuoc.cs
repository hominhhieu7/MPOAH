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
    public partial class form_DMThuoc : Form
    {
        QLHTEntities db = new QLHTEntities();
        public form_DMThuoc()
        {
            InitializeComponent();
        }
        private void load()
        {
            txtId.Visible = false;
            txtId.Text = "0";
            var data = db.tbl_ListMedicine.ToList();
            dtGrid.DataSource = data;
            dtGrid.Columns[0].HeaderText = "Id";
            dtGrid.Columns[1].HeaderText = "Mã danh mục";
            dtGrid.Columns[2].HeaderText = "Tên danh mục";
            dtGrid.Columns[0].Width = 200;
            dtGrid.Columns[1].Width = 250;
            dtGrid.Columns[2].Width = 250;
        }

        private void form_DMThuoc_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtId.Text);
            var add = new tbl_ListMedicine();
            add.Madanhmuc = txtMadm.Text;
            add.Tendanhmuc = txtTendm.Text;
            if(id == 0)
            {
                db.tbl_ListMedicine.Add(add);
                db.SaveChanges();
                load();
            }
            else
            {
                tbl_ListMedicine up = db.tbl_ListMedicine.Where(p => p.Id == id).First();
                up.Madanhmuc = txtMadm.Text;
                up.Tendanhmuc = txtTendm.Text;
                db.SaveChanges();
                load();
            }
            load();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = Convert.ToInt32(txtId.Text);
                var data = db.tbl_ListMedicine.Where(p => p.Id == id).First();
                db.tbl_ListMedicine.Remove(data);
                db.SaveChanges();
                load();
            }
            catch
            {
                if (txtId.Text == "" || txtId.Text == "0")
                {
                    MessageBox.Show("Vui lòng chọn user", "Cảnh báo!!!");
                }
                else MessageBox.Show("Lỗi", "Cảnh báo!!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "0";
            txtMadm.Text = "";
            txtTendm.Text = "";
        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid.Rows.Count > 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectrow = dtGrid.Rows[index];
                txtId.Text = selectrow.Cells[0].Value.ToString();
                txtMadm.Text = selectrow.Cells[1].Value.ToString();
                txtTendm.Text = selectrow.Cells[2].Value.ToString();
            }
        }
    }
}
