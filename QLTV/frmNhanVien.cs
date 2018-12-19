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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
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
            var Lst1 = (from s in db.NhanViens select s).ToList();
            var Lst = (from s in db.NhanViens select s.MaNv.Substring(2)).ToList();
           // ListViewItem ls = new ListViewItem();
            dataGridView1.DataSource = Lst1;
            int m = 0;
            foreach( string x in Lst)
            {
                int k = int.Parse(x);
                if (k > m)
                    m = k;
            }
            int a = m + 1;
            txtManv.Text = "NV" + a.ToString();


            var lst2 = (from s in db.TaiKhoans select s).ToList();
            int max2 = lst2.Max(r => r.userid);
            txtuserid.Text = (max2 + 1).ToString();
            txttk.Text = "";
            txtmk.Text = "";
            txtmk2.Text = "";

        }
        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.NhanViens where s.TenNv.Contains(txttim.Text) select s).ToList();
            if (Lst.Count > 0)
            {
                dataGridView1.DataSource = Lst;
                txtHoten.Text = Lst[0].TenNv.ToString();
                //  txttennxb.Text = Lst[0].TenNXB.ToString();
                txttim.Clear();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
                txttim.Clear();
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

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Không được nhập chữ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add()
        {
            try
            {
                dataDataContext db = new dataDataContext();
                NhanVien nv = new NhanVien();
                nv.MaNv = txtManv.Text;
                nv.TenNv = txtHoten.Text;
                nv.SDT = txtDienThoai.Text;
                nv.GioiTinh = checkBox1.Checked;
                nv.Email = txtEmail.Text;
                nv.CMND = txtCMND.Text;
                nv.DiaChi = txtDiaChi.Text;
                DateTime dt = dateNgaySinh.Value.Date;
                DateTime dt2 = datengayvaolam.Value.Date;
                nv.NgaySinh = dt;
                nv.NgayVaoLam = dt2;
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                // MessageBox.Show(hv.MaHV.ToString() + hv.GioiTinh.ToString() + hv.NgaySinh.ToString() + hv.NgayLapThe.ToString() + hv.MaLoaiHV.ToString());
                MessageBox.Show("Thêm nhân viên thành công");

                dataDataContext db1 = new dataDataContext();
                TaiKhoan us = new TaiKhoan();
                us.userid = int.Parse(txtuserid.Text);
                us.tentk = txttk.Text;
                us.pass = txtmk.Text;
                us.role = false;
                MessageBox.Show(us.tentk.ToString() + us.pass.ToString() + us.role.ToString() + us.userid.ToString());
                db1.TaiKhoans.InsertOnSubmit(us);
                db1.SubmitChanges();
                
                MessageBox.Show("Thêm thành công");
                reload();
                clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear()
        {
            txtHoten.Text = "";
            txtCMND.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text != "")
            {
                if (txtCMND.Text != "")
                {
                    if (txtDiaChi.Text != "")
                    {
                        if (txtDienThoai.Text != "")
                        {
                           if(txttk.Text != "")
                           {
                               if(txtmk.Text == txtmk2.Text)
                               {
                                   add();
                               }
                               else
                               {
                                   MessageBox.Show("Mật khẩu không khớp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                               }
                           }
                           else
                           {
                               MessageBox.Show("Vui lòng tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng số điện thoại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập địa chỉ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập chứng minh nhân dân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            clear();
            reload();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnnhaplai.Visible = false;
            btnthem.Visible = false;
            btnsua.Visible = true;
            btnxoa.Visible = true;
            int row = dataGridView1.CurrentRow.Index;
            txtManv.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            txtHoten.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            txtCMND.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();
            txtDienThoai.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();
            txtDiaChi.Text = dataGridView1.Rows[row].Cells[4].Value.ToString().Trim();
            txtEmail.Text = dataGridView1.Rows[row].Cells[8].Value.ToString().Trim();

        }

        private void btnds_Click(object sender, EventArgs e)
        {
            reload();
            clear();
            btnnhaplai.Visible = true;
            btnthem.Visible = true;
            btnsua.Visible = false;
            btnxoa.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
                string ser = txtManv.Text;
                var Lst = (from s in db.NhanViens where s.MaNv == ser select s).First();
                try
                {

                    db.NhanViens.DeleteOnSubmit(Lst);
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
                string ser = txtManv.Text;
                var nv = (from s in db.NhanViens where s.MaNv == ser select s).First();
              try
                {
                    nv.TenNv = txtHoten.Text;
                nv.SDT = txtDienThoai.Text;
                nv.GioiTinh = checkBox1.Checked;
                nv.Email = txtEmail.Text;
                nv.CMND = txtCMND.Text;
                nv.DiaChi = txtDiaChi.Text;
                DateTime dt = dateNgaySinh.Value.Date;
                DateTime dt2 = datengayvaolam.Value.Date;
                nv.NgaySinh = dt;
                nv.NgayVaoLam = dt2;
                db.SubmitChanges();
                // MessageBox.Show(hv.MaHV.ToString() + hv.GioiTinh.ToString() + hv.NgaySinh.ToString() + hv.NgayLapThe.ToString() + hv.MaLoaiHV.ToString());
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                reload();
                clear();
                btnnhaplai.Visible = true;
                btnthem.Visible = true;
                btnsua.Visible = false;
                btnxoa.Visible = false;
                   
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
    }
}
