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

namespace MHM
{
    public partial class quanlyuser : DevExpress.XtraEditors.XtraForm
    {
        QLHTEntities db = new QLHTEntities();
        public quanlyuser()
        {
            InitializeComponent();
        }

        private void quanlyuser_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            cbChucvu.Items.Add("GD");
            cbChucvu.Items.Add("NV");
            load();
        }
        private void load()
        {
            griduser.DataSource = db.tbl_Employee.ToList();
            griduser.Columns[0].HeaderText = "ID";
            griduser.Columns[1].HeaderText = "Họ và tên";
            griduser.Columns[2].HeaderText = "Địa chỉ";
            griduser.Columns[3].HeaderText = "Số điện thoại";
            griduser.Columns[4].HeaderText = "User name";
            griduser.Columns[5].HeaderText = "Password";
            griduser.Columns[6].HeaderText = "Chức vụ";
        }
        private void txtSave_Click(object sender, EventArgs e)
        {
            var add = new tbl_Employee();
            int id;
            id = Convert.ToInt32(txtId.Text);
            add.Hovaten = txtHoten.Text;
            add.Password = txtPassword.Text;
            add.Sodienthoai = Convert.ToInt32(txtSdt.Text);
            add.Username = txtUsername.Text;
            add.Diachi = txtDiachi.Text;
            add.Position = cbChucvu.SelectedItem.ToString();
            if (id == 0)
            {
                db.tbl_Employee.Add(add);
                MessageBox.Show("Đã lưu!!!", "Thông báo", MessageBoxButtons.OK);
                load();
            }
            else
            {
                    tbl_Employee employee = db.tbl_Employee.Where(p => p.Id == id).Select(p => p).FirstOrDefault();
                    employee.Hovaten = txtHoten.Text;
                    employee.Password = txtPassword.Text;
                    employee.Sodienthoai = Convert.ToInt32(txtSdt.Text);
                    employee.Username = txtUsername.Text;
                    employee.Diachi = txtDiachi.Text;
                    employee.Position = cbChucvu.SelectedItem.ToString();
                    db.SaveChanges();
                    MessageBox.Show("Đã lưu!!!", "Thông báo", MessageBoxButtons.OK);
                    load();
                
            }
            db.SaveChanges();
            load();
        }

        private void griduser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(griduser.Rows.Count > 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectrow = griduser.Rows[index];
                txtId.Text = selectrow.Cells[0].Value.ToString();
                txtHoten.Text = selectrow.Cells[1].Value.ToString();
                txtDiachi.Text = selectrow.Cells[2].Value.ToString();
                txtSdt.Text = selectrow.Cells[3].Value.ToString();
                txtUsername.Text = selectrow.Cells[4].Value.ToString();
                txtPassword.Text = selectrow.Cells[5].Value.ToString();
                cbChucvu.SelectedItem = selectrow.Cells[6].Value.ToString();
                //foreach(DataGridViewRow row in griduser.SelectedRows)
                //{
                //    txtHoten.Text = row.Cells[1].Value.ToString();
                //    txtDiachi.Text = row.Cells[2].Value.ToString();
                //    txtSdt.Text = row.Cells[3].Value.ToString();
                //    txtUsername.Text = row.Cells[4].Value.ToString();
                //    txtPassword.Text = row.Cells[5].Value.ToString();
                //    cbChucvu.SelectedItem = row.Cells[6].Value.ToString();
                //}
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtId.Text);
            var data = db.tbl_Employee.Where(p => p.Id == id).First();
            db.tbl_Employee.Remove(data);
            db.SaveChanges();
            load();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "0";
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbChucvu.SelectedItem = "";
        }
    }
}