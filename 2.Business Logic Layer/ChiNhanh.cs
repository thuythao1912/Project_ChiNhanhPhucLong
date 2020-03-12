using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Data_Access_Layer;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
namespace _2.Business_Logic_Layer
{
    public class ChiNhanh
    {
        #region 1. Khai báo các thành viên dữ liệu
        private string _cn_id;

        public string Cn_id
        {
            get { return _cn_id; }
            set { _cn_id = value; }
        }
        private string _tt_id;

        public string Tt_id
        {
            get { return _tt_id; }
            set { _tt_id = value; }
        }
        private string _cn_ten;

        public string Cn_ten
        {
            get { return _cn_ten; }
            set { _cn_ten = value; }
        }
        private string _cn_sdt;

        public string Cn_sdt
        {
            get { return _cn_sdt; }
            set { _cn_sdt = value; }
        }
        private string _cn_diachi;

        public string Cn_diachi
        {
            get { return _cn_diachi; }
            set { _cn_diachi = value; }
        }
        private string _tt_ten;

        public string Tt_ten
        {
            get { return _tt_ten; }
            set { _tt_ten = value; }
        }

        private int _tk_id;

        public int Tk_id
        {
            get { return _tk_id; }
            set { _tk_id = value; }
        }
        #endregion

        #region 2. cac phuong thuc khoi tao
        public ChiNhanh()
        {
            Cn_id = "";
            Cn_ten = "";
            Cn_sdt = "";
            Cn_diachi = "";
            Tt_id = "";
            Tt_ten = "";
            Tk_id = 0;
            ReadTable();
        }
        #endregion

