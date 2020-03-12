using _3.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Business_Logic_Layer
{
    public class TaiKhoan
    {
        #region 1.khai bao du lieu
        private int _tk_id;

        public int Tk_id
        {
            get { return _tk_id; }
            set { _tk_id = value; }
        }
        private string _tk_hoten;

        public string Tk_hoten
        {
            get { return _tk_hoten; }
            set { _tk_hoten = value; }
        }
        private string _tk_email;

        public string Tk_email
        {
            get { return _tk_email; }
            set { _tk_email = value; }
        }
        private string _tk_sdt;

        public string Tk_sdt
        {
            get { return _tk_sdt; }
            set { _tk_sdt = value; }
        }
        private string _tk_password;

        public string Tk_password
        {
            get { return _tk_password; }
            set { _tk_password = value; }
        }
        private string _tk_diachi;

        public string Tk_diachi
        {
            get { return _tk_diachi; }
            set { _tk_diachi = value; }
        }
        #endregion
        #region 2. cac phuong thuc khoi tao
        public TaiKhoan()
        {
            Tk_id = 0;
            Tk_hoten = "";
            Tk_email = "";
            Tk_diachi = "";
            Tk_password = "";
            Tk_sdt = "";
            ReadTable();
        }
        #endregion
        #region 3.cac phuong thuc khac
        public void GanDuLieu(DataGridView dgv, TextBox txtMTK, TextBox txtTenND, TextBox txtEmail, TextBox txtPass, TextBox txtSDT, TextBox txtDiaChi)
        {
            if (dgv.Rows.Count > 1)
            {
                txtMTK.Text = dgv[0, dgv.CurrentRow.Index].Value.ToString();
                txtTenND.Text = dgv[1, dgv.CurrentRow.Index].Value.ToString();
                txtEmail.Text = dgv[2, dgv.CurrentRow.Index].Value.ToString();
                txtPass.Text = dgv[3, dgv.CurrentRow.Index].Value.ToString();
                txtSDT.Text = dgv[4, dgv.CurrentRow.Index].Value.ToString();
                txtDiaChi.Text = dgv[5, dgv.CurrentRow.Index].Value.ToString();
            }

        }
        public void Load(DataGridView dgv)
        {
            TaiKhoan tk = new TaiKhoan();
            dgv.DataSource = tk.GetTable();
            dgv.Rows[0].Selected = true;

        }
        public void DK_BinhThuong(Button btnThem, Button btnLuu, Button btnCapNhat, Button btnXoa, Button btnKhongLuu, DataGridView dgv)
        {
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnLuu.Enabled = false;
            dgv.Enabled = true;

            btnCapNhat.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;
            btnKhongLuu.BackColor = Color.LightGray;
            btnLuu.BackColor = Color.LightGray;
            btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
        }
        public void DK_Them_CapNhat(Button btnThem, Button btnLuu, Button btnCapNhat, Button btnXoa, Button btnKhongLuu, DataGridView dgv)
        {
            btnThem.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnKhongLuu.Enabled = true;
            btnLuu.Enabled = true;
            dgv.Enabled = false;

            btnThem.BackColor = Color.LightGray;
            btnCapNhat.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;
            btnKhongLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
        }

        public int DangNhap(int tk_id, String tk_password)
        {
            int dangnhap;

            DataTable tb = new DataTable();
            dt = cn.getTableData("select * from TAIKHOAN where TK_ID = " + tk_id + " and TK_PASSWORD = '" + tk_password + "'");
            dangnhap = CountRow();
            return dangnhap;
        }

        public void ThongTinTaiKhoan(int tk_id) {
            
            DataTable tb = new DataTable();
            dt = cn.getTableData("select * from TAIKHOAN where TK_ID = " + tk_id);
            if (CountRow() > 0) {
                GetRecord(0);
            }
        }

        public void TimKiem(string str, DataGridView dgv)
        {
            DataTable tb = new DataTable();
            ReadTable("exec searchTaiKhoan N'%" + str + "%'");
            dgv.DataSource = GetTable();
        }
        #endregion
        #region 4.thao tac voi CSDL
        private ConnectDB cn = new ConnectDB();
        private DataTable dt = new DataTable();

        private void ReadTable()
        {
            dt = cn.getTableData("select * from TAIKHOAN");
        }

        private void ReadTable(string sql)
        {
            dt = cn.getTableData(sql);
        }

        public int CountRow()
        {
            return dt.Rows.Count;
        }

        public void AddRecord()
        {
            try
            {
                string Caulenh = null;
                Caulenh = "insert into TAIKHOAN values(N'" + Tk_hoten + "',N'" + Tk_email + "',N'" + Tk_sdt + "',N'" + Tk_password + "',N'" + Tk_diachi + "')";
                //MessageBox.Show(Caulenh);
                cn.ExcuteSQLInsertOrDelete(Caulenh);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void UpdateRecord()
        {
            try
            {
                string Caulenh = null;
                Caulenh = "update TAIKHOAN set TK_HOTEN=N'" + Tk_hoten + "',TK_EMAIL=N'" + Tk_email + "',TK_SDT=N'" + Tk_sdt + "',TK_PASSWORD=N'" + Tk_password + "',TK_DIACHI=N'" + Tk_diachi + "' where TK_ID=" + Tk_id;
                //MessageBox.Show(Caulenh);
                cn.ExcuteSQLInsertOrDelete(Caulenh);
                MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("cập nhật không thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DeleteRecord(string tk_id)
        {
           if (cn.TonTaiKhoaChinh(tk_id, "TK_ID", "THUCUONG") || cn.TonTaiKhoaChinh(tk_id, "TK_ID", "CHINHANH"))
            {
                MessageBox.Show("Phải xóa thức uống và chi nhánh trước !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (blnDongY == DialogResult.Yes)
                {
                    try
                    {
                        string Caulenh = null;
                        Caulenh = "delete TAIKHOAN where TK_ID=" + Tk_id;
                        cn.ExcuteSQLInsertOrDelete(Caulenh);
                        MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        public DataTable GetTable()
        {
            return dt;
        }
        public void GetRecord(int i)
        {
            Tk_id = Int32.Parse(dt.Rows[i]["TK_ID"].ToString());
            Tk_hoten = dt.Rows[i]["TK_HOTEN"].ToString();
            Tk_diachi = dt.Rows[i]["TK_DIACHI"].ToString();
            Tk_email = dt.Rows[i]["TK_EMAIL"].ToString();
            Tk_sdt = dt.Rows[i]["TK_SDT"].ToString();
            Tk_password = dt.Rows[i]["TK_PASSWORD"].ToString(); 
        }
        #endregion
    }
}
