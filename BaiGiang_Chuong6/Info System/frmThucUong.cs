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
    public partial class frmThucUong : Form
    {
        int Luu = 0; // 0: Luu ,1: cap nhat
        ThucUong tu = new ThucUong();
        int tk_id;
        
        public frmThucUong()
        {
            InitializeComponent();
        }
        public frmThucUong(int tk_id)
            : this()
        {
            this.tk_id = tk_id;
        }

        private void frmThucUong_Load(object sender, EventArgs e)
        {
            tu.Load(dgvTU);
            tu.GanDuLieu(dgvTU, txtMaTU, txtTenTU, txtTaiKhoan, txtGia);
            dgvTU.Width = 784;
            dgvTU.Columns[0].Width = 190;
            dgvTU.Columns[1].Width = 190;
            dgvTU.Columns[2].Width = 190;
            dgvTU.Columns[3].Width = 190;
            dgvTU.AllowUserToAddRows = false;
            dgvTU.AllowUserToDeleteRows = false;
            tu.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTU);
            txtTenTU.ReadOnly = true;
            txtGia.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = this.tk_id.ToString();
            tu.DK_Them_CapNhat(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTU);
            Luu = 0;
            txtMaTU.Text = "";
            txtTenTU.Text = "";
            txtGia.Text = "";
            txtMaTU.Focus();
            txtTenTU.ReadOnly = false;
            txtGia.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float a;
            
           if (txtTenTU.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ các trường !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(!float.TryParse(txtGia.Text, out a)){
                MessageBox.Show("Vui lòng nhập giá là số!", "Thông báo");
            }
            else
            {
                tu.TK_id = Int32.Parse(txtTaiKhoan.Text);
                tu.Thucuong_ten = txtTenTU.Text;
                tu.Thucuong_gia = Int32.Parse(txtGia.Text);
                if (Luu == 0)
                {
                    tu.AddRecord();
                }
                else
                {
                    tu.UpdateRecord();
                }
            }
            Luu = 0;
            
            tu.Load(dgvTU);
            tu.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTU);
            tu.GanDuLieu(dgvTU, txtMaTU, txtTenTU, txtTaiKhoan, txtGia);
            txtTenTU.ReadOnly = true;
            txtGia.ReadOnly = true;
        }

        private void dgvTU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tu.GanDuLieu(dgvTU, txtMaTU, txtTenTU, txtTaiKhoan, txtGia);
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;

            btnLuu.BackColor = Color.LightGray;
            btnKhongLuu.BackColor = Color.LightGray;
            btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
        
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = this.tk_id.ToString();
            tu.DK_Them_CapNhat(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTU);
            Luu = 1;
            txtTenTU.ReadOnly = false;
            txtGia.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tu.Thucuong_id = Int32.Parse(txtMaTU.Text);
            DialogResult blnDongY = MessageBox.Show("Bạn muốn xóa thức uống id " + tu.Thucuong_id + "?", "Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                tu.DeleteRecord();
                tu.Load(dgvTU);
                tu.GanDuLieu(dgvTU, txtMaTU, txtTenTU, txtTaiKhoan, txtGia);
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            tu.DK_BinhThuong(btnThem, btnLuu, btnCapNhat, btnXoa, btnKhongLuu, dgvTU);
            txtTenTU.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtGia.Clear();
            txtTenTU.Clear();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tu.TimKiem(txtTimKiem.Text, dgvTU);
        }

        
    }
}
