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
    public partial class form_Quanlythuoc : Form
    {
        QLHTEntities db = new QLHTEntities();
        public form_Quanlythuoc()
        {
            InitializeComponent();
        }
        private void load()
        {
            var data = db.tbl_Thuoc.ToArray();
            dtGrid.DataSource = data;
            dtGrid.Columns[0].HeaderText = "Id";
            dtGrid.Columns[1].HeaderText = "Mã danh mục";
            dtGrid.Columns[2].HeaderText = "Tên thuốc";
            dtGrid.Columns[3].HeaderText = "Mã thuốc";
            dtGrid.Columns[0].Width = 100;
            dtGrid.Columns[1].Width = 200;
            dtGrid.Columns[2].Width = 200;
            dtGrid.Columns[3].Width = 200;
        }

        private void form_Quanlythuoc_Load(object sender, EventArgs e)
        {
            load();
            var data = db.tbl_ListMedicine.ToArray();
            for (int i = 0; data.Length > i; i++)
            {
                cbMaDM.Items.Add(data[i].Madanhmuc);
            }
            txtId.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var add = new tbl_Thuoc();
            int id;
            id = Convert.ToInt32(txtId.Text);
            add.Madanhmuc = cbMaDM.SelectedItem.ToString();
            add.Mathuoc = txtMathuoc.Text;
            add.Tenthuoc = txtTenthuoc.Text;
            var dt = db.tbl_Thuoc.Where(p => p.Mathuoc == txtMathuoc.Text).FirstOrDefault();
            if (id == 0)
            {
                if (dt.Mathuoc != "")
                    MessageBox.Show("Ma thuoc ton tai", "Canh bao");
                else
                {
                    db.tbl_Thuoc.Add(add);
                    db.SaveChanges();
                    MessageBox.Show("Đã lưu!!!", "Thông báo", MessageBoxButtons.OK);
                    load();
                }
            }
            else
            {
                var data = db.tbl_Thuoc.Where(p => p.Id == id).First();
                data.Madanhmuc = cbMaDM.SelectedItem.ToString();
                data.Mathuoc = txtMathuoc.Text;
                data.Tenthuoc = txtTenthuoc.Text;
                db.SaveChanges();
                MessageBox.Show("Đã lưu!!!", "Thông báo", MessageBoxButtons.OK);
                load();

            }
        }
    }
}
