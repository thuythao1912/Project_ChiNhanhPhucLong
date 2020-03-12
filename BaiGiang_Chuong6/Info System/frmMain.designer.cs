namespace _1.Presentation_Layer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBanDo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChiNhanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThucUong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHinhAnh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTK_ChiNhanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTK_ChiNhanhToanQuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTK_ChiNhanhTheoVung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTK_ThucUong = new System.Windows.Forms.ToolStripMenuItem();
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTaiKhoan = new System.Windows.Forms.Label();
            this.txtTK_ID = new System.Windows.Forms.Label();
            this.mnDN_QR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDN_TK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangNhap,
            this.mnDangXuat,
            this.mnBanDo,
            this.mnQuanLy,
            this.mnThongKe,
            this.thaoTácToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnDangNhap
            // 
            this.mnDangNhap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDN_QR,
            this.mnDN_TK});
            this.mnDangNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnDangNhap.Name = "mnDangNhap";
            this.mnDangNhap.Size = new System.Drawing.Size(89, 21);
            this.mnDangNhap.Text = "Đăng nhập";
            
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(86, 21);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // mnBanDo
            // 
            this.mnBanDo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnBanDo.Name = "mnBanDo";
            this.mnBanDo.Size = new System.Drawing.Size(66, 21);
            this.mnBanDo.Text = "Bản đồ";
            this.mnBanDo.Click += new System.EventHandler(this.mnBanDo_Click);
            // 
            // mnQuanLy
            // 
            this.mnQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChiNhanh,
            this.mnThucUong,
            this.mnTaiKhoan,
            this.mnHinhAnh});
            this.mnQuanLy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnQuanLy.Name = "mnQuanLy";
            this.mnQuanLy.Size = new System.Drawing.Size(70, 21);
            this.mnQuanLy.Text = "Quản lý";
            // 
            // mnChiNhanh
            // 
            this.mnChiNhanh.Name = "mnChiNhanh";
            this.mnChiNhanh.Size = new System.Drawing.Size(146, 22);
            this.mnChiNhanh.Text = "Chi nhánh";
            this.mnChiNhanh.Click += new System.EventHandler(this.mnChiNhanh_Click);
            // 
            // mnThucUong
            // 
            this.mnThucUong.Name = "mnThucUong";
            this.mnThucUong.Size = new System.Drawing.Size(146, 22);
            this.mnThucUong.Text = "Thức uống";
            this.mnThucUong.Click += new System.EventHandler(this.mnThucUong_Click);
            // 
            // mnTaiKhoan
            // 
            this.mnTaiKhoan.Name = "mnTaiKhoan";
            this.mnTaiKhoan.Size = new System.Drawing.Size(146, 22);
            this.mnTaiKhoan.Text = "Tài khoản";
            this.mnTaiKhoan.Click += new System.EventHandler(this.mnTaiKhoan_Click);
            // 
            // mnHinhAnh
            // 
            this.mnHinhAnh.Name = "mnHinhAnh";
            this.mnHinhAnh.Size = new System.Drawing.Size(146, 22);
            this.mnHinhAnh.Text = "Hình ảnh";
            this.mnHinhAnh.Click += new System.EventHandler(this.mnHinhAnh_Click);
            // 
            // mnThongKe
            // 
            this.mnThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTK_ChiNhanh,
            this.mnTK_ThucUong});
            this.mnThongKe.Name = "mnThongKe";
            this.mnThongKe.Size = new System.Drawing.Size(83, 21);
            this.mnThongKe.Text = "Thông tin";
            // 
            // mnTK_ChiNhanh
            // 
            this.mnTK_ChiNhanh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTK_ChiNhanhToanQuoc,
            this.mnTK_ChiNhanhTheoVung});
            this.mnTK_ChiNhanh.Name = "mnTK_ChiNhanh";
            this.mnTK_ChiNhanh.Size = new System.Drawing.Size(146, 22);
            this.mnTK_ChiNhanh.Text = "Chi nhánh";
            // 
            // mnTK_ChiNhanhToanQuoc
            // 
            this.mnTK_ChiNhanhToanQuoc.Name = "mnTK_ChiNhanhToanQuoc";
            this.mnTK_ChiNhanhToanQuoc.Size = new System.Drawing.Size(146, 22);
            this.mnTK_ChiNhanhToanQuoc.Text = "Toàn quốc";
            this.mnTK_ChiNhanhToanQuoc.Click += new System.EventHandler(this.mnTK_ChiNhanhToanQuoc_Click);
            // 
            // mnTK_ChiNhanhTheoVung
            // 
            this.mnTK_ChiNhanhTheoVung.Name = "mnTK_ChiNhanhTheoVung";
            this.mnTK_ChiNhanhTheoVung.Size = new System.Drawing.Size(146, 22);
            this.mnTK_ChiNhanhTheoVung.Text = "Theo vùng";
            this.mnTK_ChiNhanhTheoVung.Click += new System.EventHandler(this.mnTK_ChiNhanhTheoVung_Click);
            // 
            // mnTK_ThucUong
            // 
            this.mnTK_ThucUong.Name = "mnTK_ThucUong";
            this.mnTK_ThucUong.Size = new System.Drawing.Size(146, 22);
            this.mnTK_ThucUong.Text = "Thức uống";
            this.mnTK_ThucUong.Click += new System.EventHandler(this.mnTK_ThucUong_Click);
            // 
            // thaoTácToolStripMenuItem
            // 
            this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLienHe,
            this.mnThoat});
            this.thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            this.thaoTácToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.thaoTácToolStripMenuItem.Text = "Thao tác";
            // 
            // mnLienHe
            // 
            this.mnLienHe.Name = "mnLienHe";
            this.mnLienHe.Size = new System.Drawing.Size(126, 22);
            this.mnLienHe.Text = "Liên hệ";
            this.mnLienHe.Click += new System.EventHandler(this.mnLienHe_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(126, 22);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoSize = true;
            this.txtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(39)))));
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.Location = new System.Drawing.Point(500, 450);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Padding = new System.Windows.Forms.Padding(5);
            this.txtTaiKhoan.Size = new System.Drawing.Size(258, 39);
            this.txtTaiKhoan.TabIndex = 2;
            this.txtTaiKhoan.Text = "TK_ID - TK_HOTEN";
            // 
            // txtTK_ID
            // 
            this.txtTK_ID.AutoSize = true;
            this.txtTK_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(39)))));
            this.txtTK_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK_ID.ForeColor = System.Drawing.Color.Black;
            this.txtTK_ID.Location = new System.Drawing.Point(12, 67);
            this.txtTK_ID.Name = "txtTK_ID";
            this.txtTK_ID.Padding = new System.Windows.Forms.Padding(5);
            this.txtTK_ID.Size = new System.Drawing.Size(96, 39);
            this.txtTK_ID.TabIndex = 3;
            this.txtTK_ID.Text = "TK_ID";
            // 
            // mnDN_QR
            // 
            this.mnDN_QR.Name = "mnDN_QR";
            this.mnDN_QR.Size = new System.Drawing.Size(152, 22);
            this.mnDN_QR.Text = "QR Code";
            this.mnDN_QR.Click += new System.EventHandler(this.mnDN_QR_Click);
            // 
            // mnDN_TK
            // 
            this.mnDN_TK.Name = "mnDN_TK";
            this.mnDN_TK.Size = new System.Drawing.Size(152, 22);
            this.mnDN_TK.Text = "Tài khoản";
            this.mnDN_TK.Click += new System.EventHandler(this.mnDN_TK_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 533);
            this.Controls.Add(this.txtTK_ID);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnBanDo;
        private System.Windows.Forms.ToolStripMenuItem mnChiNhanh;
        private System.Windows.Forms.ToolStripMenuItem mnThucUong;
        private System.Windows.Forms.ToolStripMenuItem mnTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnHinhAnh;
        public System.Windows.Forms.Label txtTaiKhoan;
        public System.Windows.Forms.ToolStripMenuItem mnQuanLy;
        public System.Windows.Forms.ToolStripMenuItem mnDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        public System.Windows.Forms.Label txtTK_ID;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnLienHe;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        public System.Windows.Forms.ToolStripMenuItem mnThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnTK_ChiNhanh;
        private System.Windows.Forms.ToolStripMenuItem mnTK_ThucUong;
        private System.Windows.Forms.ToolStripMenuItem mnTK_ChiNhanhToanQuoc;
        private System.Windows.Forms.ToolStripMenuItem mnTK_ChiNhanhTheoVung;
        private System.Windows.Forms.ToolStripMenuItem mnDN_QR;
        private System.Windows.Forms.ToolStripMenuItem mnDN_TK;
    }
}