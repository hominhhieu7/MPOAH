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
            griduser.DataSource = db.tbl_Employee.ToList();
        }
    }
}