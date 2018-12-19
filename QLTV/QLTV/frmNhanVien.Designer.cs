namespace QLTV
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnnhaplai = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnthem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.datengayvaolam = new System.Windows.Forms.DateTimePicker();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttim = new System.Windows.Forms.TextBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.btnds = new Bunifu.Framework.UI.BunifuThinButton2();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaolam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtmk2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.cmnd,
            this.sdt,
            this.gioitinh,
            this.ngaysinh,
            this.ngayvaolam,
            this.email,
            this.userid});
            this.dataGridView1.Location = new System.Drawing.Point(1023, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 935);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(587, 88);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 29);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Nam";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmk2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtuserid);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnnhaplai);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.datengayvaolam);
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 483);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(904, 588);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnxoa
            // 
            this.btnxoa.ActiveBorderThickness = 1;
            this.btnxoa.ActiveCornerRadius = 20;
            this.btnxoa.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnxoa.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.BackgroundImage")));
            this.btnxoa.ButtonText = "Xóa";
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.IdleBorderThickness = 1;
            this.btnxoa.IdleCornerRadius = 20;
            this.btnxoa.IdleFillColor = System.Drawing.Color.White;
            this.btnxoa.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnxoa.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.Location = new System.Drawing.Point(13, 474);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(194, 70);
            this.btnxoa.TabIndex = 33;
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxoa.Visible = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ActiveBorderThickness = 1;
            this.btnsua.ActiveCornerRadius = 20;
            this.btnsua.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsua.ActiveForecolor = System.Drawing.Color.White;
            this.btnsua.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsua.BackColor = System.Drawing.SystemColors.Control;
            this.btnsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsua.BackgroundImage")));
            this.btnsua.ButtonText = "Sửa";
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsua.IdleBorderThickness = 1;
            this.btnsua.IdleCornerRadius = 20;
            this.btnsua.IdleFillColor = System.Drawing.Color.White;
            this.btnsua.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnsua.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsua.Location = new System.Drawing.Point(223, 474);
            this.btnsua.Margin = new System.Windows.Forms.Padding(5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(194, 70);
            this.btnsua.TabIndex = 32;
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsua.Visible = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.ActiveBorderThickness = 1;
            this.btnnhaplai.ActiveCornerRadius = 20;
            this.btnnhaplai.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnnhaplai.ActiveForecolor = System.Drawing.Color.White;
            this.btnnhaplai.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnnhaplai.BackColor = System.Drawing.SystemColors.Control;
            this.btnnhaplai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnhaplai.BackgroundImage")));
            this.btnnhaplai.ButtonText = "Nhập lại";
            this.btnnhaplai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhaplai.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnnhaplai.IdleBorderThickness = 1;
            this.btnnhaplai.IdleCornerRadius = 20;
            this.btnnhaplai.IdleFillColor = System.Drawing.Color.White;
            this.btnnhaplai.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnnhaplai.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnnhaplai.Location = new System.Drawing.Point(446, 474);
            this.btnnhaplai.Margin = new System.Windows.Forms.Padding(5);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(194, 70);
            this.btnnhaplai.TabIndex = 31;
            this.btnnhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // btnthem
            // 
            this.btnthem.ActiveBorderThickness = 1;
            this.btnthem.ActiveCornerRadius = 20;
            this.btnthem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnthem.ActiveForecolor = System.Drawing.Color.White;
            this.btnthem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnthem.BackColor = System.Drawing.SystemColors.Control;
            this.btnthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthem.BackgroundImage")));
            this.btnthem.ButtonText = "Thêm vào";
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnthem.IdleBorderThickness = 1;
            this.btnthem.IdleCornerRadius = 20;
            this.btnthem.IdleFillColor = System.Drawing.Color.White;
            this.btnthem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnthem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnthem.Location = new System.Drawing.Point(671, 474);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(212, 70);
            this.btnthem.TabIndex = 30;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "CMND số";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(587, 39);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(282, 30);
            this.txtCMND.TabIndex = 27;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // datengayvaolam
            // 
            this.datengayvaolam.CustomFormat = "dd/mm/yyyy";
            this.datengayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengayvaolam.Location = new System.Drawing.Point(624, 136);
            this.datengayvaolam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datengayvaolam.Name = "datengayvaolam";
            this.datengayvaolam.Size = new System.Drawing.Size(245, 30);
            this.datengayvaolam.TabIndex = 22;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "";
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(143, 136);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(170, 30);
            this.dateNgaySinh.TabIndex = 20;
            this.dateNgaySinh.Value = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(143, 281);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(282, 30);
            this.txtDienThoai.TabIndex = 14;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 192);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(726, 30);
            this.txtEmail.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(143, 232);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(726, 30);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(143, 82);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(282, 30);
            this.txtHoten.TabIndex = 11;
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(172, 39);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(253, 30);
            this.txtManv.TabIndex = 10;
            this.txtManv.Text = "NV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày vào làm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(298, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(486, 46);
            this.label8.TabIndex = 30;
            this.label8.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1410, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(505, 46);
            this.label10.TabIndex = 55;
            this.label10.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // btnthoat
            // 
            this.btnthoat.ActiveBorderThickness = 1;
            this.btnthoat.ActiveCornerRadius = 20;
            this.btnthoat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.ActiveForecolor = System.Drawing.Color.White;
            this.btnthoat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.ButtonText = "Thoát";
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Red;
            this.btnthoat.IdleBorderThickness = 1;
            this.btnthoat.IdleCornerRadius = 20;
            this.btnthoat.IdleFillColor = System.Drawing.Color.White;
            this.btnthoat.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.Location = new System.Drawing.Point(2016, 1132);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(194, 60);
            this.btnthoat.TabIndex = 56;
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttim);
            this.groupBox2.Controls.Add(this.bunifuImageButton2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(71, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 154);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(156, 54);
            this.txttim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(362, 37);
            this.txttim.TabIndex = 32;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(543, 47);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(65, 57);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 69;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 30);
            this.label12.TabIndex = 67;
            this.label12.Text = "Tìm kiếm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(387, 98);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 46);
            this.label13.TabIndex = 70;
            this.label13.Text = "TÌM KIẾM";
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(71, 1081);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(883, 24);
            this.bunifuRating1.TabIndex = 71;
            this.bunifuRating1.Value = 0;
            // 
            // btnds
            // 
            this.btnds.ActiveBorderThickness = 1;
            this.btnds.ActiveCornerRadius = 20;
            this.btnds.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnds.ActiveForecolor = System.Drawing.Color.White;
            this.btnds.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnds.BackColor = System.Drawing.SystemColors.Control;
            this.btnds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnds.BackgroundImage")));
            this.btnds.ButtonText = "Nạp danh sách";
            this.btnds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnds.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnds.IdleBorderThickness = 1;
            this.btnds.IdleCornerRadius = 20;
            this.btnds.IdleFillColor = System.Drawing.Color.White;
            this.btnds.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnds.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnds.Location = new System.Drawing.Point(1786, 1132);
            this.btnds.Margin = new System.Windows.Forms.Padding(5);
            this.btnds.Name = "btnds";
            this.btnds.Size = new System.Drawing.Size(194, 60);
            this.btnds.TabIndex = 32;
            this.btnds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnds.Click += new System.EventHandler(this.btnds_Click);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MaNv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "TenNv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            this.tennv.Width = 150;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "CMND";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "GioiTinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NgaySinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ngaysinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ngayvaolam
            // 
            this.ngayvaolam.DataPropertyName = "NgayVaoLam";
            this.ngayvaolam.HeaderText = "Ngày vào làm";
            this.ngayvaolam.Name = "ngayvaolam";
            this.ngayvaolam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ngayvaolam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "userid";
            this.userid.Name = "userid";
            this.userid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtuserid
            // 
            this.txtuserid.Enabled = false;
            this.txtuserid.Location = new System.Drawing.Point(143, 341);
            this.txtuserid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(282, 30);
            this.txtuserid.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 341);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "Userid";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(143, 401);
            this.txttk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(282, 30);
            this.txttk.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 401);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "Tài khoản";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(641, 341);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(228, 30);
            this.txtmk.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(458, 341);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 25);
            this.label16.TabIndex = 38;
            this.label16.Text = "Mật khẩu";
            // 
            // txtmk2
            // 
            this.txtmk2.Location = new System.Drawing.Point(641, 401);
            this.txtmk2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmk2.Name = "txtmk2";
            this.txtmk2.Size = new System.Drawing.Size(228, 30);
            this.txtmk2.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(457, 401);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 25);
            this.label17.TabIndex = 40;
            this.label17.Text = "Nhập lại mật khẩu";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2296, 1200);
            this.Controls.Add(this.btnds);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.Text = "frmThemNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DateTimePicker datengayvaolam;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnnhaplai;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttim;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnds;
        private Bunifu.Framework.UI.BunifuThinButton2 btnxoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsua;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaolam;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.TextBox txtmk2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label14;

    }
}