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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmThemTacGia_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.TacGias select s).ToList();
            //  DataGridViewRow r = new DataGridViewRow();
            dataGridView1.DataSource = Lst;
            int counttg = Lst.Count() + 1;
            txtmatacgia.Text = "TG" + counttg.ToString();
            txttentg.Text = "";
            // MessageBox.Show(a.ToString(), "a");
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttentg.Text == "")
                    MessageBox.Show("Nhập tên tác giả", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dataDataContext db = new dataDataContext();
                    TacGia tg = new TacGia();
                    tg.MaTG = txtmatacgia.Text;
                    tg.TenTg = txttentg.Text;
                    db.TacGias.InsertOnSubmit(tg);
                    db.SubmitChanges();
                    //dataGridView1.DataSource = null ;
                    txttentg.Text = "";
                    reload();
                    MessageBox.Show("Thêm thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("xay ra loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.TacGias where s.TenTg.Contains(txttim.Text) select s).ToList();
            if (Lst.Count > 0)
            {
                dataGridView1.DataSource = Lst;
                // txtmanxb.Text = Lst[0].MaNXB.ToString();
                //txttennxb.Text = Lst[0].TenNXB.ToString();
                txttim.Clear();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ");
                txttim.Clear();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnsua.Visible = true;
            btnxoa.Visible = true;
            int row = dataGridView1.CurrentRow.Index;
            txtmatacgia.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            txttentg.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
                string ser = txtmatacgia.Text;
                var sa = (from s in db.TacGias where s.MaTG == ser select s).First();
                sa.TenTg = txttentg.Text;
               
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
                string ser = txtmatacgia.Text;
                var Lst = (from s in db.TacGias where s.MaTG == ser select s).First();
                try
                {
                    db.TacGias.DeleteOnSubmit(Lst);
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
    }
}
