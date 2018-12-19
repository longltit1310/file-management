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
    public partial class frmNhaXuatBan : Form
    {
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }

        private void frmThemNhaXuatBan_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.NhaXuatBans select s).ToList();
            //DataGridViewRow r = new DataGridViewRow();
            dataGridView1.DataSource = Lst;
            int counttg = Lst.Count() + 1;
            txtmanxb.Text = "NXB" + counttg.ToString();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
             try
            {
                if(txttennxb.Text == "")
                    MessageBox.Show("Nhập tên nhà sản xuất", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dataDataContext db = new dataDataContext();
                    NhaXuatBan nxb = new NhaXuatBan();
                    nxb.MaNXB = txtmanxb.Text;
                    nxb.TenNXB = txttennxb.Text;
                    db.NhaXuatBans.InsertOnSubmit(nxb);
                    db.SubmitChanges();
                    //dataGridView1.DataSource = null ;
                    txttennxb.Text = "";
                    reload();
                    MessageBox.Show("Thêm thành công");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("xay ra loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataDataContext db = new dataDataContext();
            var Lst = (from s in db.NhaXuatBans where s.TenNXB.Contains(txttim.Text) select s).ToList();
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
            btnxoa.Visible = true;
            int row = dataGridView1.CurrentRow.Index;
            txtmanxb.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
            txttennxb.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataDataContext db = new dataDataContext();
                string ser = txtmanxb.Text;
                var Lst = (from s in db.NhaXuatBans where s.MaNXB == ser select s).First();
                try
                {
                    db.NhaXuatBans.DeleteOnSubmit(Lst);
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
