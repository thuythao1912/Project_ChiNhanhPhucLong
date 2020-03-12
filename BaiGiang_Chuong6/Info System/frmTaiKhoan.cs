using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.Business_Logic_Layer;


namespace _1.Presentation_Layer
{
    public partial class frmTaiKhoan : Form
    {
        int Luu = 0; // 0: Luu ,1: cap nhat
        TaiKhoan tk = new TaiKhoan();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            tk.Load(dgvTaiKhoan);
            dgvTaiKhoan.Width = 784;
            dgvTaiKhoan.Columns[0].Width = 125;
            dgvTaiKhoan.Columns[1].Width = 125;
            dgvTaiKhoan.Columns[2].Width = 125;
            dgvTaiKhoan.Columns[3].Width = 125;
            dgvTaiKhoan.Columns[4].Width = 125;
            dgvTaiKhoan.Columns[5].Width = 125;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            tk.GanDuLieu(dgvTaiKhoan,txtMaTaiKhoan,txtTenNguoiDung,txtEmail,txtPass,txtSDT,txtDiaChi);
            tk.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTaiKhoan);

            txtMaTaiKhoan.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPass.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenNguoiDung.ReadOnly = true;
            
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tk.GanDuLieu(dgvTaiKhoan, txtMaTaiKhoan, txtTenNguoiDung, txtEmail, txtSDT, txtPass, txtDiaChi);
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;

            btnLuu.BackColor = Color.LightGray;
            btnKhongLuu.BackColor = Color.LightGray;
            btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tk.DK_Them_CapNhat(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTaiKhoan);
            Luu = 0;
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTenNguoiDung.Clear();
            txtEmail.Clear();
            txtPass.Clear();

            txtMaTaiKhoan.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPass.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenNguoiDung.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tk.Tk_id = Int32.Parse(txtMaTaiKhoan.Text);
            tk.Tk_hoten = txtTenNguoiDung.Text;
            tk.Tk_email = txtEmail.Text;
            tk.Tk_diachi = txtDiaChi.Text;
            tk.Tk_password = txtPass.Text;
            tk.Tk_sdt = txtSDT.Text;
            if (txtTenNguoiDung.Text == "" || txtEmail.Text == ""|| txtDiaChi.Text=="" || txtPass.Text=="" || txtSDT.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đủ các trường !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Luu == 0)
                {
                    tk.AddRecord();
                }
                else
                {
                    tk.UpdateRecord();
                }
            }

            Luu = 0;
            tk.Load(dgvTaiKhoan);
            tk.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTaiKhoan);
            tk.GanDuLieu(dgvTaiKhoan, txtMaTaiKhoan, txtTenNguoiDung, txtEmail, txtPass, txtSDT, txtDiaChi);

            txtMaTaiKhoan.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPass.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenNguoiDung.ReadOnly = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            tk.DK_Them_CapNhat(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTaiKhoan);
            Luu = 1;
            txtMaTaiKhoan.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPass.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenNguoiDung.ReadOnly = false;
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            tk.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTaiKhoan);
            Luu = 0;

            txtMaTaiKhoan.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPass.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenNguoiDung.ReadOnly = true;

            txtTenNguoiDung.Clear();
            txtSDT.Clear();
            txtPass.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtMaTaiKhoan.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tk.Tk_id = Int32.Parse(txtMaTaiKhoan.Text);
            tk.DeleteRecord(tk.Tk_id.ToString());
            tk.Load(dgvTaiKhoan);
            tk.GanDuLieu(dgvTaiKhoan, txtMaTaiKhoan, txtTenNguoiDung, txtEmail, txtPass, txtSDT, txtDiaChi);
            tk.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTaiKhoan);
        }

        

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tk.TimKiem(txtTimKiem.Text, dgvTaiKhoan);
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4) {
                if (e.Value != null) {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }
    }
}
