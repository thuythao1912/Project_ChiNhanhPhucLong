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
    public partial class frmChiNhanhTheoTinh : Form
    {
        TinhThanh tt = new TinhThanh();
        ChiNhanh cn = new ChiNhanh();
        public frmChiNhanhTheoTinh()
        {
            InitializeComponent();
        }
        public frmChiNhanhTheoTinh(string id) :this()
        {
            tt.Tt_id = id;
        }

        private void frmChiNhanhTheoTinh_Load(object sender, EventArgs e)
        {
            tt.LoadTinhThanhDetail(tt.Tt_id);
            txtIdTinh.Text = tt.Tt_ten.ToUpper();
            txtVung.Text = tt.Vung_ten;
            cn.LoadChiNhanhTheoTinh(tt.Tt_id, dgvChiNhanhTheoTinh);
            dgvChiNhanhTheoTinh.Width = 780;
            dgvChiNhanhTheoTinh.Columns[0].Width = 50;
            dgvChiNhanhTheoTinh.Columns[1].Width = 200;
            dgvChiNhanhTheoTinh.Columns[2].Width = 80;
            dgvChiNhanhTheoTinh.Columns[3].Width = 405;
            dgvChiNhanhTheoTinh.AllowUserToAddRows = false;
            dgvChiNhanhTheoTinh.AllowUserToDeleteRows = false;
        }

        private void dgvChiNhanhTheoTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idChiNhanh = dgvChiNhanhTheoTinh[0, dgvChiNhanhTheoTinh.CurrentRow.Index].Value.ToString();
            frmChiTietChiNhanh f = new frmChiTietChiNhanh(idChiNhanh);
            f.ShowDialog();
        }
    }
}
