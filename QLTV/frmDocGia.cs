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
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void rcheckDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void reload()
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.docgias select s).ToList();
            //  ListViewItem ls = new ListViewItem();
            dataGridView1.DataSource = Lst;
            var lhv = (from s in db.LoaiHoiViens select s).ToList();

            cbblhv.DataSource = lhv.ToList();
            cbblhv.DisplayMember = "TenLoaiHV";
            cbblhv.ValueMember = "MaLoaiHV";

            var Lstdg = (from s in db.docgias select s.MaHV.Substring(2)).ToList();
            int m = 0;
            foreach (string x in Lstdg)
            {
                int k = int.Parse(x);
                if (k > m)
                    m = k;
            }
            int a = m + 1;
            txtMaDocGia.Text = "DG" + a.ToString();
            txtHoten.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtCMND.Text = "";
            txtDienThoai.Text = "";
            txtmssv.Text = "";
            btnnhaplai.Visible = true;
            btnthem.Visible = true;
            btnsua.Visible = false;
            btnxoa.Visible = false;
        

        }
        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            //dataDataContext db = new dataDataContext();
            //var Lst = (from s in db.docgias select s).ToList();
            ////  ListViewItem ls = new ListViewItem();
            //dataGridView1.DataSource = Lst;
            //var lhv = (from s in db.LoaiHoiViens select s).ToList();
            //cbblhv.DataSource = lhv.ToList();
            //cbblhv.DisplayMember = "TenLoaiHV";
            //cbblhv.ValueMember = "MaLoaiHV";

            //int ma = Lst.Count + 1;
            //txtMaDocGia.Text = "DG" + ma.ToString();
            reload();
        }
        private void add()
        {
            try
            {
                dataDataContext db = new dataDataContext();
                HoiVien hv = new HoiVien();
                hv.MaHV = txtMaDocGia.Text;
                hv.TenHoiVien = txtHoten.Text;
                hv.MaLoaiHV = cbblhv.SelectedValue.ToString();
                hv.MaSV = txtmssv.Text;
                hv.CMND = txtCMND.Text;
                hv.DiaChi = txtDiaChi.Text;
                hv.Email = txtEmail.Text;
                if (checkBox1.Checked == true)
                {
                    hv.GioiTinh = true;
                }
                else
                {
                    hv.GioiTinh = false;
                }
                hv.SDT = txtDienThoai.Text;

                string theDate = dateNgayLapThe.Value.ToString("yyyy-MM-dd");
                DateTime dt = dateNgayLapThe.Value.Date;
                DateTime dt2 = dateNgaySinh.Value.Date;
                hv.NgayLapThe = dt;
                hv.NgaySinh = dt2;
                // MessageBox.Show(hv.MaHV.ToString() + hv.GioiTinh.ToString() + hv.NgaySinh.ToString() + hv.NgayLapThe.ToString() + hv.MaLoaiHV.ToString());
                db.HoiViens.InsertOnSubmit(hv);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
                reload();

            }
            catch (Exception ex)
            {

                MessageBox.Show("xay ra loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txtHoten.Text != "")
            {
               if(txtmssv.Text != "")
               {
                   if(txtCMND.Text != "")
                   {
                       if(txtDiaChi.Text != "")
                       {
                           add();
                       }
                       else
                       {
                           MessageBox.Show("Vui lòng nhập địa chỉ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                   }
                   else
                   {
                       MessageBox.Show("Vui lòng số chứng minh nhân dân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   }
               }
               else
               {
                   MessageBox.Show("Vui lòng mã số sinh viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Không được nhập chữ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtmssv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Không được nhập chữ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Không được nhập chữ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void txtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Không được nhập số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.docgias where s.TenHoiVien.Contains(txttim.Text) select s).ToList();
            if (Lst.Count > 0)
            {
                dataGridView1.DataSource = Lst;
                txtHoten.Text = Lst[0].TenHoiVien.ToString();
                txtmssv.Text = Lst[0].MaSV.ToString();
                txttim.Clear();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
                txttim.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnds_Click(object sender, EventArgs e)
        {
      
            reload();
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnnhaplai.Visible = false;
            btnthem.Visible = false;
            btnsua.Visible = true;
            btnxoa.Visible = true;
            int row = dataGridView1.CurrentRow.Index;
            txtMaDocGia.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            txtHoten.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            txtDienThoai.Text = dataGridView1.Rows[row].Cells[7].Value.ToString().Trim();
            txtDiaChi.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();
            txtCMND.Text = dataGridView1.Rows[row].Cells[10].Value.ToString().Trim();
            txtEmail.Text = dataGridView1.Rows[row].Cells[8].Value.ToString().Trim();
            txtmssv.Text = dataGridView1.Rows[row].Cells[4].Value.ToString().Trim();
            
            dataDataContext db = new dataDataContext();
            string ser = txtMaDocGia.Text;
            //var sa = (from s in db.Saches where s.MaS == ser select s).First();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
                string ser = txtMaDocGia.Text;
                var hv = (from s in db.HoiViens where s.MaHV == ser select s).First();
                hv.TenHoiVien = txtHoten.Text;
                hv.MaLoaiHV = cbblhv.SelectedValue.ToString();
                hv.MaSV = txtmssv.Text;
                hv.CMND = txtCMND.Text;
                hv.DiaChi = txtDiaChi.Text;
                hv.Email = txtEmail.Text;
                if (checkBox1.Checked == true)
                {
                    hv.GioiTinh = true;
                }
                else
                {
                    hv.GioiTinh = false;
                }
                hv.SDT = txtDienThoai.Text;
                string theDate = dateNgayLapThe.Value.ToString("yyyy-MM-dd");
                DateTime dt = dateNgayLapThe.Value.Date;
                DateTime dt2 = dateNgaySinh.Value.Date;
                hv.NgayLapThe = dt;
                hv.NgaySinh = dt2;
                // MessageBox.Show(hv.MaHV.ToString() + hv.GioiTinh.ToString() + hv.NgaySinh.ToString() + hv.NgayLapThe.ToString() + hv.MaLoaiHV.ToString());

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    reload();
                   
                }
                catch
                {
                    MessageBox.Show("lỗi", "Thông báo", MessageBoxButtons.OK);

                }
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
                string ser = txtMaDocGia.Text;
                var Lst = (from s in db.HoiViens where s.MaHV == ser select s).First();
                try
                {
               
                    db.HoiViens.DeleteOnSubmit(Lst);
                    db.SubmitChanges();
                    MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK);
                    reload();
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

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
