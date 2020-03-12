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
    public partial class frmTK_ThucUong : Form
    {
        public frmTK_ThucUong()
        {
            InitializeComponent();
        }

        private void frmTK_ThucUong_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Cr_ThucUong cr = new Cr_ThucUong();
            cr.Refresh();
            crThucUong.ReportSource = cr;
        }
    }
}
