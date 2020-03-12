using _3.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Business_Logic_Layer
{
    public class HinhAnh
    {
        private int _hinh_id;

        public int Hinh_id
        {
            get { return _hinh_id; }
            set { _hinh_id = value; }
        }
        private string _cn_id;

        public string Cn_id
        {
            get { return _cn_id; }
            set { _cn_id = value; }
        }
        private string _hinh_link;

        public string Hinh_link
        {
            get { return _hinh_link; }
            set { _hinh_link = value; }
        }

        
        #region 2. cac phuong thuc khoi tao
        public HinhAnh() {
            Hinh_id = 0;
            Cn_id = "";
            Hinh_link = "";
        }
        #endregion

        #region 3.cac phuong thuc khac
        public void LoadHinhTheoChiNhanh(string cn_id)
        {
            DataTable tb = new DataTable();
            ReadTable("exec getHinhTheoChiNhanh '" + cn_id + "'");

            if (CountRow() > 0)
            {
                GetRecord(0);

            }
        }
        public void LoadHinhAnh(DataGridView dgv)
        {
            DataTable tb = new DataTable();
            ReadTable();
            dgv.DataSource = GetTable();
            dgv.Rows[0].Selected = true;

        }
        #endregion

        #region 4.thao tac voi CSDL
        private ConnectDB cn = new ConnectDB();
        private DataTable dt = new DataTable();

        private void ReadTable()
        {
            dt = cn.getTableData("select * from HINHANH");
        }
        private void ReadTable(String sql)
        {
            dt = cn.getTableData(sql);
        }

        public int CountRow()
        {
            return dt.Rows.Count;
        }
        public void GetRecord(int i)
        {
            Hinh_id = Int32.Parse(dt.Rows[i]["HINH_ID"].ToString());
            Cn_id = dt.Rows[i]["CN_ID"].ToString();
            Hinh_link = dt.Rows[i]["HINH_LINK"].ToString();
        }


        public DataTable GetTable()
        {
            return dt;
        }

        public void AddRecord()
        {
            string Caulenh = null;
            Caulenh = "INSERT INTO HINHANH VALUES ('" +Cn_id+ "','" +Hinh_link+ "')";
            //MessageBox.Show(Caulenh);
            cn.ExcuteSQLInsertOrDelete(Caulenh);
            MessageBox.Show("Đã lưu hình ảnh!", "Thông báo");
        }

        public void DeleteRecord(int id)
        {
            string Caulenh = null;
            Caulenh = "DELETE FROM HINHANH WHERE HINH_ID="+id;
            //MessageBox.Show(Caulenh);
            cn.ExcuteSQLInsertOrDelete(Caulenh);
            MessageBox.Show("Xóa thành công !", "Thông báo");
            
        }


        #endregion
    }
}
