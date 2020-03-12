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
    public partial class frmChiNhanhTheoVung : Form
    {
        Vung v = new Vung();
        ChiNhanh cn = new ChiNhanh();

        public frmChiNhanhTheoVung()
        {
            InitializeComponent();
        }
        public frmChiNhanhTheoVung(string id) : this()
        {
            v.Vung_id = id;
        }

        private void frmChiNhanhTheoVung_Load(object sender, EventArgs e)
        {
            v.LoadVungDetail(v.Vung_id);
            txtIdVung.Text = v.Vung_ten.ToUpper();
            cn.LoadChiNhanhTheoVung(v.Vung_id, dgvChiNhanhTheoVung);
            dgvChiNhanhTheoVung.Width = 950;
            dgvChiNhanhTheoVung.Columns[0].Width = 50;
            dgvChiNhanhTheoVung.Columns[1].Width = 200;
            dgvChiNhanhTheoVung.Columns[2].Width = 100;
            dgvChiNhanhTheoVung.Columns[3].Width = 400;
            dgvChiNhanhTheoVung.Columns[4].Width = 150;
            dgvChiNhanhTheoVung.AllowUserToAddRows = false;
            dgvChiNhanhTheoVung.AllowUserToDeleteRows = false;
           
        }

        private void dgvChiNhanhTheoVung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idChiNhanh = dgvChiNhanhTheoVung[0, dgvChiNhanhTheoVung.CurrentRow.Index].Value.ToString();
            frmChiTietChiNhanh f = new frmChiTietChiNhanh(idChiNhanh);
            f.ShowDialog();
        }
    }
}