        #region 3.cac phuong thuc khac
        public void LoadChiTietChiNhanh(string cn_id) {
            DataTable tb = new DataTable();
            ReadTable("exec getChiNhanhDetail '" + cn_id + "'");

            if (CountRow() > 0)
            {
                GetRecordTinh(0);
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu chi nhánh!", "Thông báo");
            }
        }
        public void LoadChiNhanhTheoTinh(string tt_id, DataGridView dgv) {
            DataTable tb = new DataTable();
            ReadTable("exec getChiNhanhTheoTinh '" + tt_id + "'");
            dgv.DataSource = GetTable();
            //dgv.Rows[0].Selected = true; 

        }
        public void LoadChiNhanhTheoVung(string vung_id, DataGridView dgv)
        {
            DataTable tb = new DataTable();
            ReadTable("exec getChiNhanhTheoVung '" + vung_id + "'");
            dgv.DataSource = GetTable();
            //dgv.Rows[0].Selected = true;

        }
        public void LoadcboChiNhanh(ComboBox cbo)
        {
            DataTable tb = new DataTable();
            ReadTable();
            tb.Columns.Add("CN_ID", typeof(String));
            tb.Columns.Add("CN_TEN", typeof(string));
            tb.Columns.Add("TONG", typeof(string), "CN_ID + '  ' + CN_TEN");
            for (int i = 0; i < CountRow(); i++)
            {
                GetRecord(i);
                tb.Rows.Add(Cn_id, Cn_ten);
            }

            cbo.DataSource = tb;
            cbo.DisplayMember = "TONG";
            cbo.ValueMember = "CN_ID";

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

        public void GanDuLieu(DataGridView dgv, TextBox txtCN_ID, ComboBox cboTT_ID, TextBox txtCN_TEN, TextBox txtCN_SDT, TextBox txtCN_DIA_CHI, TextBox txtTK_ID)
        {
            if (dgv.Rows.Count > 1)
            {
                txtCN_ID.Text = dgv[0, dgv.CurrentRow.Index].Value.ToString();
                cboTT_ID.SelectedIndex = cboTT_ID.FindString(dgv[1, dgv.CurrentRow.Index].Value.ToString());
                txtCN_TEN.Text = dgv[2, dgv.CurrentRow.Index].Value.ToString();
                txtCN_SDT.Text = dgv[3, dgv.CurrentRow.Index].Value.ToString();
                txtCN_DIA_CHI.Text = dgv[4, dgv.CurrentRow.Index].Value.ToString();
                txtTK_ID.Text = dgv[5, dgv.CurrentRow.Index].Value.ToString();
            }

        }

        public void Load(DataGridView dgv)
        {
            ChiNhanh chn = new ChiNhanh();
            dgv.DataSource = chn.GetTable();
            dgv.Rows[0].Selected = true;

        }

        public void TimKiem(string str, DataGridView dgv) {
            DataTable tb = new DataTable();
            ReadTable("exec searchChiNhanh N'%" + str + "%'");
            dgv.DataSource = GetTable();
        }

        #endregion

        #region 4.thao tac voi CSDL
        private ConnectDB cn = new ConnectDB();
        private DataTable dt = new DataTable();

        private void ReadTable()
        {
            dt = cn.getTableData("select * from CHINHANH");
        }
        private void ReadTable(String sql) {
            dt = cn.getTableData(sql);
        }

        public int CountRow()
        {
            return dt.Rows.Count;
        }
        public void GetRecordTinh(int i)
        {
            Cn_id = dt.Rows[i]["CN_ID"].ToString();
            Cn_sdt = dt.Rows[i]["CN_SDT"].ToString();
            Cn_ten = dt.Rows[i]["CN_TEN"].ToString();
            Cn_diachi = dt.Rows[i]["CN_DIACHI"].ToString();
            Tt_id = (dt.Rows[i]["TT_ID"].ToString());
            Tt_ten = dt.Rows[i]["TT_TEN"].ToString();
        }
        public void GetRecord(int i)
        {
            Cn_id = dt.Rows[i]["CN_ID"].ToString();
            Cn_sdt = dt.Rows[i]["CN_SDT"].ToString();
            Cn_ten = dt.Rows[i]["CN_TEN"].ToString();
            Cn_diachi = dt.Rows[i]["CN_DIACHI"].ToString();
            Tt_id = (dt.Rows[i]["TT_ID"].ToString());
        }
       
        public DataTable GetTable()
        {
            return dt;
        }


        public void AddRecord(TextBox txtMaCN)
        {
            if (cn.TonTaiKhoaChinh(txtMaCN.Text, "CN_ID", "CHINHANH"))
            {
                MessageBox.Show("Mã chi nhánh đã tồn tại. Vui lòng chọn mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Caulenh = null;
                    Caulenh = "insert into CHINHANH values(N'" + Cn_id + "',N'" + Tt_id + "',N'" + Cn_ten + "',N'" + Cn_sdt + "',N'" + Cn_diachi + "'," + Tk_id + ")";
                    //MessageBox.Show(Caulenh);
                    cn.ExcuteSQLInsertOrDelete(Caulenh);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public void DeleteRecord(TextBox txtMaCN)
        {
            if ((cn.TonTaiKhoaChinh(txtMaCN.Text, "CN_ID", "DANHGIA")) || (cn.TonTaiKhoaChinh(txtMaCN.Text, "CN_ID", "HINHANH")))
            {
                MessageBox.Show("Xóa hình ảnh hoặc đánh giá trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        Caulenh = "delete CHINHANH where CN_ID=N'" + Cn_id + "'";
                        MessageBox.Show(Caulenh);
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
        public void UpdateRecord()
        {
            try
            {
                string Caulenh = null;
                Caulenh = "Update CHINHANH set TT_ID=N'" + Tt_id + "',CN_TEN=N'" + Cn_ten + "',CN_SDT=N'" + Cn_sdt + "',CN_DIACHI=N'" + Cn_diachi + "',TK_ID=" + Tk_id + "where CN_ID=N'" + Cn_id + "'";
                //MessageBox.Show(Caulenh);
                cn.ExcuteSQLInsertOrDelete(Caulenh);
                MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("cập nhật không thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
