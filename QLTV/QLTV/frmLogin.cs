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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            //Main main = new Main(1);
            //main.Show();
            //this.Hide();
            login();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
           
        }
        int dem = 0;
        private void login()
        {
            dataDataContext db = new dataDataContext();
            string user = txtten.Text;
            string pass = txtmk.Text;
           
            if (user != "" && pass != "")
            {
                var userid = (from s in db.TaiKhoans where s.pass == pass && s.tentk == user select s.userid).First();
                if(userid != 0)
                {
                    
                        Main main = new Main(userid);
                        main.Show();
                        this.Hide();
                }
                else
                {
                    dem++;
                    MessageBox.Show("Tài khoản hoặc mật khẩu gặp vấn đề", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dem >= 3)
                    {
                        MessageBox.Show("Bạn đã đăng nhập sai vượt số lần cho phép", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                login();
            }
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                login();
            }
        }

        private void txtmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                login();
            }
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                login();
            }
        }

        
    }
}
