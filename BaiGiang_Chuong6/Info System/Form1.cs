using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using _2.Business_Logic_Layer;
using ChiNhanhPhucLong;

namespace _1.Presentation_Layer
{
    public partial class frmLoginQR : Form
    {
        TaiKhoan tk = new TaiKhoan();
        private frmMain fMain;
        public frmLoginQR()
        {
            InitializeComponent();
        }
        public frmLoginQR(frmMain fm)
            : this()
        {
            fMain = fm;
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pcWebcam.Image = (Image)eventArgs.Frame.Clone();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cboWebcam.Items.Add(Device.Name);
            }
            cboWebcam.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cboWebcam.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pcWebcam.Image);

                string decode = result.ToString().Trim();
                if (decode == "Tran Minh Duc Handsome")
                {
                    tk.ThongTinTaiKhoan(1);
                    timer1.Stop();
                    MessageBox.Show("Đăng nhập thành công! Xin chào " +tk.Tk_hoten, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalFrame.Stop();
                    this.Close();

                    fMain.txtTaiKhoan.Visible = true;
                    fMain.mnQuanLy.Visible = true;
                    fMain.mnDangXuat.Visible = true;
                    fMain.mnDangNhap.Visible = false;
                    fMain.mnThongKe.Visible = true;
                    fMain.txtTaiKhoan.Text = "Xin chào " + tk.Tk_id + " - " + tk.Tk_hoten;
                    fMain.txtTK_ID.Text = tk.Tk_id.ToString();
                    this.Close();

                }
                else if (decode == "Banh Ngoc Thuy Thao")
                {
                    tk.ThongTinTaiKhoan(2);
                    timer1.Stop();
                    MessageBox.Show("Đăng nhập thành công! Xin chào " + tk.Tk_hoten, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FinalFrame.Stop();
                    this.Close();
                   
                    fMain.txtTaiKhoan.Visible = true;
                    fMain.mnQuanLy.Visible = true;
                    fMain.mnDangXuat.Visible = true;
                    fMain.mnDangNhap.Visible = false;
                    fMain.mnThongKe.Visible = true;
                    fMain.txtTaiKhoan.Text = "Xin chào " + tk.Tk_id + " - " + tk.Tk_hoten;
                    fMain.txtTK_ID.Text = tk.Tk_id.ToString();
                    this.Close();
                }

            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }
    }
}
