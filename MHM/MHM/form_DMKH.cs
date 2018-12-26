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

namespace MHM
{
    public partial class form_DMKH : Form
    {
        QLHTEntities db = new QLHTEntities();
        public form_DMKH()
        {
            InitializeComponent();
        }

        private void form_DMKH_Load(object sender, EventArgs e)
        {
            
            cbGioitinh.Items.Add("Nam");
            cbGioitinh.Items.Add("Nữ");
            txtId.Text = "0";
            dtGrid.ColumnCount = 7;
            dtGrid.Columns[0].Name = "STT";
            dtGrid.Columns[1].Name = "Họ và tên";
            dtGrid.Columns[2].Name = "Địa chỉ";
            dtGrid.Columns[3].Name = "Giới tính";
            dtGrid.Columns[4].Name = "Tuổi";
            dtGrid.Columns[5].Name = "Số điện thoại";
            dtGrid.Columns[6].Name = "Ghi chú";
            load();
        }
        private void load()
        {
            dtGrid.Rows.Clear();
            var data = db.tbl_Customer.ToArray();
            for(int i = 0; data.Length > i; i++)
            {
                dtGrid.Rows.Add(data[i].Id, data[i].Hovaten, data[i].Diachi, data[i].Gioitinh, data[i].Tuoi,"0"+data[i].Sodienthoai, data[i].Ghichu);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var add = new tbl_Customer();
            add.Hovaten = txtHoten.Text;
            add.Diachi = txtDiachi.Text;
            add.Sodienthoai = Convert.ToInt64(txtSdt.Text);
            add.Tuoi = Convert.ToInt32(txtTuoi.Text);
            add.Gioitinh = cbGioitinh.SelectedItem.ToString();
            add.Ghichu = txtGhichu.Text;
            if(id == 0)
            {
                db.tbl_Customer.Add(add);
                db.SaveChanges();
                load();
            }
            else
            {
                var data = db.tbl_Customer.Where(p => p.Id == id).First();
                data.Hovaten = txtHoten.Text;
                data.Diachi = txtDiachi.Text;
                data.Sodienthoai = Convert.ToInt64(txtSdt.Text);
                data.Tuoi = Convert.ToInt32(txtTuoi.Text);
                data.Gioitinh = cbGioitinh.SelectedItem.ToString();
                data.Ghichu = txtGhichu.Text;
                db.SaveChanges();
                load();
            }
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid.Rows.Count > 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectrow = dtGrid.Rows[index];
                txtId.Text = selectrow.Cells[0].Value.ToString();
                txtHoten.Text = selectrow.Cells[1].Value.ToString();
                txtDiachi.Text = selectrow.Cells[2].Value.ToString();
                cbGioitinh.Text =selectrow.Cells[3].Value.ToString();
                txtTuoi.Text = selectrow.Cells[4].Value.ToString();
                txtSdt.Text = selectrow.Cells[5].Value.ToString();
                if(txtGhichu.Text != "")
                {
                    txtGhichu.Text = selectrow.Cells[6].Value.ToString();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = Convert.ToInt32(txtId.Text);
                var data = db.tbl_Customer.Where(p => p.Id == id).First();
                db.tbl_Customer.Remove(data);
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
    }
}
