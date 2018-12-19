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
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {

            load();
        }
        private void load()
        {
            dataDataContext db = new dataDataContext();
            var Lst = from s in db.TheLoais select s;
            comboTheLoai.DataSource = Lst.ToList();
            comboTheLoai.DisplayMember = "TenTL";
            comboTheLoai.ValueMember = "MaTL";

          
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
