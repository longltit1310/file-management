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
    public partial class frmThongKePhieuMuon : Form
    {
        private string mapm;

        public frmThongKePhieuMuon()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmThongKePhieuMuon_Load(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var ds = (from s in db.mains where s.ThoiGianMuon == DateTime.Now select s).ToList();
            dataGridView1.DataSource = ds;
            lblsach.Text = ds.Count.ToString();
            var dem = (from s in db.mains where s.ThoiGianMuon == DateTime.Now select s.MaHV).Distinct().ToList();
            lbldg.Text = dem.Count.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (frmTraSach f = new frmTraSach(mapm))
            {
                f.ShowDialog();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            mapm = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
        }
    }
}
