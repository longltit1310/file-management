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
    public partial class frmMuonTra : Form
    {
        private int id;
        List<ChiTietPhieuMuon> list = new List<ChiTietPhieuMuon>();
        List<ctpm> list2 = new List<ctpm>();
        private int toida = 0;
        private int mactpm = 0;
        ctpm chitiet = new ctpm();
        private string mapm;
        private string mact;
        private int rbngay;
        private int rbsosachtoida;
        public frmMuonTra(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.Saches where s.MaS.Contains(txtmas.Text) select s).ToList();
            if (Lst.Count > 0)
            {
                if(Lst[0].TinhTrang == true)
                {
                    txttensach.Text = Lst[0].TenSach.ToString();
                }
                else
                {
                    MessageBox.Show("Sách đã được mượn");

                }
                //  txttennxb.Text = Lst[0].TenNXB.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var kt = (from s in db.ctpms where s.ThoiGianMuon == datengaymuon.Value.Date && s.MaHV == txtmadg.Text select s).ToList();
            toida = kt.Count();
            var Lst = (from s in db.HoiViens where s.MaHV.Contains(txtmadg.Text) select s).ToList();
            if (Lst.Count > 0)
            {
                txttendg.Text = Lst[0].TenHoiVien.ToString();
                //  txttennxb.Text = Lst[0].TenNXB.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
                load();
            }
            MessageBox.Show("Số sách đã mượn hôm nay : " + toida.ToString());
            var sachdamuon = (from s in db.ctpms where s.MaHV == txtmadg.Text select s).ToList();
            List<ctpm> list3 = new List<ctpm>();

            foreach(ctpm a in sachdamuon)
            {
                list3.Add(a);
            }
            dataGridView1.DataSource = list3;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(id.ToString());
            datengaymuon.Value = DateTime.Now;
            load();
        }
        private void load()
        {
            datengaymuon.Value = DateTime.Now;
            dataDataContext db = new dataDataContext();
            var nv = (from s in db.NhanViens where s.userid == id select s.MaNv).ToArray();
            var Lst = (from s in db.PhieuMuons orderby s.MaPM descending select s.MaPM.Substring(2)).ToList();
            //load du lieu len view
            var load1 = (from s in db.ctpms orderby s.MaPM descending select s).ToList();

            var Lst2 = (from s in db.ChiTietPhieuMuons select s.MaCTPM.Substring(4)).ToList();
            
            // ListViewItem ls = new ListViewItem();
            int m = 0;
            foreach (string x in Lst)
            {
                int k = int.Parse(x);
                if (k > m)
                    m = k;
            }
            int a = m + 1;
            dataGridView1.DataSource = load1.ToList();
            chitiet.Manv = nv[0].ToString();
            
            foreach (string x in Lst2)
            {
                int k = int.Parse(x);
                if (k > mactpm)
                    mactpm = k;
            }
            //mactpm = Lst2.Count();
           //MessageBox.Show(mactpm.ToString());
            txtpm.Text = "PM" + a.ToString();
            txttendg.Text = "";
            txttensach.Text = "";    
            //load rang buoc
            var rb = (from s in db.RangBuocs select s).ToArray();
            rbngay = rb[0].GiaTri.Value;
            rbsosachtoida = rb[1].GiaTri.Value;
           // MessageBox.Show(rbngay.ToString() + rbsosachtoida.ToString());
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txttendg.Text != "")
            {
                if (txttensach.Text != "")
                {
                    dataDataContext db = new dataDataContext();
                    var Lst = (from s in db.ChiTietPhieuMuons select s).ToList();
                    if (toida + 1 > rbsosachtoida)
                    {
                        MessageBox.Show("Số sách mượn đã vượt quá quy định", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        toida = toida + 1;
                        mactpm = mactpm + 1;
                        // ListViewItem ls = new ListViewItem();
                        add_to_data();
                        hienthi();
                        txttensach.Text = "";
                        txtmas.Text = "S";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng cho biết tên sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng cho biết tên đọc giả", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
           
        }
        private void add_to_data()
        {
           
                
                    ChiTietPhieuMuon ctpm1 = new ChiTietPhieuMuon();
                    ctpm1.MaCTPM = "CTPM" + mactpm.ToString();
                    ctpm1.MaPM = txtpm.Text;
                    ctpm1.MaS = txtmas.Text;
                    list.Add(ctpm1);

        }
        private void hienthi()
        {
            ctpm chitiet1 = new ctpm();
            chitiet1.Manv = chitiet.Manv;
            chitiet1.MaCTPM = "CTPM" + mactpm.ToString();
            chitiet1.MaHV = txtmadg.Text;
            chitiet1.MaPM = txtpm.Text;
            chitiet1.TenHoiVien = txttendg.Text;
            chitiet1.TenSach = txttensach.Text;
            chitiet1.ThoiGianMuon = datengaymuon.Value.Date;
            chitiet1.HanTraSach = datengaymuon.Value.Date.AddDays(rbngay);
            list2.Add(chitiet1);
            dataGridView1.DataSource = list2.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                dataDataContext db = new dataDataContext();
                dataDataContext db1 = new dataDataContext();
               
                PhieuMuon pm = new PhieuMuon();
                pm.MaPM = txtpm.Text;
                pm.MaHV = txtmadg.Text;
                pm.ThoiGianMuon = datengaymuon.Value.Date;
                pm.Manv = chitiet.Manv;
                pm.HanTraSach = datengaymuon.Value.Date.AddDays(rbngay);
                db1.PhieuMuons.InsertOnSubmit(pm);
               // MessageBox.Show(pm.MaHV.ToString() + pm.MaPM.ToString() + pm.Manv.ToString());
                db1.SubmitChanges();
                foreach (ChiTietPhieuMuon prime in list)
                {
                    ChiTietPhieuMuon imp = prime;
                    db.ChiTietPhieuMuons.InsertOnSubmit(imp);
                    MessageBox.Show(prime.MaCTPM.ToString());
                    var sa = (from s in db.Saches where s.MaS == imp.MaS select s).First();
                    sa.TinhTrang = false;
                     db.SubmitChanges();
                    
                    // MessageBox.Show(prime.MaCTPM.ToString() + prime.MaPM.ToString() + prime.MaS.ToString());
                }
                MessageBox.Show("Thêm thành công");
                load();
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("xay ra loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            load();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.ctpms where s.TenHoiVien.Contains(txttim.Text) select s).ToList();
            if(Lst.Count > 0)
            {
                dataGridView1.DataSource = Lst;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
            }
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
            mact = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();

            //btnxoa.Visible = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
               
                var Lst = (from s in db.ChiTietPhieuMuons where s.MaCTPM == mact select s).First();
                try
                {
                    //MessageBox.Show(Lst.MaS);
                    db.ChiTietPhieuMuons.DeleteOnSubmit(Lst);
                    db.SubmitChanges();
                    MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK);
                   
                    load();
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi", "Thông báo", MessageBoxButtons.OK);


                }
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
