using _2.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiNhanhPhucLong
{
    public partial class frmThemDanhGia : Form
    {
        DanhGia dg = new DanhGia();
        public frmThemDanhGia()
        {
            InitializeComponent();
        }
        public frmThemDanhGia(string idChiNhanh) : this ()
        {
            dg.Cn_id = idChiNhanh;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDanhGia.Clear();
        }

        private void frmThemDanhGia_Load(object sender, EventArgs e)
        {
            txtIDChiNhanh.Text = dg.Cn_id;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dg.Dg_noidung = txtDanhGia.Text;
            if (dg.Dg_noidung != "")
            {
                dg.AddRecord();
                txtDanhGia.Clear();
            }
            else {
                MessageBox.Show("Bạn chưa nhập đánh giá!", "Thông báo");
            }
            
        }
        
    }
}
