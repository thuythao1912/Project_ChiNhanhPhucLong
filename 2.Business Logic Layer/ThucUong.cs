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
    public class ThucUong
    {
        #region 1.khai bao du lieu

        private int _thucuong_id;

        public int Thucuong_id
        {
            get { return _thucuong_id; }
            set { _thucuong_id = value; }
        }
        private int _TK_id;

        public int TK_id
        {
            get { return _TK_id; }
            set { _TK_id = value; }
        }
        private string _thucuong_ten;

        public string Thucuong_ten
        {
            get { return _thucuong_ten; }
            set { _thucuong_ten = value; }
        }
        private float _thucuong_gia;

        public float Thucuong_gia
        {
            get { return _thucuong_gia; }
            set { _thucuong_gia = value; }
        }

        #endregion
        #region 2. cac phuong thuc khoi tao
        public ThucUong()
        {
            Thucuong_id = 0;
            Thucuong_ten = "";
            Thucuong_gia = 0;
            TK_id = 0;
            ReadTable();
        }
        #endregion
        #region 3.cac phuong thuc khac
        public void GanDuLieu(DataGridView dgv, TextBox txtMTU, TextBox txtTenTU, TextBox txtTaiKhoan, TextBox txtGia)
        {
            if (dgv.Rows.Count > 1)
            {
                txtMTU.Text = dgv[0, dgv.CurrentRow.Index].Value.ToString();
                txtTenTU.Text = dgv[2, dgv.CurrentRow.Index].Value.ToString();
                txtTaiKhoan.Text = dgv[1, dgv.CurrentRow.Index].Value.ToString();
                txtGia.Text = dgv[3, dgv.CurrentRow.Index].Value.ToString();
            }
        }
        public void Load(DataGridView dgv)
        {
            ThucUong tu = new ThucUong();
            dgv.DataSource = tu.GetTable();
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
        public void TimKiem(string str, DataGridView dgv)
        {
            DataTable tb = new DataTable();
            ReadTable("exec searchThucUong N'%" + str + "%'");
            dgv.DataSource = GetTable();
        }
        #endregion
        #region 4.thao tac voi CSDL

        private ConnectDB cn = new ConnectDB();
        private DataTable dt = new DataTable();

        private void ReadTable()
        {
            dt = cn.getTableData("select * from THUCUONG");
        }
        private void ReadTable(string sql)
        {
            dt = cn.getTableData(sql);
        }

        public int CountRow()
        {
            return dt.Rows.Count;
        }

        public DataTable GetTable()
        {
            return dt;
        }


        public void AddRecord()
        {
            try
            {
                string Caulenh = null;
                Caulenh = "insert into THUCUONG values(" + TK_id + ",N'" + Thucuong_ten + "'," + Thucuong_gia + ")";
                cn.ExcuteSQLInsertOrDelete(Caulenh);
                MessageBox.Show("Đã thêm thành công!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Can not insert ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void DeleteRecord()
        {
            try
            {
                string Caulenh = null;
                Caulenh = "delete THUCUONG where THUCUONG_ID=" + Thucuong_id;
                //MessageBox.Show(Caulenh);
                cn.ExcuteSQLInsertOrDelete(Caulenh);
                MessageBox.Show("Đã xóa thức uống thành công!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thể xóa! ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateRecord()
        {
            try
            {
                string Caulenh = null;
                Caulenh = "update THUCUONG set TK_ID=" + TK_id + ",THUCUONG_TEN=N'" + Thucuong_ten + "',THUCUONG_GIA=" + Thucuong_gia + " where THUCUONG_ID=" + Thucuong_id;
                //MessageBox.Show(Caulenh);
                cn.ExcuteSQLInsertOrDelete(Caulenh);
                MessageBox.Show("Đã cập nhật thành công!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thể cập nhật! ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
