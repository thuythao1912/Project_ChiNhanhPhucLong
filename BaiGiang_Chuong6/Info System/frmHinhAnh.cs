using _2.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiNhanhPhucLong {

    public partial class frmHinhAnh : Form
    {
        HinhAnh ha = new HinhAnh();
        ChiNhanh cn = new ChiNhanh();
        public frmHinhAnh()
        {
            InitializeComponent();
        }

        private void frmHinhAnh_Load(object sender, EventArgs e)
        {
            cn.LoadcboChiNhanh(cboChiNhanh);
            ha.LoadHinhAnh(dgvHinhAnh);
            dgvHinhAnh.Width = 360;
            dgvHinhAnh.Columns[0].Width = 80;
            dgvHinhAnh.Columns[1].Width = 80;
            dgvHinhAnh.Columns[2].Width = 400;
            dgvHinhAnh.AllowUserToAddRows = false;
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtChonFile.Text = openFile.FileName;
            }
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ha.Hinh_link = txtChonFile.Text;
            ha.Cn_id = cboChiNhanh.SelectedValue.ToString();
            ha.AddRecord();
            ha.LoadHinhAnh(dgvHinhAnh);
            txtChonFile.Clear();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            txtChonFile.Clear();
        }

        private void dgvHinhAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ha.Hinh_link = dgvHinhAnh[2, dgvHinhAnh.CurrentRow.Index].Value.ToString();
                pcAvatar.Image = Image.FromFile(ha.Hinh_link);
                cboChiNhanh.SelectedValue = dgvHinhAnh[1, dgvHinhAnh.CurrentRow.Index].Value;
            }
            catch { 
                MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo");
            }
        }

        private void txtChonFile_TextChanged(object sender, EventArgs e)
        {
            if(txtChonFile.Text!=""){
                pcAvatar.Image = Image.FromFile(txtChonFile.Text);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ha.Hinh_id = Int32.Parse(dgvHinhAnh[0, dgvHinhAnh.CurrentRow.Index].Value.ToString());
            DialogResult blnDongY = MessageBox.Show("Bạn muốn xóa hình id " + ha.Hinh_id + "?", "Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                ha.DeleteRecord(ha.Hinh_id);
                ha.LoadHinhAnh(dgvHinhAnh);
            }
        }

        

        
    }
}
