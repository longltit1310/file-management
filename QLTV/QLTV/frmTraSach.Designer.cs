namespace QLTV
{
    partial class frmTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraSach));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.thoigianmuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hantrasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnluu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPM,
            this.TenHV,
            this.tensach,
            this.TinhTrang,
            this.thoigianmuon,
            this.hantrasach,
            this.mahv,
            this.MaNV});
            this.dataGridView1.Location = new System.Drawing.Point(134, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 682);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPM";
            this.MaPM.HeaderText = "Mã phiếu mượn";
            this.MaPM.Name = "MaPM";
            // 
            // TenHV
            // 
            this.TenHV.DataPropertyName = "TenHoiVien";
            this.TenHV.HeaderText = "Tên đọc giả";
            this.TenHV.Name = "TenHV";
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "TenSach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // thoigianmuon
            // 
            this.thoigianmuon.DataPropertyName = "ThoiGianMuon";
            this.thoigianmuon.HeaderText = "Thời gian mượn";
            this.thoigianmuon.Name = "thoigianmuon";
            // 
            // hantrasach
            // 
            this.hantrasach.DataPropertyName = "HanTraSach";
            this.hantrasach.HeaderText = "Hạn trả sách";
            this.hantrasach.Name = "hantrasach";
            // 
            // mahv
            // 
            this.mahv.DataPropertyName = "MaHV";
            this.mahv.HeaderText = "Mã đọc giả";
            this.mahv.Name = "mahv";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "Manv";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
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
            this.btnthoat.ButtonText = "Xong";
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Red;
            this.btnthoat.IdleBorderThickness = 1;
            this.btnthoat.IdleCornerRadius = 20;
            this.btnthoat.IdleFillColor = System.Drawing.Color.White;
            this.btnthoat.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.Location = new System.Drawing.Point(1381, 900);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(194, 60);
            this.btnthoat.TabIndex = 78;
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.ActiveBorderThickness = 1;
            this.btnluu.ActiveCornerRadius = 20;
            this.btnluu.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnluu.ActiveForecolor = System.Drawing.Color.White;
            this.btnluu.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnluu.BackColor = System.Drawing.SystemColors.Control;
            this.btnluu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnluu.BackgroundImage")));
            this.btnluu.ButtonText = "Trả sách";
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnluu.IdleBorderThickness = 1;
            this.btnluu.IdleCornerRadius = 20;
            this.btnluu.IdleFillColor = System.Drawing.Color.White;
            this.btnluu.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnluu.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnluu.Location = new System.Drawing.Point(1136, 900);
            this.btnluu.Margin = new System.Windows.Forms.Padding(5);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(194, 60);
            this.btnluu.TabIndex = 82;
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 46);
            this.label10.TabIndex = 83;
            this.label10.Text = "TRẢ SÁCH";
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 974);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTraSach";
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthoat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnluu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianmuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn hantrasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}