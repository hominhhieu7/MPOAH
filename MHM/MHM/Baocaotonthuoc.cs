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
    public partial class Baocaotonthuoc : Form
    {
        QLHTEntities db = new QLHTEntities();
        public Baocaotonthuoc()
        {
            InitializeComponent();
        }
        public void load()
        {
            var data = db.sp_ReportMedicine_List().ToList();
            dtGird.DataSource = data;
        }

        private void Baocaotonthuoc_Load(object sender, EventArgs e)
        {
            load();
            dtGird.Columns[0].Name = "Mã thuốc";
            dtGird.Columns[1].Name = "Tên thuốc";
            dtGird.Columns[2].Name = "Số lượng thuốc còn tồn";
            dtGird.Columns[0].Width = 200;
            dtGird.Columns[1].Width = 200;
            dtGird.Columns[2].Width = 200;
        }
    }
}
