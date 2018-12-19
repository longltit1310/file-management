namespace QLTV
{
    partial class frmNhaXuatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaXuatBan));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txttennxb = new System.Windows.Forms.TextBox();
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnxoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttim = new System.Windows.Forms.TextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.label8.Location = new System.Drawing.Point(471, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(568, 46);
            this.label8.TabIndex = 59;
            this.label8.Text = "THÔNG TIN NHÀ XUẤT BẢN\r\n";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txttennxb);
            this.groupBox1.Controls.Add(this.txtmanxb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(119, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(690, 289);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhà Xuất Bản";
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
            this.btnthem.ButtonText = "Thêm mới";
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnthem.IdleBorderThickness = 1;
            this.btnthem.IdleCornerRadius = 20;
            this.btnthem.IdleFillColor = System.Drawing.Color.White;
            this.btnthem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnthem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnthem.Location = new System.Drawing.Point(501, 167);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(146, 70);
            this.btnthem.TabIndex = 30;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttennxb
            // 
            this.txttennxb.Location = new System.Drawing.Point(233, 114);
            this.txttennxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttennxb.Name = "txttennxb";
            this.txttennxb.Size = new System.Drawing.Size(414, 30);
            this.txttennxb.TabIndex = 11;
            // 
            // txtmanxb
            // 
            this.txtmanxb.Enabled = false;
            this.txtmanxb.Location = new System.Drawing.Point(233, 66);
            this.txtmanxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(414, 30);
            this.txtmanxb.TabIndex = 10;
            this.txtmanxb.Text = "NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà xuất bản\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.TenNXB});
            this.dataGridView1.Location = new System.Drawing.Point(892, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(558, 618);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã nhà xuất bản";
            this.MaNXB.Name = "MaNXB";
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên nhà xuất bản";
            this.TenNXB.Name = "TenNXB";
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
            this.btnthoat.Location = new System.Drawing.Point(1298, 845);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(194, 60);
            this.btnthoat.TabIndex = 61;
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(119, 112);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1331, 29);
            this.bunifuSeparator1.TabIndex = 63;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            this.btnxoa.Location = new System.Drawing.Point(1107, 845);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(156, 60);
            this.btnxoa.TabIndex = 32;
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxoa.Visible = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttim);
            this.groupBox2.Controls.Add(this.bunifuThinButton21);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(119, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 154);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(156, 54);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(337, 30);
            this.txttim.TabIndex = 68;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "TÌm";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(501, 31);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(146, 64);
            this.bunifuThinButton21.TabIndex = 66;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tìm kiếm";
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(56, 732);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(798, 22);
            this.bunifuRating1.TabIndex = 72;
            this.bunifuRating1.Value = 0;
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 1001);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnthoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhaXuatBan";
            this.Text = "frmThemNhaXuatBan";
            this.Load += new System.EventHandler(this.frmNhaXuatBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthem;
        private System.Windows.Forms.TextBox txttennxb;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnxoa;
        private System.Windows.Forms.TextBox txttim;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
    }
}