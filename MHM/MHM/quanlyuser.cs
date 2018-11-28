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
            cbChucvu.Items.Add("GD");
            cbChucvu.Items.Add("NV");
            griduser.DataSource = db.tbl_Employee.ToList();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            var obj = new Object();
            
        }

        private void griduser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(griduser.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in griduser.SelectedRows)
                {
                    txtHoten.Text = row.Cells[1].Value.ToString();
                    txtDiachi.Text = row.Cells[2].Value.ToString();
                    txtSdt.Text = row.Cells[3].Value.ToString();
                    txtUsername.Text = row.Cells[4].Value.ToString();
                    txtPassword.Text = row.Cells[5].Value.ToString();
                    cbChucvu.SelectedItem = row.Cells[6].Value.ToString();
                }
            }
        }
    }
}