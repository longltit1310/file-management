using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace QLTV
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void comboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            txtNamXB.Text = DateTime.Now.Year.ToString();
            load();
        }
        private void load()
        {
            dataDataContext db = new dataDataContext();
            var Lst = from s in db.TheLoais select s;
            comboTheLoai.DataSource = Lst.ToList();
            comboTheLoai.DisplayMember = "TenTL";
            comboTheLoai.ValueMember = "MaTL";
            
            var sach = from s in db.ThongTinSaches select s.MaS.Substring(1);
            var lssach = from s in db.ThongTinSaches select s;

            dataGridView1.DataSource = lssach.ToList();
            int m = 0;
            foreach (string x in sach)
            {
                int k = int.Parse(x);
                if (k > m)
                    m = k;
            }
           
            int a = m + 1;
            txtMaSach.Text = "S" + a.ToString();
            txtmanxb.Text = "NXB";
            txtNXB.Text = "";
            txtTenSach.Text = "";
            txtNamXB.Text = "";
            txtmatg.Text = "TG";
            txtTacGia.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.Saches where s.TenSach.Contains(txttim.Text) select s).ToList();
            if (Lst.Count > 0)
            {
                dataGridView1.DataSource = Lst;
                //txtTenSach.Text = Lst[0].TenSach.ToString();
              //  txttennxb.Text = Lst[0].TenNXB.ToString();
                txttim.Clear();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
                txttim.Clear();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.TacGias where s.MaTG.Contains(txtmatg.Text) select s).ToList();
            if (Lst.Count > 0)
            {
               // dataGridView1.DataSource = Lst;
                txtTacGia.Text = Lst[0].TenTg.ToString();
                //  txttennxb.Text = Lst[0].TenNXB.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.NhaXuatBans where s.MaNXB.Contains(txtmanxb.Text) select s).ToList();
            if (Lst.Count > 0)
            {
               // dataGridView1.DataSource = Lst;
                txtNXB.Text = Lst[0].TenNXB.ToString();
                //  txttennxb.Text = Lst[0].TenNXB.ToString();
              
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
            }
        }
        private void clear()
        {
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtNamXB.Text = DateTime.Now.Year.ToString();
            txtmatg.Text = "TG";
            txtmanxb.Text = "NXB";
        }
        private void add()
        {
            try
            {
                dataDataContext db = new dataDataContext();
                Sach s = new Sach();
                s.MaS = txtMaSach.Text;
                s.MaTG = txtmatg.Text;
                s.MaTl = comboTheLoai.SelectedValue.ToString();
                s.TenSach = txtTenSach.Text;
                s.NamXuatBan = int.Parse(txtNamXB.Text);
                s.MaNXB = txtmanxb.Text;
                s.TinhTrang = true;
                db.Saches.InsertOnSubmit(s);
                db.SubmitChanges();
                // MessageBox.Show(hv.MaHV.ToString() + hv.GioiTinh.ToString() + hv.NgaySinh.ToString() + hv.NgayLapThe.ToString() + hv.MaLoaiHV.ToString());
                MessageBox.Show("Thêm thành công");
                load();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("xay ra loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text != "")
            {
                if (txtNamXB.Text != "")
                {
                    if (txtTacGia.Text != "")
                    {
                        if (txtNXB.Text != "")
                        {
                            add();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhà xuất bản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập tác giả", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm xuất bản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Không được nhập chữ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
                string ser = txtMaSach.Text;
                var Lst = (from s in db.Saches where s.MaS == ser select s).First();
                try
                {
                    //MessageBox.Show(Lst.MaS);
                    db.Saches.DeleteOnSubmit(Lst);
                    db.SubmitChanges();
                    MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK);
                    clear();
                    load();
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi","Thông báo", MessageBoxButtons.OK);


                }
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnxoa.Visible = true;
            btnsua.Visible = true;
            int row = dataGridView1.CurrentRow.Index;
            txtMaSach.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            txtTenSach.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
            txtNamXB.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();
            txtNXB.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();
            txtTacGia.Text = dataGridView1.Rows[row].Cells[5].Value.ToString().Trim();
            dataDataContext db = new dataDataContext();
            string ser = txtMaSach.Text;
            var sa = (from s in db.Saches where s.MaS == ser select s).First();
            txtmatg.Text = sa.MaTG.ToString();
            txtmanxb.Text = sa.MaNXB.ToString();
          //  txtNamXB.Text = 
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
                string ser = txtMaSach.Text;
                var sa = (from s in db.Saches where s.MaS == ser select s).First();
                sa.MaTG = txtmatg.Text;
                sa.MaTl = comboTheLoai.SelectedValue.ToString();
                sa.TenSach = txtTenSach.Text;
                sa.NamXuatBan = int.Parse(txtNamXB.Text);
                sa.MaNXB = txtmanxb.Text;
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    load();
                    clear();
                }
                catch{
                    MessageBox.Show("lỗi", "Thông báo", MessageBoxButtons.OK);

                }
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnds_Click(object sender, EventArgs e)
        {
            txtNamXB.Text = DateTime.Now.Year.ToString();
            load();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            txtNamXB.Text = DateTime.Now.Year.ToString();
            load();
        }
    }
}
