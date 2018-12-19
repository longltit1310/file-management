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
    public partial class frmRangBuoc : Form
    {
        public frmRangBuoc()
        {
            InitializeComponent();
        }

        private void frmRangBuoc_Load(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.RangBuocs select s).ToList();
            gtrb1.Text = Lst[0].GiaTri.ToString();
            gtrb2.Text = Lst[1].GiaTri.ToString();
            rb1.Text = Lst[0].Tenrb.ToString();
            rb2.Text = Lst[1].Tenrb.ToString();


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                dataDataContext db = new dataDataContext();
                var Lst = (from s in db.RangBuocs select s).ToList();
                Lst[0].GiaTri = int.Parse(gtrb1.Text);
                Lst[1].GiaTri = int.Parse(gtrb2.Text);
                MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
