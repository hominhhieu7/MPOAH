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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using MHM.Model;

namespace MHM
{
    public partial class form_Banthuoc : Form
    {
        QLHTEntities db = new QLHTEntities();
        public form_Banthuoc()
        {
            InitializeComponent();
        }

        private void form_Banthuoc_Load(object sender, EventArgs e)
        {
            dtGrid.ColumnCount = 8;
            txtidkach.Visible = false;
            txtidthuoc.Visible = false;
            txttongtien.Text = "0";
            dtGrid.Columns[0].Name = "Id khách hàng";
            dtGrid.Columns[1].Name = "Tên khách hàng";
            dtGrid.Columns[2].Name = "Người tạo";
            dtGrid.Columns[3].Name = "Tên thuốc";
            dtGrid.Columns[4].Name = "Số lượng";
            dtGrid.Columns[5].Name = "Giá sản phẩm";
            dtGrid.Columns[6].Name = "Tổng tiền";
            dtGrid.Columns[7].Name = "idthuoc";
            dtGrid.Columns[7].Visible = false;
            dtGrid.Columns[0].Width = 50;
            dtGrid.Columns[1].Width = 150;
            dtGrid.Columns[2].Width = 100;
            dtGrid.Columns[3].Width = 105;
            dtGrid.Columns[4].Width = 105;
            dtGrid.Columns[5].Width = 100;
            dtGrid.Columns[6].Width = 100;
            var kh = db.tbl_Customer.ToList();
            var thuoc = db.tbl_Medicine.GroupBy(p => p.Tenthuoc).ToList();
            foreach(var itemkh in kh)
            {
                cbKH.Items.Add(itemkh.Hovaten);
            }
            foreach(var itemthuoc in thuoc)
            {
                cbthuoc.Items.Add(itemthuoc.Key);
            }
            cbKH.SelectedItem = 0;
            cbthuoc.SelectedItem = 0;
        }

        int tongsp = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int check=0;
            if (cbKH.SelectedItem != null && cbthuoc.SelectedItem != null)
            {
                if (int.TryParse(txtsoluong.Text, out check))
                {
                    var thanhtien = Convert.ToDecimal(txtgiaban.Text) * Convert.ToInt32(txtsoluong.Text);
                    int ii= 0;
                    for (int i = 0; i < dtGrid.Rows.Count; i++)
                    {
                        if(txtidthuoc.Text == dtGrid.Rows[i].Cells[7].Value.ToString())
                        {
                            dtGrid.Rows[i].Cells[4].Value = Convert.ToInt32(dtGrid.Rows[i].Cells[4].Value) + Convert.ToInt32(txtsoluong.Text);
                            dtGrid.Rows[i].Cells[6].Value = Convert.ToDecimal(dtGrid.Rows[i].Cells[6].Value) + (Convert.ToDecimal(txtsoluong.Text) * Convert.ToDecimal(txtgiaban.Text));
                            ii ++;
                        }
                    }
                    if (ii == 0)
                    {
                        dtGrid.Rows.Add(txtidkach.Text, cbKH.SelectedItem.ToString(), Infor.Tennv, cbthuoc.SelectedItem.ToString(), txtsoluong.Text,txtgiaban.Text, thanhtien, txtidthuoc.Text);
                        tongsp++;
                        lbtongsp.Text = Convert.ToString(tongsp);
                    }
                     txttongtien.Text = Convert.ToString(thanhtien + Convert.ToDecimal(txttongtien.Text));

                }
                else MessageBox.Show("Vui lòng nhập đúng số lượng", "Cảnh báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng hoặc chọn thuốc", "Cảnh báo");
            }
            
            
        }
        private void cbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKH.SelectedItem != null)
            {
                var dt = cbKH.SelectedItem.ToString();
                var kh = db.tbl_Customer.Where(p => p.Hovaten == dt).First();
                txtdiachi.Text = kh.Diachi;
                txttuoi.Text = Convert.ToString(kh.Tuoi);
                txtidkach.Text = Convert.ToString(kh.Id);
            }
            

        }

        private void cbthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbthuoc.SelectedItem !=null)
            {
                var dt = cbthuoc.SelectedItem.ToString();
                var thuoc = db.tbl_Medicine.Where(p => p.Tenthuoc == dt).First();
                txtmathuoc.Text = thuoc.Mathuoc;
                txtgiaban.Text = Convert.ToString(thuoc.Giaban);
                txtidthuoc.Text = Convert.ToString(thuoc.Id);
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell item in dtGrid.SelectedCells)
                {
                    if (item.Selected)
                    {
                        if (dtGrid.SelectedCells.Count > 0)
                        {
                            int selectedrowindex = dtGrid.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = dtGrid.Rows[selectedrowindex];
                            txttongtien.Text = Convert.ToString(Convert.ToDecimal(txttongtien.Text) - Convert.ToDecimal(selectedRow.Cells[6].Value));
                        }
                        dtGrid.Rows.RemoveAt(item.RowIndex);
                        lbtongsp.Text = Convert.ToString(Convert.ToInt32(lbtongsp.Text) -1);
                        tongsp--;
                    }
                        
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Cảnh báo!!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtGrid.Rows.Clear();
            txtgiaban.Text = "";
            txtdiachi.Text = "";
            txtidkach.Text = "";
            txtidthuoc.Text = "";
            txtmathuoc.Text = "";
            txtsoluong.Text = "";
            txttongtien.Text = "0";
            txttuoi.Text = "";
            lbtongsp.Text = "0";
            cbKH.SelectedItem = null;
            cbthuoc.SelectedItem = null;
            tongsp = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                var createby = Infor.Tennv;
                var totalproduct = lbtongsp.Text;
                var tongtien = txttongtien.Text;
                var dataorder = db.Database.SqlQuery<int>("exec sp_Order_Save 0," + txtidkach.Text + ",'" + cbKH.Text + "','OD" + DateTime.Now.ToString("hh-mm-ss") + "','" + createby + "'," + totalproduct + "," + tongtien + "").FirstOrDefault();
                for (int i = 0; i < dtGrid.Rows.Count; i++)
                {
                    db.Database.SqlQuery<string>("exec sp_OrderDetail_Save " + dataorder + "," + dtGrid.Rows[i].Cells[7].Value + "," + dtGrid.Rows[i].Cells[4].Value + "," + dtGrid.Rows[i].Cells[5].Value + "," + dtGrid.Rows[i].Cells[6].Value + "").FirstOrDefault();
                    db.Database.SqlQuery<string>("sp_Product_UpdateOrder " + dtGrid.Rows[i].Cells[7].Value + "," + dtGrid.Rows[i].Cells[4].Value).FirstOrDefault();
                }
                MessageBox.Show("Đã lưu", "Thành Công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            
        }
    }
}
