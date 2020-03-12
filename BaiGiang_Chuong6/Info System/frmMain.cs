using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChiNhanhPhucLong;
using _1;

namespace _1.Presentation_Layer
{
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
        }
        

        private void mnChiNhanh_Click(object sender, EventArgs e)
        {
            frmChiNhanh frmCN = new frmChiNhanh();
            frmCN.Show();
        }

        private void mnThucUong_Click(object sender, EventArgs e)
        {
            frmThucUong frmTU = new frmThucUong(Int32.Parse(txtTK_ID.Text));
            frmTU.Show();

        }

        private void mnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmTK = new frmTaiKhoan();
            frmTK.Show();
        }

        
        private void mnBanDo_Click(object sender, EventArgs e)
        {
            MainForm fBanDo = new MainForm();
            fBanDo.Show();
        }

        private void mnHinhAnh_Click(object sender, EventArgs e)
        {
            frmHinhAnh f = new frmHinhAnh();
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mnDangXuat.Visible = false;
            mnQuanLy.Visible = false;
            txtTaiKhoan.Visible = false;
            txtTK_ID.Visible = false;
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult blnDongY = MessageBox.Show("Bạn có muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                mnDangXuat.Visible = false;
                mnQuanLy.Visible = false;
                txtTaiKhoan.Visible = false;
                mnDangNhap.Visible = true;
            }
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            DialogResult blnDongY = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                MessageBox.Show("Hẹn gặp lại bạn!", "Tạm biệt");
                this.Close();
            }
        }

        private void mnLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mọi chi tiết xin liên hệ Trần Minh Đức - Bành Ngọc Thụy Thảo - Khoa CNTT & TT Trường Đại học Cần Thơ!", "Thông báo");
        }

        

        private void mnTK_ThucUong_Click(object sender, EventArgs e)
        {
            frmTK_ThucUong f = new frmTK_ThucUong();
            f.ShowDialog();
        }

        private void mnTK_ChiNhanhToanQuoc_Click(object sender, EventArgs e)
        {
            frmTK_ChiNhanhToanQuoc f = new frmTK_ChiNhanhToanQuoc();
            f.ShowDialog();
        }

        private void mnTK_ChiNhanhTheoVung_Click(object sender, EventArgs e)
        {
            frmTK_ChiNhanhTheoVung f = new frmTK_ChiNhanhTheoVung();
            f.ShowDialog();
        }

        private void mnQR_Click(object sender, EventArgs e)
        {
            

        }

        private void mnDN_QR_Click(object sender, EventArgs e)
        {
            frmLoginQR f = new frmLoginQR(this);
            f.ShowDialog();
        }

        private void mnDN_TK_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap(this);
            frmDN.ShowDialog();
        }

        
    }
}
