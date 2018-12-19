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
    public partial class frmTraSach : Form
    {
        private string ma;
        private string mactpm;
        public frmTraSach(string ma)
        {
            this.ma = ma;
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void load()
        {
            dataDataContext db = new dataDataContext();
            var ct = (from s in db.ctpms where s.MaPM == ma orderby s.MaCTPM select s).ToList();
            dataGridView1.DataSource = ct;
        }
        private void frmTraSach_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            mactpm = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            string tensach = dataGridView1.Rows[row].Cells[4].Value.ToString().Trim();

            MessageBox.Show(tensach.ToString(), "Tên sách");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try{
                dataDataContext db = new dataDataContext();
                var mas = (from s in db.ChiTietPhieuMuons where s.MaCTPM == mactpm select s.MaS).First().ToString();
                var tt = (from s in db.ChiTietPhieuMuons where s.MaCTPM == mactpm select s).First();
                if(tt.TinhTrang == true)
                {
                    MessageBox.Show("Sách đã được trả");
                }
                else
                 {
                     tt.TinhTrang = true;
                     db.SubmitChanges();

                     dataDataContext db1 = new dataDataContext();
                     var sach = (from s in db1.Saches where s.MaS == mas orderby s.MaS select s).First();
                     sach.TinhTrang = true;
                     db1.SubmitChanges();
                     MessageBox.Show("Hoàn thành");
                     load();
                  }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Xảy ra lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
