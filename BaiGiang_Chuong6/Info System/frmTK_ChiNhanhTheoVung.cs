using ChiNhanhPhucLong.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiNhanhPhucLong{

    public partial class frmTK_ChiNhanhTheoVung : Form
    {
        public frmTK_ChiNhanhTheoVung()
        {
            InitializeComponent();
        }

        private void frmTK_ChiNhanhTheoVung_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Cr_ChiNhanhTheoVung cr = new Cr_ChiNhanhTheoVung();
            cr.Refresh();
            crChiNhanhTheoVung.ReportSource = cr;
        }

        
    }
}
