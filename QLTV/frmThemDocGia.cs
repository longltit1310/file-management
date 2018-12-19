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
    public partial class frmThemDocGia : Form
    {
        public frmThemDocGia()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reload()
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.docgias select s).ToList();
            //  ListViewItem ls = new ListViewItem();
            var lhv = (from s in db.LoaiHoiViens select s).ToList();

            cbblhv.DataSource = lhv.ToList();
            cbblhv.DisplayMember = "TenLoaiHV";
            cbblhv.ValueMember = "MaLoaiHV";

            string max = Lst.Max(r => r.MaHV);
            max = max.Substring(2);
            int ma = int.Parse(max) + 1;
            txtMaDocGia.Text = "DG" + ma.ToString();
        }
        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
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
            if (txtHoten.Text != "")
            {
                if (txtmssv.Text != "")
                {
                    if (txtCMND.Text != "")
                    {
                        if (txtDiaChi.Text != "")
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

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
