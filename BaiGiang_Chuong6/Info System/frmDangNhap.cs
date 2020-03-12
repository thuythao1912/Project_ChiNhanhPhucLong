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
using _2.Business_Logic_Layer;

namespace _1.Presentation_Layer
{
    public partial class frmDangNhap : Form
    {
        TaiKhoan tk = new TaiKhoan();
        private frmMain fMain;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public frmDangNhap(frmMain fm) : this()
        {
            fMain = fm;
        }
        public frmDangNhap(frmMain fm, string tk_id, string pwd)
            : this()
        {
            fMain = fm;
            txtMaTaiKhoan.Text = tk_id;
            txtPassword.Text = pwd;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaTaiKhoan.Text != "" && txtPassword.Text != "")
            {
                int tk_id;
                Int32.TryParse(txtMaTaiKhoan.Text, out tk_id);
                tk.Tk_id = tk_id;
                tk.Tk_password = txtPassword.Text;
                if (tk.DangNhap(tk.Tk_id, tk.Tk_password) == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    tk.ThongTinTaiKhoan(tk.Tk_id);
                    fMain.txtTaiKhoan.Visible = true;
                    fMain.mnQuanLy.Visible = true;
                    fMain.mnDangXuat.Visible = true;
                    fMain.mnDangNhap.Visible = false;
                    fMain.mnThongKe.Visible = true;
                    fMain.txtTaiKhoan.Text = "Xin chào " +tk.Tk_id +" - " + tk.Tk_hoten;
                    fMain.txtTK_ID.Text = tk.Tk_id.ToString();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Mật khẩu hoặc mã tài khoản sai!", "Thông báo");
                }
            }
            else {
                MessageBox.Show("Vui lòng điền đẩy đủ các trường!", "Thông báo");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
