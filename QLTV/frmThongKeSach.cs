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
    public partial class frmThongKeSach : Form
    {
        public frmThongKeSach()
        {
            InitializeComponent();
        }

        private void frmThongKeSach_Load(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.Saches select s).ToList();
            var sachchomuon = (from s in db.Saches where s.TinhTrang == false select s).ToList();
            lbltong.Text = Lst.Count.ToString();
            lblmuon.Text = sachchomuon.Count.ToString();
            lbltrue.Text = (Lst.Count - sachchomuon.Count).ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
