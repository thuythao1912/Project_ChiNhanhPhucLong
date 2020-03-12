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
    public partial class frmChiTietChiNhanh : Form
    {
        //public string idChiNhanh;
        ChiNhanh cn = new ChiNhanh();
        DanhGia dg = new DanhGia();
        HinhAnh ha = new HinhAnh();

        public frmChiTietChiNhanh()
        {
            InitializeComponent();
        }
        public frmChiTietChiNhanh(string id) : this (){
             cn.Cn_id = id;
             
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            cn.LoadChiTietChiNhanh(cn.Cn_id);
            ha.LoadHinhTheoChiNhanh(cn.Cn_id);
            txtTenChiNhanh.Text = cn.Cn_ten;
            txtDiaChi.Text = cn.Cn_diachi;
            txtMaChiNhanh.Text = cn.Cn_id;
            txtTinhThanh.Text = cn.Tt_ten;
            txtSDT.Text = cn.Cn_sdt;
            txtDanhGia.Text = dg.LoadDanhGiaTheoChiNhanh(cn.Cn_id);
            if (ha.Hinh_link != "") {
                pcAvatar.Image = Image.FromFile(ha.Hinh_link);
            }
            
            
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            frmThemDanhGia f = new frmThemDanhGia(cn.Cn_id);
            f.ShowDialog();
            this.Close();
        }
        
    }
}
