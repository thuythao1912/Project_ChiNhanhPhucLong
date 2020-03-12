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

    public partial class frmTK_ChiNhanhToanQuoc : Form
    {
        public frmTK_ChiNhanhToanQuoc()
        {
            InitializeComponent();
        }

        private void frmTK_ChiNhanh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Cr_ChiNhanhToanQuoc cr = new Cr_ChiNhanhToanQuoc();
            cr.Refresh();
            crChiNhanh.ReportSource = cr;
        }
        
    }
}
