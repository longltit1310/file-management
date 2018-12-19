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
    public partial class Main : Form
    {
        private int id;
        public Main(int a)
        {
            this.id = a;
            InitializeComponent();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien ds = new frmNhanVien();
            ds.MdiParent = this;
            ds.Show();
        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (frmSach f = new frmSach())
            //{
            //    f.ShowDialog();
            //}
            frmSach ds = new frmSach();
            ds.MdiParent = this;
            ds.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            using (frmThemDocGia f = new frmThemDocGia())
            {
                f.ShowDialog();
            }
        }

        private void danhMụcNhàXuâtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan ds = new frmNhaXuatBan();
            ds.MdiParent = this;
            ds.Show();
        }

        private void danhMụcPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocGia ds = new frmDocGia();
            ds.MdiParent = this;
            ds.Show();
        }

        private void danhMụcTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmTacGia f = new frmTacGia())
            {
                f.ShowDialog();
            }
        }

        private void quảnLýCácRàngBuộcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            using (frmRangBuoc f = new frmRangBuoc())
            {
                f.ShowDialog();
            }
        }

        private void danhMụcĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonTra ds = new frmMuonTra(this.id);
            ds.MdiParent = this;
            ds.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.TaiKhoans where s.userid == id select s ).ToList();
            // ListViewItem ls = new ListViewItem();
            dataDataContext db1 = new dataDataContext();
            int us = Lst[0].userid;
            var Lst2 = (from s in db1.NhanViens where s.userid == us select s).ToList();
            if (Lst[0].role.ToString() == "True")
            {
                danhMụcNhânViênToolStripMenuItem.Enabled = true;
                quảnLýCácRàngBuộcToolStripMenuItem1.Enabled = true;
                thốngKêToolStripMenuItem.Enabled = true;
                quảnLýDanhMụcTàiKhoảnToolStripMenuItem.Enabled = true;
                toolStripButton5.Enabled = true;
                toolStripLabel5.Enabled = true;
                MessageBox.Show("Xin Chao " + Lst2[0].TenNv.ToString() + "\nChức vụ admin", "\nChức vụ admin");
            }
            else
            {
                MessageBox.Show("Xin Chao " + Lst2[0].TenNv.ToString() + "\nChức vụ user", "\nChức vụ user");

            }
           // MessageBox.Show(Lst[0].role.ToString());
            frmThongKePhieuMuon ds = new frmThongKePhieuMuon();
            ds.MdiParent = this;
            ds.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (frmThemDocGia f = new frmThemDocGia())
            {
                f.ShowDialog();
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            frmMuonTra ds = new frmMuonTra(this.id);
            ds.MdiParent = this;
            ds.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmMuonTra ds = new frmMuonTra(this.id);
            ds.MdiParent = this;
            ds.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            frmThongKePhieuMuon ds = new frmThongKePhieuMuon();
            ds.MdiParent = this;
            ds.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmThongKeSach f = new frmThongKeSach())
            {
                f.ShowDialog();
            }
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmThongKeNhanVien f = new frmThongKeNhanVien())
            {
                f.ShowDialog();
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            frmSach ds = new frmSach();
            ds.MdiParent = this;
            ds.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmSach ds = new frmSach();
            ds.MdiParent = this;
            ds.Show();
        }

        private void quảnLýDanhMụcTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            frmDocGia ds = new frmDocGia();
            ds.MdiParent = this;
            ds.Show();
        }
    }
}
