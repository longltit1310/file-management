namespace QLTV
{
    partial class frmTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnhaplai = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnthem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txttentg = new System.Windows.Forms.TextBox();
            this.txtmatacgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttim = new System.Windows.Forms.TextBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btnxoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsua = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTG,
            this.TenTg});
            this.dataGridView1.Location = new System.Drawing.Point(642, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(704, 618);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Mã tác giả";
            this.MaTG.Name = "MaTG";
            // 
            // TenTg
            // 
            this.TenTg.DataPropertyName = "TenTg";
            this.TenTg.HeaderText = "Tên Tác giả";
            this.TenTg.Name = "TenTg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(425, 46);
            this.label8.TabIndex = 53;
            this.label8.Text = "THÔNG TIN TÁC GIẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnnhaplai);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txttentg);
            this.groupBox1.Controls.Add(this.txtmatacgia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 433);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(586, 342);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tác Giả";
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
            this.btnnhaplai.Location = new System.Drawing.Point(110, 144);
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
            this.btnthem.Location = new System.Drawing.Point(343, 144);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(212, 70);
            this.btnthem.TabIndex = 30;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttentg
            // 
            this.txttentg.Location = new System.Drawing.Point(224, 84);
            this.txttentg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttentg.Name = "txttentg";
            this.txttentg.Size = new System.Drawing.Size(318, 30);
            this.txttentg.TabIndex = 11;
            // 
            // txtmatacgia
            // 
            this.txtmatacgia.Enabled = false;
            this.txtmatacgia.Location = new System.Drawing.Point(224, 36);
            this.txtmatacgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatacgia.Name = "txtmatacgia";
            this.txtmatacgia.Size = new System.Drawing.Size(318, 30);
            this.txtmatacgia.TabIndex = 10;
            this.txtmatacgia.Text = "TG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tác giả";
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
            this.btnthoat.Location = new System.Drawing.Point(1202, 822);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(194, 60);
            this.btnthoat.TabIndex = 57;
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttim);
            this.groupBox2.Controls.Add(this.bunifuImageButton2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 154);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(156, 54);
            this.txttim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(294, 37);
            this.txttim.TabIndex = 32;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(477, 45);
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
            this.btnxoa.Location = new System.Drawing.Point(108, 243);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(194, 70);
            this.btnxoa.TabIndex = 76;
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
            this.btnsua.Location = new System.Drawing.Point(343, 243);
            this.btnsua.Margin = new System.Windows.Forms.Padding(5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(212, 70);
            this.btnsua.TabIndex = 75;
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsua.Visible = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 896);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemTacGia";
            this.Load += new System.EventHandler(this.frmThemTacGia_Load);
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

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnnhaplai;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthem;
        private System.Windows.Forms.TextBox txttentg;
        private System.Windows.Forms.TextBox txtmatacgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttim;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuThinButton2 btnxoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsua;
    }
}