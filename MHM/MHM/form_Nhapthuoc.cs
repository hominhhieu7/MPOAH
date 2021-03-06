﻿using System;
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
            var _data = db.tbl_ListMedicine.ToArray();
            for (int i = 0; _data.Length > i; i++)
            {
                cbDanhmuc.Items.Add(_data[i].Madanhmuc);
            }
            load();
        }
        private void load()
        {
            txtId.Visible = false;
            txtId.Text = "0";
            var data = db.tbl_Medicine.ToList();
            cbDanhmuc.SelectedIndex = 0;
            cbTenthuoc.SelectedIndex = 0;
            gridData.DataSource = data;
            gridData.Columns[1].HeaderText = "Mã thuốc";
            gridData.Columns[2].HeaderText = "Tên thuốc";
            gridData.Columns[3].HeaderText = "Danh mục thuốc";
            gridData.Columns[4].HeaderText = "Số lượng thuốc";
            gridData.Columns[5].HeaderText = "Ngày nhập thuốc";
            gridData.Columns[6].HeaderText = "Giá nhập thuốc";
            gridData.Columns[7].HeaderText = "Giá bán thuốc";
            gridData.Columns[8].HeaderText = "Tên nhân viên";
            gridData.Columns[0].Width = 30;
            gridData.Columns[1].Width = 50;
            gridData.Columns[3].Width = 50;
            gridData.Columns[4].Width = 70;
            gridData.Columns[5].Width = 110;
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
            add.Tenthuoc = cbTenthuoc.SelectedItem.ToString();
            add.Addwho = txtTennv.Text;
            add.Danhmuc = cbDanhmuc.SelectedItem.ToString();
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
                update.Tenthuoc = cbTenthuoc.SelectedItem.ToString();
                update.Addwho = txtTennv.Text;
                update.Danhmuc = cbDanhmuc.SelectedItem.ToString();
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
            try
            {
                int id;
                id = Convert.ToInt32(txtId.Text);
                var data = db.tbl_Medicine.Where(p => p.Id == id).First();
                db.tbl_Medicine.Remove(data);
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

        private void gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.Rows.Count > 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectrow = gridData.Rows[index];
                txtId.Text = selectrow.Cells[0].Value.ToString();
                txtMathuoc.Text = selectrow.Cells[1].Value.ToString();
                txtTenthuoc.Text = selectrow.Cells[2].Value.ToString();
                txtSoluong.Text = selectrow.Cells[4].Value.ToString();
                txtGiamua.Text = selectrow.Cells[6].Value.ToString();
                txtGiaban.Text = selectrow.Cells[7].Value.ToString();
            }
        }

        private void cbDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = cbDanhmuc.SelectedItem.ToString();
                var thuoc = db.tbl_Thuoc.Where(p => p.Madanhmuc == dt).ToArray();
                cbTenthuoc.Text = "";
                cbTenthuoc.Items.Clear();
                for (int i = 0; thuoc.Length > i; i++)
                {
                    cbTenthuoc.Items.Add(thuoc[i].Tenthuoc);
                }
                cbTenthuoc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTenthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = cbTenthuoc.SelectedItem.ToString();
            var thuoc = db.tbl_Thuoc.Where(p => p.Tenthuoc == dt).FirstOrDefault();
            txtMathuoc.Text = thuoc.Mathuoc;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGiaban.Text = "";
            txtGiamua.Text = "";
            txtId.Text = "0";
            txtTenthuoc.Text = "";
            txtSoluong.Text = "";
        }
    }
}