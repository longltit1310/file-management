using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmThongKeNhanVien : Form
    {
        public frmThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void frmThongKeNhanVien_Load(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.NhanViens select s).ToList();
            lbltong.Text = Lst.Count.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
