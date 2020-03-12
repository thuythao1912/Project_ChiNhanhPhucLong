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


namespace ChiNhanhPhucLong
{
    public partial class frmChiNhanh : Form
    {
        int Luu = 0;
        ChiNhanh chn = new ChiNhanh();
        TinhThanh tt = new TinhThanh();
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {

            chn.Load(dgvChiNhanh);
            tt.LoadcboTinhThanh(cbMaTnhThanh);
            chn.GanDuLieu(dgvChiNhanh, txtMaChiNhanh, cbMaTnhThanh, txtTenChiNhanh, txtSDT, txtDiaChi, txtTaiKhoan);
            dgvChiNhanh.Width = 784;
            dgvChiNhanh.Columns[0].Width = 125;
            dgvChiNhanh.Columns[1].Width = 125;
            dgvChiNhanh.Columns[2].Width = 125;
            dgvChiNhanh.Columns[3].Width = 125;
            dgvChiNhanh.Columns[4].Width = 125;
            dgvChiNhanh.Columns[5].Width = 125;
            dgvChiNhanh.AllowUserToAddRows = false;
            dgvChiNhanh.AllowUserToDeleteRows = false;
            chn.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvChiNhanh);

            txtDiaChi.ReadOnly = true;
            txtMaChiNhanh.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenChiNhanh.ReadOnly = true;
            txtSDT.ReadOnly = true;
            cbMaTnhThanh.Enabled = false;

            cbMaTnhThanh.BackColor = Color.White;
        }

        private void dgvChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chn.GanDuLieu(dgvChiNhanh, txtMaChiNhanh, cbMaTnhThanh, txtTenChiNhanh, txtSDT, txtDiaChi, txtTaiKhoan);
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
            Luu = 0;
            txtDiaChi.Clear();
            txtMaChiNhanh.Clear();
            txtSDT.Clear();
           
            txtTenChiNhanh.Clear();
            chn.DK_Them_CapNhat(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvChiNhanh);

            txtDiaChi.ReadOnly = false;
            txtMaChiNhanh.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenChiNhanh.ReadOnly = false;
            txtSDT.ReadOnly = false;
            cbMaTnhThanh.Enabled = true;
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (txtMaChiNhanh.Text == "" || txtTenChiNhanh.Text == "" || txtDiaChi.Text=="" || txtSDT.Text=="" ||txtTaiKhoan.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đủ các trường !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chn.Cn_id = txtMaChiNhanh.Text;
                chn.Cn_ten = txtTenChiNhanh.Text;
                chn.Cn_diachi = txtDiaChi.Text;
                chn.Cn_sdt = txtSDT.Text;
                chn.Tk_id = Int32.Parse(txtTaiKhoan.Text);
                chn.Tt_id = cbMaTnhThanh.SelectedValue.ToString();
                if (Luu == 0)
                {
                    chn.AddRecord(txtMaChiNhanh);
                }
                else
                {
                    chn.UpdateRecord();
                }

            }

            Luu = 0;
            chn.Load(dgvChiNhanh);
            chn.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvChiNhanh);
            chn.GanDuLieu(dgvChiNhanh, txtMaChiNhanh, cbMaTnhThanh, txtTenChiNhanh, txtSDT, txtDiaChi, txtTaiKhoan);

            txtDiaChi.ReadOnly = true;
            txtMaChiNhanh.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenChiNhanh.ReadOnly = true;
            txtSDT.ReadOnly = true;
            cbMaTnhThanh.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            chn.Cn_id = txtMaChiNhanh.Text;
            chn.DeleteRecord(txtMaChiNhanh);
            chn.Load(dgvChiNhanh);
            chn.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvChiNhanh);
            chn.GanDuLieu(dgvChiNhanh, txtMaChiNhanh, cbMaTnhThanh, txtTenChiNhanh, txtSDT, txtDiaChi, txtTaiKhoan);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            chn.DK_Them_CapNhat(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvChiNhanh);
            Luu = 1;

            txtDiaChi.ReadOnly = false;
            txtMaChiNhanh.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenChiNhanh.ReadOnly = false;
            txtSDT.ReadOnly = false;
            cbMaTnhThanh.Enabled = true;
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            chn.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvChiNhanh);
            Luu = 0;

            txtDiaChi.ReadOnly = true;
            txtMaChiNhanh.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenChiNhanh.ReadOnly = true;
            txtSDT.ReadOnly = true;
            cbMaTnhThanh.Enabled = false;

            txtDiaChi.Clear();
            txtMaChiNhanh.Clear();
            txtSDT.Clear();
            txtTenChiNhanh.Clear();
            txtSDT.Clear();
            cbMaTnhThanh.Enabled = false;


        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            chn.TimKiem(txtTimKiem.Text, dgvChiNhanh);

        }

        
    }
}
