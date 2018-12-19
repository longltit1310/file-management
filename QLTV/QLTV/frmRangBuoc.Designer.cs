namespace QLTV
{
    partial class frmRangBuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRangBuoc));
            this.btnsua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rb1 = new System.Windows.Forms.Label();
            this.gtrb1 = new System.Windows.Forms.TextBox();
            this.rb2 = new System.Windows.Forms.Label();
            this.gtrb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.btnsua.Location = new System.Drawing.Point(391, 435);
            this.btnsua.Margin = new System.Windows.Forms.Padding(5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(194, 70);
            this.btnsua.TabIndex = 74;
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
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
            this.btnthoat.Location = new System.Drawing.Point(645, 435);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(194, 70);
            this.btnthoat.TabIndex = 75;
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(48, 94);
            this.rb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(462, 36);
            this.rb1.TabIndex = 80;
            this.rb1.Text = "Số ngày tối đa được mượn sách";
            // 
            // gtrb1
            // 
            this.gtrb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtrb1.Location = new System.Drawing.Point(690, 103);
            this.gtrb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gtrb1.Name = "gtrb1";
            this.gtrb1.Size = new System.Drawing.Size(140, 37);
            this.gtrb1.TabIndex = 81;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(48, 183);
            this.rb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(462, 36);
            this.rb2.TabIndex = 82;
            this.rb2.Text = "Số ngày tối đa được mượn sách";
            // 
            // gtrb2
            // 
            this.gtrb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtrb2.Location = new System.Drawing.Point(690, 192);
            this.gtrb2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gtrb2.Name = "gtrb2";
            this.gtrb2.Size = new System.Drawing.Size(140, 37);
            this.gtrb2.TabIndex = 83;
            // 
            // frmRangBuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 551);
            this.Controls.Add(this.gtrb2);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.gtrb1);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRangBuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRangBuoc";
            this.Load += new System.EventHandler(this.frmRangBuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnsua;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthoat;
        private System.Windows.Forms.Label rb1;
        private System.Windows.Forms.TextBox gtrb1;
        private System.Windows.Forms.Label rb2;
        private System.Windows.Forms.TextBox gtrb2;
    }
}